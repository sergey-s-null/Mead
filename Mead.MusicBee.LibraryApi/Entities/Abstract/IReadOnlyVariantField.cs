namespace Mead.MusicBee.LibraryApi.Entities.Abstract;

public interface IReadOnlyVariantField
{
    string StringValue { get; }

    bool BoolValue { get; }
    long NumberValue { get; }
    DateTime DateValue { get; }
    IReadOnlyList<string> EnumValue { get; }
    Rating RatingValue { get; }
}