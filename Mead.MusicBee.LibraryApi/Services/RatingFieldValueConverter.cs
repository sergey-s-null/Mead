using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class RatingFieldValueConverter : IFieldValueConverter<Rating>
{
    public string ConvertToString(Rating value)
    {
        throw new NotImplementedException();
    }

    public Rating ConvertFromString(string value)
    {
        throw new NotImplementedException();
    }
}