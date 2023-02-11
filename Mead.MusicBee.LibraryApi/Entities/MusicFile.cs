using Mead.MusicBee.Api.Services.Abstract;
using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Entities.Abstract;
using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Extensions;
using Mead.MusicBee.LibraryApi.Factories.Abstract;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Entities;

public sealed class MusicFile : IMusicFile
{
    public string Path { get; }

    #region Fields

    public string TrackTitle
    {
        get => GetTagValue(MetaDataType.TrackTitle);
        set => SetTagValue(MetaDataType.TrackTitle, value);
    }

    public string Album
    {
        get => GetTagValue(MetaDataType.Album);
        set => SetTagValue(MetaDataType.Album, value);
    }

    public string AlbumArtist
    {
        get => GetTagValue(MetaDataType.AlbumArtist);
        set => SetTagValue(MetaDataType.AlbumArtist, value);
    }

    public string AlbumArtistRaw
    {
        get => GetTagValue(MetaDataType.AlbumArtistRaw);
        set => SetTagValue(MetaDataType.AlbumArtistRaw, value);
    }

    public string Artist
    {
        get => GetTagValue(MetaDataType.Artist);
        set => SetTagValue(MetaDataType.Artist, value);
    }

    public IReadOnlyList<string> MultiArtist
    {
        get => _musicFileTypedTagsManager.GetEncodedEnum(MetaDataType.MultiArtist);
        set => _musicFileTypedTagsManager.SetEncodedEnum(MetaDataType.MultiArtist, value);
    }

    public string PrimaryArtist
    {
        get => GetTagValue(MetaDataType.PrimaryArtist);
        set => SetTagValue(MetaDataType.PrimaryArtist, value);
    }

    public IReadOnlyList<string> Artists
    {
        get => _musicFileTypedTagsManager.GetEnum(MetaDataType.Artists);
        set => _musicFileTypedTagsManager.SetEnum(MetaDataType.Artists, value);
    }

    public string ArtistsWithArtistRole
    {
        get => GetTagValue(MetaDataType.ArtistsWithArtistRole);
        set => SetTagValue(MetaDataType.ArtistsWithArtistRole, value);
    }

    public string ArtistsWithPerformerRole
    {
        get => GetTagValue(MetaDataType.ArtistsWithPerformerRole);
        set => SetTagValue(MetaDataType.ArtistsWithPerformerRole, value);
    }

    public string ArtistsWithGuestRole
    {
        get => GetTagValue(MetaDataType.ArtistsWithGuestRole);
        set => SetTagValue(MetaDataType.ArtistsWithGuestRole, value);
    }

    public string ArtistsWithRemixerRole
    {
        get => GetTagValue(MetaDataType.ArtistsWithRemixerRole);
        set => SetTagValue(MetaDataType.ArtistsWithRemixerRole, value);
    }

    public string Artwork
    {
        get => GetTagValue(MetaDataType.Artwork);
        set => SetTagValue(MetaDataType.Artwork, value);
    }

    public long BeatsPerMin
    {
        get => _musicFileTypedTagsManager.GetNumber(MetaDataType.BeatsPerMin);
        set => _musicFileTypedTagsManager.SetNumber(MetaDataType.BeatsPerMin, value);
    }

    public string Composer
    {
        get => GetTagValue(MetaDataType.Composer);
        set => SetTagValue(MetaDataType.Composer, value);
    }

    public IReadOnlyList<string> MultiComposer
    {
        get => _musicFileTypedTagsManager.GetEncodedEnum(MetaDataType.MultiComposer);
        set => _musicFileTypedTagsManager.SetEncodedEnum(MetaDataType.MultiComposer, value);
    }

    public string Comment
    {
        get => GetTagValue(MetaDataType.Comment);
        set => SetTagValue(MetaDataType.Comment, value);
    }

    public string Conductor
    {
        get => GetTagValue(MetaDataType.Conductor);
        set => SetTagValue(MetaDataType.Conductor, value);
    }

    public IVariantField Custom1 { get; }

    public IVariantField Custom2 { get; }

    public IVariantField Custom3 { get; }

    public IVariantField Custom4 { get; }

    public IVariantField Custom5 { get; }

    public IVariantField Custom6 { get; }

    public IVariantField Custom7 { get; }

    public IVariantField Custom8 { get; }

    public IVariantField Custom9 { get; }

    public IVariantField Custom10 { get; }

    public IVariantField Custom11 { get; }

    public IVariantField Custom12 { get; }

    public IVariantField Custom13 { get; }

    public IVariantField Custom14 { get; }

    public IVariantField Custom15 { get; }

    public IVariantField Custom16 { get; }

    public long DiscNo
    {
        get => _musicFileTypedTagsManager.GetNumber(MetaDataType.DiscNo);
        set => _musicFileTypedTagsManager.SetNumber(MetaDataType.DiscNo, value);
    }

    public long DiscCount
    {
        get => _musicFileTypedTagsManager.GetNumber(MetaDataType.DiscCount);
        set => _musicFileTypedTagsManager.SetNumber(MetaDataType.DiscCount, value);
    }

    public string Encoder
    {
        get => GetTagValue(MetaDataType.Encoder);
        set => SetTagValue(MetaDataType.Encoder, value);
    }

    public IReadOnlyList<string> Genre
    {
        get => _musicFileTypedTagsManager.GetEnum(MetaDataType.Genre);
        set => _musicFileTypedTagsManager.SetEnum(MetaDataType.Genre, value);
    }

    public IReadOnlyList<string> Genres
    {
        get => _musicFileTypedTagsManager.GetEnum(MetaDataType.Genres);
        set => _musicFileTypedTagsManager.SetEnum(MetaDataType.Genres, value);
    }

    public IReadOnlyList<string> GenreCategory
    {
        get => _musicFileTypedTagsManager.GetEnum(MetaDataType.GenreCategory);
        set => _musicFileTypedTagsManager.SetEnum(MetaDataType.GenreCategory, value);
    }

    public IReadOnlyList<string> Grouping
    {
        get => _musicFileTypedTagsManager.GetEnum(MetaDataType.Grouping);
        set => _musicFileTypedTagsManager.SetEnum(MetaDataType.Grouping, value);
    }

    public IReadOnlyList<string> Keywords
    {
        get => _musicFileTypedTagsManager.GetEnum(MetaDataType.Keywords);
        set => _musicFileTypedTagsManager.SetEnum(MetaDataType.Keywords, value);
    }

    public bool HasLyrics
    {
        get => _musicFileTypedTagsManager.GetBool(MetaDataType.HasLyrics);
        set => _musicFileTypedTagsManager.SetBool(MetaDataType.HasLyrics, value);
    }

    public string Lyricist
    {
        get => GetTagValue(MetaDataType.Lyricist);
        set => SetTagValue(MetaDataType.Lyricist, value);
    }

    public string Lyrics
    {
        get => GetTagValue(MetaDataType.Lyrics);
        set => SetTagValue(MetaDataType.Lyrics, value);
    }

    public IReadOnlyList<string> Mood
    {
        get => _musicFileTypedTagsManager.GetEnum(MetaDataType.Mood);
        set => _musicFileTypedTagsManager.SetEnum(MetaDataType.Mood, value);
    }

    public IReadOnlyList<string> Occasion
    {
        get => _musicFileTypedTagsManager.GetEnum(MetaDataType.Occasion);
        set => _musicFileTypedTagsManager.SetEnum(MetaDataType.Occasion, value);
    }

    public string Origin
    {
        get => GetTagValue(MetaDataType.Origin);
        set => SetTagValue(MetaDataType.Origin, value);
    }

    public string Publisher
    {
        get => GetTagValue(MetaDataType.Publisher);
        set => SetTagValue(MetaDataType.Publisher, value);
    }

    public IReadOnlyList<string> Quality
    {
        get => _musicFileTypedTagsManager.GetEnum(MetaDataType.Quality);
        set => _musicFileTypedTagsManager.SetEnum(MetaDataType.Quality, value);
    }

    public Rating Rating
    {
        get => _musicFileTypedTagsManager.GetRating(MetaDataType.Rating);
        set => _musicFileTypedTagsManager.SetRating(MetaDataType.Rating, value);
    }

    public LoveBanRating RatingLove
    {
        get => _musicFileTypedTagsManager.GetLoveBanRating(MetaDataType.RatingLove);
        set => _musicFileTypedTagsManager.SetLoveBanRating(MetaDataType.RatingLove, value);
    }

    public Rating RatingAlbum
    {
        get => _musicFileTypedTagsManager.GetRating(MetaDataType.RatingAlbum);
        set => _musicFileTypedTagsManager.SetRating(MetaDataType.RatingAlbum, value);
    }

    public IReadOnlyList<string> Tempo
    {
        get => _musicFileTypedTagsManager.GetEnum(MetaDataType.Tempo);
        set => _musicFileTypedTagsManager.SetEnum(MetaDataType.Tempo, value);
    }

    public long TrackNo
    {
        get => _musicFileTypedTagsManager.GetNumber(MetaDataType.TrackNo);
        set => _musicFileTypedTagsManager.SetNumber(MetaDataType.TrackNo, value);
    }

    public long TrackCount
    {
        get => _musicFileTypedTagsManager.GetNumber(MetaDataType.TrackCount);
        set => _musicFileTypedTagsManager.SetNumber(MetaDataType.TrackCount, value);
    }

    public IVariantField Virtual1 { get; }

    public IVariantField Virtual2 { get; }

    public IVariantField Virtual3 { get; }

    public IVariantField Virtual4 { get; }

    public IVariantField Virtual5 { get; }

    public IVariantField Virtual6 { get; }

    public IVariantField Virtual7 { get; }

    public IVariantField Virtual8 { get; }

    public IVariantField Virtual9 { get; }

    public IVariantField Virtual10 { get; }

    public IVariantField Virtual11 { get; }

    public IVariantField Virtual12 { get; }

    public IVariantField Virtual13 { get; }

    public IVariantField Virtual14 { get; }

    public IVariantField Virtual15 { get; }

    public IVariantField Virtual16 { get; }

    public IVariantField Virtual17 { get; }

    public IVariantField Virtual18 { get; }

    public IVariantField Virtual19 { get; }

    public IVariantField Virtual20 { get; }

    public IVariantField Virtual21 { get; }

    public IVariantField Virtual22 { get; }

    public IVariantField Virtual23 { get; }

    public IVariantField Virtual24 { get; }

    public IVariantField Virtual25 { get; }

    public long Year
    {
        get => _musicFileTypedTagsManager.GetNumber(MetaDataType.Year);
        set => _musicFileTypedTagsManager.SetNumber(MetaDataType.Year, value);
    }

    public string SortTitle
    {
        get => GetTagValue(MetaDataType.SortTitle);
        set => SetTagValue(MetaDataType.SortTitle, value);
    }

    public string SortAlbum
    {
        get => GetTagValue(MetaDataType.SortAlbum);
        set => SetTagValue(MetaDataType.SortAlbum, value);
    }

    public string SortAlbumArtist
    {
        get => GetTagValue(MetaDataType.SortAlbumArtist);
        set => SetTagValue(MetaDataType.SortAlbumArtist, value);
    }

    public string SortArtist
    {
        get => GetTagValue(MetaDataType.SortArtist);
        set => SetTagValue(MetaDataType.SortArtist, value);
    }

    public string SortComposer
    {
        get => GetTagValue(MetaDataType.SortComposer);
        set => SetTagValue(MetaDataType.SortComposer, value);
    }

    public string Work
    {
        get => GetTagValue(MetaDataType.Work);
        set => SetTagValue(MetaDataType.Work, value);
    }

    public string MovementName
    {
        get => GetTagValue(MetaDataType.MovementName);
        set => SetTagValue(MetaDataType.MovementName, value);
    }

    public long MovementNo
    {
        get => _musicFileTypedTagsManager.GetNumber(MetaDataType.MovementNo);
        set => _musicFileTypedTagsManager.SetNumber(MetaDataType.MovementNo, value);
    }

    public long MovementCount
    {
        get => _musicFileTypedTagsManager.GetNumber(MetaDataType.MovementCount);
        set => _musicFileTypedTagsManager.SetNumber(MetaDataType.MovementCount, value);
    }

    public bool ShowMovement
    {
        get => _musicFileTypedTagsManager.GetBool(MetaDataType.ShowMovement);
        set => _musicFileTypedTagsManager.SetBool(MetaDataType.ShowMovement, value);
    }

    public string Language
    {
        get => GetTagValue(MetaDataType.Language);
        set => SetTagValue(MetaDataType.Language, value);
    }

    public string OriginalArtist
    {
        get => GetTagValue(MetaDataType.OriginalArtist);
        set => SetTagValue(MetaDataType.OriginalArtist, value);
    }

    public DateTime OriginalYear
    {
        get => _musicFileTypedTagsManager.GetDate(MetaDataType.OriginalYear);
        set => _musicFileTypedTagsManager.SetDate(MetaDataType.OriginalYear, value);
    }

    public string OriginalTitle
    {
        get => GetTagValue(MetaDataType.OriginalTitle);
        set => SetTagValue(MetaDataType.OriginalTitle, value);
    }

    #endregion

    private readonly IMusicBeeApi _musicBeeApi;
    private readonly ReadOnlyMusicFileFactory _readOnlyMusicFileFactory;
    private readonly IMusicFileTypedTagsManager _musicFileTypedTagsManager;

    private readonly IDictionary<MetaDataType, string> _changedTagValues;
    private IReadOnlyMusicFile _musicFileSnapshot;

    public MusicFile(
        string path,
        IMusicBeeApi musicBeeApi,
        ReadOnlyMusicFileFactory readOnlyMusicFileFactory,
        MusicFileTypedTagsManagerFactory musicFileTypedTagsManagerFactory,
        VariantFieldFactory variantFieldFactory)
    {
        _musicBeeApi = musicBeeApi;
        _readOnlyMusicFileFactory = readOnlyMusicFileFactory;
        _musicFileTypedTagsManager = musicFileTypedTagsManagerFactory(GetTagValue, SetTagValue);

        Path = path;

        #region Variant fields creation

        Custom1 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom1),
            x => SetTagValue(MetaDataType.Custom1, x)
        );
        Custom2 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom2),
            x => SetTagValue(MetaDataType.Custom2, x)
        );
        Custom3 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom3),
            x => SetTagValue(MetaDataType.Custom3, x)
        );
        Custom4 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom4),
            x => SetTagValue(MetaDataType.Custom4, x)
        );
        Custom5 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom5),
            x => SetTagValue(MetaDataType.Custom5, x)
        );
        Custom6 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom6),
            x => SetTagValue(MetaDataType.Custom6, x)
        );
        Custom7 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom7),
            x => SetTagValue(MetaDataType.Custom7, x)
        );
        Custom8 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom8),
            x => SetTagValue(MetaDataType.Custom8, x)
        );
        Custom9 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom9),
            x => SetTagValue(MetaDataType.Custom9, x)
        );
        Custom10 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom10),
            x => SetTagValue(MetaDataType.Custom10, x)
        );
        Custom11 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom11),
            x => SetTagValue(MetaDataType.Custom11, x)
        );
        Custom12 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom12),
            x => SetTagValue(MetaDataType.Custom12, x)
        );
        Custom13 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom13),
            x => SetTagValue(MetaDataType.Custom13, x)
        );
        Custom14 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom14),
            x => SetTagValue(MetaDataType.Custom14, x)
        );
        Custom15 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom15),
            x => SetTagValue(MetaDataType.Custom15, x)
        );
        Custom16 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Custom16),
            x => SetTagValue(MetaDataType.Custom16, x)
        );
        Virtual1 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual1),
            x => SetTagValue(MetaDataType.Virtual1, x)
        );
        Virtual2 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual2),
            x => SetTagValue(MetaDataType.Virtual2, x)
        );
        Virtual3 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual3),
            x => SetTagValue(MetaDataType.Virtual3, x)
        );
        Virtual4 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual4),
            x => SetTagValue(MetaDataType.Virtual4, x)
        );
        Virtual5 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual5),
            x => SetTagValue(MetaDataType.Virtual5, x)
        );
        Virtual6 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual6),
            x => SetTagValue(MetaDataType.Virtual6, x)
        );
        Virtual7 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual7),
            x => SetTagValue(MetaDataType.Virtual7, x)
        );
        Virtual8 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual8),
            x => SetTagValue(MetaDataType.Virtual8, x)
        );
        Virtual9 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual9),
            x => SetTagValue(MetaDataType.Virtual9, x)
        );
        Virtual10 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual10),
            x => SetTagValue(MetaDataType.Virtual10, x)
        );
        Virtual11 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual11),
            x => SetTagValue(MetaDataType.Virtual11, x)
        );
        Virtual12 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual12),
            x => SetTagValue(MetaDataType.Virtual12, x)
        );
        Virtual13 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual13),
            x => SetTagValue(MetaDataType.Virtual13, x)
        );
        Virtual14 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual14),
            x => SetTagValue(MetaDataType.Virtual14, x)
        );
        Virtual15 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual15),
            x => SetTagValue(MetaDataType.Virtual15, x)
        );
        Virtual16 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual16),
            x => SetTagValue(MetaDataType.Virtual16, x)
        );
        Virtual17 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual17),
            x => SetTagValue(MetaDataType.Virtual17, x)
        );
        Virtual18 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual18),
            x => SetTagValue(MetaDataType.Virtual18, x)
        );
        Virtual19 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual19),
            x => SetTagValue(MetaDataType.Virtual19, x)
        );
        Virtual20 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual20),
            x => SetTagValue(MetaDataType.Virtual20, x)
        );
        Virtual21 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual21),
            x => SetTagValue(MetaDataType.Virtual21, x)
        );
        Virtual22 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual22),
            x => SetTagValue(MetaDataType.Virtual22, x)
        );
        Virtual23 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual23),
            x => SetTagValue(MetaDataType.Virtual23, x)
        );
        Virtual24 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual24),
            x => SetTagValue(MetaDataType.Virtual24, x)
        );
        Virtual25 = variantFieldFactory(
            () => GetTagValue(MetaDataType.Virtual25),
            x => SetTagValue(MetaDataType.Virtual25, x)
        );

        #endregion

        _changedTagValues = new Dictionary<MetaDataType, string>();
        _musicFileSnapshot = _readOnlyMusicFileFactory(Path);
    }

    public string GetTagValue(MetaDataType metaDataType)
    {
        return _changedTagValues.TryGetValue(metaDataType, out var value)
            ? value
            : _musicFileSnapshot.GetTagValue(metaDataType);
    }

    public void SetTagValue(MetaDataType metaDataType, string value)
    {
        if (value == _musicFileSnapshot.GetTagValue(metaDataType))
        {
            _changedTagValues.Remove(metaDataType);
        }
        else
        {
            _changedTagValues[metaDataType] = value;
        }
    }

    public void Restore()
    {
        _changedTagValues.Clear();
    }

    public void Save()
    {
        foreach (var (metaDataType, value) in _changedTagValues)
        {
            _musicBeeApi.Library_SetFileTag(Path, metaDataType, value);
        }

        _musicBeeApi.Library_CommitTagsToFile(Path);

        _musicFileSnapshot = _readOnlyMusicFileFactory(Path);
    }
}
