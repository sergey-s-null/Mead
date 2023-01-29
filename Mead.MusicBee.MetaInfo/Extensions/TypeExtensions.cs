using System;

namespace Mead.MusicBee.MetaInfo.Extensions;

internal static class TypeExtensions
{
    public static Type RemoveRefWrapper(this Type type)
    {
        if (type.IsByRef && type.HasElementType)
        {
            return type.GetElementType()!;
        }

        return type;
    }
}