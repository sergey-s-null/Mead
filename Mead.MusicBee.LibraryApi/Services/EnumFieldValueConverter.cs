using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class EnumFieldValueConverter : IFieldValueConverter<IReadOnlyList<string>>
{
    public string ConvertToString(IReadOnlyList<string> value)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<string> ConvertFromString(string value)
    {
        throw new NotImplementedException();
    }
}