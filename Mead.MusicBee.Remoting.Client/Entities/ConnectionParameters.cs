namespace Mead.MusicBee.Remoting.Client.Entities;

public sealed record ConnectionParameters(
    string Host,
    int Port
);