namespace Mead.MusicBee.LibraryApi.Services.Abstract;

public interface IFieldValueConverter<T>
{
    string ConvertToString(T value);

    T ConvertFromString(string value);
}