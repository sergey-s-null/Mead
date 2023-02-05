using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class BoolFieldValueConverter : IFieldValueConverter<bool>
{
    public string ConvertToString(bool value)
    {
        throw new NotImplementedException();
    }

    public bool ConvertFromString(string value)
    {
        throw new NotImplementedException();
    }
}