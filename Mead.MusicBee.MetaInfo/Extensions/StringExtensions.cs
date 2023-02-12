namespace Mead.MusicBee.MetaInfo.Extensions;

public static class StringExtensions
{
    public static string Capitalize(this string value)
    {
        return value.Length switch
        {
            0 => value,
            1 => value.ToUpper(),
            _ => char.ToUpper(value[0]) + value.Substring(1)
        };
    }
}