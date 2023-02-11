namespace Mead.MusicBee.LibraryApi.Exceptions;

public sealed class FieldConversionException : Exception
{
    public FieldConversionException(string message) : base(message)
    {
    }

    public FieldConversionException(string message, Exception innerException) : base(message, innerException)
    {
    }
}