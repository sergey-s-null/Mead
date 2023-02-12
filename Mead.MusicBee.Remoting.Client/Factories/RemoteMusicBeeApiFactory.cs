using Grpc.Core;
using Mead.MusicBee.Api.Services.Abstract;
using Mead.MusicBee.Remoting.Client.Entities;
using Mead.MusicBee.Remoting.Client.Services;

namespace Mead.MusicBee.Remoting.Client.Factories;

public static class RemoteMusicBeeApiFactory
{
    public static IMusicBeeApi Create(ConnectionParameters parameters)
    {
        var channel = new Channel(parameters.Host, parameters.Port, ChannelCredentials.Insecure);
        var client = new MusicBeeApiService.MusicBeeApiServiceClient(channel);
        return new MusicBeeApiClientWrapper(client);
    }
}