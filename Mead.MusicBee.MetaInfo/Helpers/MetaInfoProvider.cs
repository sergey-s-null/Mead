using System.Reflection;
using Mead.MusicBee.MetaInfo.Entities;
using Mead.MusicBee.MetaInfo.Extensions;
using Mead.MusicBee.Services;

namespace Mead.MusicBee.MetaInfo.Helpers;

public static class MetaInfoProvider
{
    private static readonly ISet<string> ObsoleteMethods = new HashSet<string>
    {
        "Library_GetArtwork",
        "Library_QueryGetAllFiles",
        "NowPlayingList_QueryGetAllFiles",
        "Playlist_QueryGetAllFiles",
    };

    private static readonly ISet<string> PlatformDependantMethods = new HashSet<string>
    {
        // IntPtr
        "MB_GetWindowHandle",
        // EventHandler
        "MB_AddMenuItem",
        // ThreadStart
        "MB_CreateBackgroundTask",
        // EventHandler
        "MB_RegisterCommand",
        // Font
        "Setting_GetDefaultFont",
        // Rectangle
        "MB_GetPanelBounds",
        // Control
        "MB_AddPanel",
        // Control
        "MB_RemovePanel",
        // ParameterizedThreadStart
        "MB_CreateParameterisedBackgroundTask",
        // Control
        "MB_SetPanelScrollableArea",
        // object
        "MB_InvokeCommand",
        // object
        "Setting_GetValue",
        // DateTime
        "Library_GetSyncDelta",
        // EventHandler
        "MB_AddTreeNode",
    };

    public static IReadOnlyCollection<MethodDefinition> GetMethodsWithoutRestrictions()
    {
        return GetMethods(x =>
            !ObsoleteMethods.Contains(x.Name)
            && !PlatformDependantMethods.Contains(x.Name)
        );
    }

    public static IReadOnlyCollection<MethodDefinition> GetPlatformDependantMethods()
    {
        return GetMethods(x => PlatformDependantMethods.Contains(x.Name));
    }

    public static IReadOnlyCollection<MethodDefinition> GetMethodsExceptObsolete()
    {
        return GetMethods(x => !ObsoleteMethods.Contains(x.Name));
    }

    private static IReadOnlyCollection<MethodDefinition> GetMethods(Func<FieldInfo, bool> methodsFilter)
    {
        return typeof(MusicBeeApiMemoryContainer)
            .GetMembers()
            .CastOrSkip<MemberInfo, FieldInfo>()
            .Where(x => x.IsDelegate())
            .Where(methodsFilter)
            .Select(GetMethodDefinition)
            .ToList();
    }

    private static MethodDefinition GetMethodDefinition(FieldInfo delegateFieldInfo)
    {
        var name = delegateFieldInfo.Name;

        var (returnParameter, parameters) = GetDelegateFieldParameters(delegateFieldInfo);

        var inputParameters = parameters
            .Where(x => !x.IsOut)
            .Select(GetParameterDefinition)
            .ToList();

        var outputParameters = parameters
            .Where(x => x.IsOut)
            .Select(GetParameterDefinition)
            .ToList();

        return new MethodDefinition(
            name,
            inputParameters,
            outputParameters,
            new ParameterDefinition(
                returnParameter.ParameterType,
                string.Empty,
                returnParameter.IsNullable()
            )
        );
    }

    private static (ParameterInfo returnParameter, ParameterInfo[] parameters) GetDelegateFieldParameters(
        FieldInfo delegateFieldInfo)
    {
        var invokeMethod = delegateFieldInfo.FieldType.GetMethod("Invoke");
        if (invokeMethod is null)
        {
            throw new Exception($"Invoke method of delegate field {delegateFieldInfo.Name} is null.");
        }

        return (invokeMethod.ReturnParameter, invokeMethod.GetParameters());
    }


    private static ParameterDefinition GetParameterDefinition(ParameterInfo parameterInfo)
    {
        return new ParameterDefinition(
            parameterInfo.ParameterType.RemoveRefWrapper(),
            parameterInfo.Name,
            parameterInfo.IsNullable()
        );
    }
}