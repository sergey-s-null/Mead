using Mead.MusicBee.MetaInfo.Enums;

namespace Mead.MusicBee.MetaInfo.Extensions;

public static class FieldTypeExtensions
{
    public static string GetCSharpType(this FieldType fieldType, bool isReadOnly)
    {
        return fieldType switch
        {
            FieldType.Bool => "bool",
            FieldType.String => "string",
            FieldType.Number => "long",
            FieldType.Date => "DateTime",
            FieldType.Enum => "IReadOnlyList<string>",
            FieldType.EncodedEnum => "IReadOnlyList<string>",
            FieldType.Rating => "Rating",
            FieldType.LoveBanRating => "LoveBanRating",
            FieldType.Variant => isReadOnly
                ? "IReadOnlyVariantField"
                : "IVariantField",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}