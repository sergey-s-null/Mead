using Mead.MusicBee.LibraryApi.Enums;

namespace Mead.MusicBee.LibraryApi.Services.Abstract;

public interface IFieldValuesConverter
{
    string ConvertBoolToString(bool value);
    bool ConvertStringToBool(string value);

    string ConvertNumberToString(long value);
    long ConvertStringToNumber(string value);

    string ConvertDateToString(DateTime value);
    DateTime ConvertStringToDate(string value);

    string ConvertEnumToString(IReadOnlyList<string> value);
    IReadOnlyList<string> ConvertStringToEnum(string value);

    string ConvertRatingToString(Rating value);
    Rating ConvertStringToRating(string value);
}