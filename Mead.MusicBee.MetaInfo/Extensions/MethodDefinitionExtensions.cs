using System.Linq;
using Mead.MusicBee.MetaInfo.Entities;

namespace Mead.MusicBee.MetaInfo.Extensions;

public static class MethodDefinitionExtensions
{
    public static bool HasAnyOutputParameters(this MethodDefinition methodDefinition)
    {
        return methodDefinition.ReturnParameter.Type != typeof(void)
               || methodDefinition.OutputParameters.Count > 0;
    }

    public static bool HasInputParameters(this MethodDefinition methodDefinition)
    {
        return methodDefinition.InputParameters.Count > 0;
    }

    public static bool HasReturnType(this MethodDefinition methodDefinition)
    {
        return methodDefinition.ReturnParameter.Type != typeof(void);
    }

    /// <summary>
    /// Example: for method
    /// <code>
    /// public void SomeMethod(int first, string second, out double result) {  }
    /// </code>
    /// this method return "int first, string second, out double result"
    /// </summary>
    public static string GetClassMethodArguments(this MethodDefinition method)
    {
        var inParams = method.InputParameters
            .Select(x => $"{x.GetCSharpTypeName()} {x.Name}");
        var outParams = method.OutputParameters
            .Select(x => $"out {x.GetCSharpTypeName()} {x.Name}");
        return string.Join(", ", inParams.Concat(outParams));
    }

    /// <summary>
    /// Example: for method and method calling
    /// <code>
    /// public void SomeMethod(int first, string second, out double result) {  }
    /// obj.SomeMethod(first, second, out result);
    /// </code>
    /// this method return "first, second, out result".
    /// </summary>
    public static string GetMethodCallingArguments(this MethodDefinition method)
    {
        var inParams = method.InputParameters
            .Select(x => x.Name);
        var outParams = method.OutputParameters
            .Select(x => $"out {x.Name}");
        return string.Join(", ", inParams.Concat(outParams));
    }
}