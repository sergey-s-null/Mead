using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public class FieldValuesConverter : IFieldValuesConverter
{
    public string ConvertBoolToString(bool value)
    {
        throw new NotImplementedException();
    }

    public bool ConvertStringToBool(string value)
    {
        throw new NotImplementedException();
    }

    public string ConvertNumberToString(long value)
    {
        throw new NotImplementedException();
    }

    public long ConvertStringToNumber(string value)
    {
        throw new NotImplementedException();
    }

    public string ConvertDateToString(DateTime value)
    {
        throw new NotImplementedException();
    }

    public DateTime ConvertStringToDate(string value)
    {
        throw new NotImplementedException();
    }

    public string ConvertEnumToString(IReadOnlyList<string> value)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<string> ConvertStringToEnum(string value)
    {
        throw new NotImplementedException();
    }

    public string ConvertRatingToString(Rating value)
    {
        throw new NotImplementedException();
    }

    public Rating ConvertStringToRating(string value)
    {
        throw new NotImplementedException();
    }
}