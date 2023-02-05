using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class DateFieldValueConverter : IFieldValueConverter<DateTime>
{
    public string ConvertToString(DateTime value)
    {
        throw new NotImplementedException();
    }

    public DateTime ConvertFromString(string value)
    {
        throw new NotImplementedException();
    }
}