using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Exceptions;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class RatingFieldValueConverter : IFieldValueConverter<Rating>
{
    public string ConvertToString(Rating value)
    {
        return value switch
        {
            Rating.Unset => string.Empty,
            Rating.Half => "0,5",
            Rating.One => "1",
            Rating.OneAndHalf => "1,5",
            Rating.Two => "2",
            Rating.TwoAndHalf => "2,5",
            Rating.Three => "3",
            Rating.ThreeAndHalf => "3,5",
            Rating.Four => "4",
            Rating.FourAndHalf => "4,5",
            Rating.Five => "5",
            _ => throw new FieldConversionException(
                $"Rating value {value} is out of range."
            )
        };
    }

    public Rating ConvertFromString(string value)
    {
        return value switch
        {
            "" => Rating.Unset,
            "0,5" => Rating.Half,
            "1" => Rating.One,
            "1,5" => Rating.OneAndHalf,
            "2" => Rating.Two,
            "2,5" => Rating.TwoAndHalf,
            "3" => Rating.Three,
            "3,5" => Rating.ThreeAndHalf,
            "4" => Rating.Four,
            "4,5" => Rating.FourAndHalf,
            "5" => Rating.Five,
            _ => throw new FieldConversionException(
                $"Could not convert \"{value}\" to rating."
            )
        };
    }
}