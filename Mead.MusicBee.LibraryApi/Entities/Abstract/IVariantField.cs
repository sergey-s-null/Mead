namespace Mead.MusicBee.LibraryApi.Entities.Abstract;

public interface IVariantField
{
    string StringValue { get; set; }

    bool BoolValue { get; set; }
    long NumberValue { get; set; }
    DateTime DateValue { get; set; }
    IReadOnlyList<string> EnumValue { get; set; }
    Rating RatingValue { get; set; }
}