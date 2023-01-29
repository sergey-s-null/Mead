using System;
using System.Collections.Generic;

namespace Mead.MusicBee.MetaInfo.Extensions;

internal static class TypeExtensions
{
    private static readonly IReadOnlyDictionary<Type, string> BaseTypesMappings = new Dictionary<Type, string>
    {
        [typeof(string)] = "string",
        [typeof(bool)] = "bool",
        [typeof(void)] = "void",
        [typeof(int)] = "int",
        [typeof(byte)] = "byte",
        [typeof(float)] = "float",
        [typeof(double)] = "double",
        [typeof(object)] = "object"
    };

    /// <summary>
    /// Return C# type alias instead of .Net CLR type:
    ///     String -> string
    ///     Int32 -> int
    /// </summary>
    public static string GetCSharpAlias(this Type type)
    {
        return BaseTypesMappings.TryGetValue(type, out var stringType)
            ? stringType
            : type.Name;
    }

    internal static Type RemoveRefWrapper(this Type type)
    {
        if (type.IsByRef && type.HasElementType)
        {
            return type.GetElementType()!;
        }

        return type;
    }
}