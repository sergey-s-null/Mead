using Mead.MusicBee.LibraryApi.Entities.Abstract;
using Mead.MusicBee.LibraryApi.Exceptions;

namespace Mead.MusicBee.LibraryApi.Services.Abstract;

public interface IMusicBeeLibraryApi
{
    /// <exception cref="FilesRetrievingException"></exception>
    IReadOnlyList<IReadOnlyMusicFile> GetMusicFiles();

    /// <exception cref="FilesRetrievingException"></exception>
    IReadOnlyList<IMusicFile> GetEditableMusicFiles();
}