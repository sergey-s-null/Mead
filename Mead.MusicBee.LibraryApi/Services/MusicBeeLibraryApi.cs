using Mead.MusicBee.Api.Services.Abstract;
using Mead.MusicBee.LibraryApi.Entities.Abstract;
using Mead.MusicBee.LibraryApi.Exceptions;
using Mead.MusicBee.LibraryApi.Factories.Abstract;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Services;

public sealed class MusicBeeLibraryApi : IMusicBeeLibraryApi
{
    private readonly IMusicBeeApi _musicBeeApi;
    private readonly ReadOnlyMusicFileFactory _readOnlyMusicFileFactory;
    private readonly MusicFileFactory _musicFileFactory;

    public MusicBeeLibraryApi(
        IMusicBeeApi musicBeeApi,
        ReadOnlyMusicFileFactory readOnlyMusicFileFactory,
        MusicFileFactory musicFileFactory)
    {
        _musicBeeApi = musicBeeApi;
        _readOnlyMusicFileFactory = readOnlyMusicFileFactory;
        _musicFileFactory = musicFileFactory;
    }

    /// <exception cref="FilesRetrievingException"></exception>
    public IReadOnlyList<IReadOnlyMusicFile> GetMusicFiles()
    {
        return GetFilesPaths()
            .Select(x => _readOnlyMusicFileFactory(x))
            .ToList();
    }

    /// <exception cref="FilesRetrievingException"></exception>
    public IReadOnlyList<IMusicFile> GetEditableMusicFiles()
    {
        return GetFilesPaths()
            .Select(x => _musicFileFactory(x))
            .ToList();
    }

    /// <exception cref="FilesRetrievingException"></exception>
    private IReadOnlyCollection<string> GetFilesPaths()
    {
        if (!_musicBeeApi.Library_QueryFilesEx(string.Empty, out var files)
            || files is null)
        {
            throw new FilesRetrievingException("Could not get files from MusicBee Api.");
        }

        return files;
    }
}