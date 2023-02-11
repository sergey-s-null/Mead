using Mead.MusicBee.Api.Services.Abstract;
using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Entities.Abstract;
using Mead.MusicBee.LibraryApi.Enums;
using Mead.MusicBee.LibraryApi.Factories.Abstract;
using Mead.MusicBee.LibraryApi.Services.Abstract;

namespace Mead.MusicBee.LibraryApi.Entities;

public sealed class CachingReadOnlyMusicFile : IReadOnlyMusicFile
{
    public string Path { get; }

    #region Fields

    public string TrackTitle => GetTagValue(MetaDataType.TrackTitle);
    public string Album => GetTagValue(MetaDataType.Album);
    public string AlbumArtist => GetTagValue(MetaDataType.AlbumArtist);
    public string AlbumArtistRaw => GetTagValue(MetaDataType.AlbumArtistRaw);
    public string Artist => GetTagValue(MetaDataType.Artist);
    public IReadOnlyList<string> MultiArtist => _musicFileTypedTagsGetter.GetEncodedEnum(MetaDataType.MultiArtist);
    public string PrimaryArtist => GetTagValue(MetaDataType.PrimaryArtist);
    public IReadOnlyList<string> Artists => _musicFileTypedTagsGetter.GetEnum(MetaDataType.Artists);
    public string ArtistsWithArtistRole => GetTagValue(MetaDataType.ArtistsWithArtistRole);
    public string ArtistsWithPerformerRole => GetTagValue(MetaDataType.ArtistsWithPerformerRole);
    public string ArtistsWithGuestRole => GetTagValue(MetaDataType.ArtistsWithGuestRole);
    public string ArtistsWithRemixerRole => GetTagValue(MetaDataType.ArtistsWithRemixerRole);
    public string Artwork => GetTagValue(MetaDataType.Artwork);
    public long BeatsPerMin => _musicFileTypedTagsGetter.GetNumber(MetaDataType.BeatsPerMin);
    public string Composer => GetTagValue(MetaDataType.Composer);
    public IReadOnlyList<string> MultiComposer => _musicFileTypedTagsGetter.GetEncodedEnum(MetaDataType.MultiComposer);
    public string Comment => GetTagValue(MetaDataType.Comment);
    public string Conductor => GetTagValue(MetaDataType.Conductor);
    public IReadOnlyVariantField Custom1 { get; }
    public IReadOnlyVariantField Custom2 { get; }
    public IReadOnlyVariantField Custom3 { get; }
    public IReadOnlyVariantField Custom4 { get; }
    public IReadOnlyVariantField Custom5 { get; }
    public IReadOnlyVariantField Custom6 { get; }
    public IReadOnlyVariantField Custom7 { get; }
    public IReadOnlyVariantField Custom8 { get; }
    public IReadOnlyVariantField Custom9 { get; }
    public IReadOnlyVariantField Custom10 { get; }
    public IReadOnlyVariantField Custom11 { get; }
    public IReadOnlyVariantField Custom12 { get; }
    public IReadOnlyVariantField Custom13 { get; }
    public IReadOnlyVariantField Custom14 { get; }
    public IReadOnlyVariantField Custom15 { get; }
    public IReadOnlyVariantField Custom16 { get; }
    public long DiscNo => _musicFileTypedTagsGetter.GetNumber(MetaDataType.DiscNo);
    public long DiscCount => _musicFileTypedTagsGetter.GetNumber(MetaDataType.DiscCount);
    public string Encoder => GetTagValue(MetaDataType.Encoder);
    public IReadOnlyList<string> Genre => _musicFileTypedTagsGetter.GetEnum(MetaDataType.Genre);
    public IReadOnlyList<string> Genres => _musicFileTypedTagsGetter.GetEnum(MetaDataType.Genres);
    public IReadOnlyList<string> GenreCategory => _musicFileTypedTagsGetter.GetEnum(MetaDataType.GenreCategory);
    public IReadOnlyList<string> Grouping => _musicFileTypedTagsGetter.GetEnum(MetaDataType.Grouping);
    public IReadOnlyList<string> Keywords => _musicFileTypedTagsGetter.GetEnum(MetaDataType.Keywords);
    public bool HasLyrics => _musicFileTypedTagsGetter.GetBool(MetaDataType.HasLyrics);
    public string Lyricist => GetTagValue(MetaDataType.Lyricist);
    public string Lyrics => GetTagValue(MetaDataType.Lyrics);
    public IReadOnlyList<string> Mood => _musicFileTypedTagsGetter.GetEnum(MetaDataType.Mood);
    public IReadOnlyList<string> Occasion => _musicFileTypedTagsGetter.GetEnum(MetaDataType.Occasion);
    public string Origin => GetTagValue(MetaDataType.Origin);
    public string Publisher => GetTagValue(MetaDataType.Publisher);
    public IReadOnlyList<string> Quality => _musicFileTypedTagsGetter.GetEnum(MetaDataType.Quality);
    public Rating Rating => _musicFileTypedTagsGetter.GetRating(MetaDataType.Rating);
    public LoveBanRating RatingLove => _musicFileTypedTagsGetter.GetLoveBanRating(MetaDataType.RatingLove);
    public Rating RatingAlbum => _musicFileTypedTagsGetter.GetRating(MetaDataType.RatingAlbum);
    public IReadOnlyList<string> Tempo => _musicFileTypedTagsGetter.GetEnum(MetaDataType.Tempo);
    public long TrackNo => _musicFileTypedTagsGetter.GetNumber(MetaDataType.TrackNo);
    public long TrackCount => _musicFileTypedTagsGetter.GetNumber(MetaDataType.TrackCount);
    public IReadOnlyVariantField Virtual1 { get; }
    public IReadOnlyVariantField Virtual2 { get; }
    public IReadOnlyVariantField Virtual3 { get; }
    public IReadOnlyVariantField Virtual4 { get; }
    public IReadOnlyVariantField Virtual5 { get; }
    public IReadOnlyVariantField Virtual6 { get; }
    public IReadOnlyVariantField Virtual7 { get; }
    public IReadOnlyVariantField Virtual8 { get; }
    public IReadOnlyVariantField Virtual9 { get; }
    public IReadOnlyVariantField Virtual10 { get; }
    public IReadOnlyVariantField Virtual11 { get; }
    public IReadOnlyVariantField Virtual12 { get; }
    public IReadOnlyVariantField Virtual13 { get; }
    public IReadOnlyVariantField Virtual14 { get; }
    public IReadOnlyVariantField Virtual15 { get; }
    public IReadOnlyVariantField Virtual16 { get; }
    public IReadOnlyVariantField Virtual17 { get; }
    public IReadOnlyVariantField Virtual18 { get; }
    public IReadOnlyVariantField Virtual19 { get; }
    public IReadOnlyVariantField Virtual20 { get; }
    public IReadOnlyVariantField Virtual21 { get; }
    public IReadOnlyVariantField Virtual22 { get; }
    public IReadOnlyVariantField Virtual23 { get; }
    public IReadOnlyVariantField Virtual24 { get; }
    public IReadOnlyVariantField Virtual25 { get; }
    public long Year => _musicFileTypedTagsGetter.GetNumber(MetaDataType.Year);
    public string SortTitle => GetTagValue(MetaDataType.SortTitle);
    public string SortAlbum => GetTagValue(MetaDataType.SortAlbum);
    public string SortAlbumArtist => GetTagValue(MetaDataType.SortAlbumArtist);
    public string SortArtist => GetTagValue(MetaDataType.SortArtist);
    public string SortComposer => GetTagValue(MetaDataType.SortComposer);
    public string Work => GetTagValue(MetaDataType.Work);
    public string MovementName => GetTagValue(MetaDataType.MovementName);
    public long MovementNo => _musicFileTypedTagsGetter.GetNumber(MetaDataType.MovementNo);
    public long MovementCount => _musicFileTypedTagsGetter.GetNumber(MetaDataType.MovementCount);
    public bool ShowMovement => _musicFileTypedTagsGetter.GetBool(MetaDataType.ShowMovement);
    public string Language => GetTagValue(MetaDataType.Language);
    public string OriginalArtist => GetTagValue(MetaDataType.OriginalArtist);
    public DateTime OriginalYear => _musicFileTypedTagsGetter.GetDate(MetaDataType.OriginalYear);
    public string OriginalTitle => GetTagValue(MetaDataType.OriginalTitle);

    #endregion

    private readonly IMusicBeeApi _musicBeeApi;
    private readonly IMusicFileTypedTagsGetter _musicFileTypedTagsGetter;

    private readonly IDictionary<MetaDataType, string> _cachedTagValues;

    public CachingReadOnlyMusicFile(
        string path,
        IMusicBeeApi musicBeeApi,
        MusicFileTypedTagsGetterFactory musicFileTypedTagsGetterFactory,
        ReadOnlyVariantFieldFactory readOnlyVariantFieldFactory)
    {
        _musicBeeApi = musicBeeApi;
        _musicFileTypedTagsGetter = musicFileTypedTagsGetterFactory(GetTagValue);

        #region Custom fields creation

        Custom1 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom1));
        Custom2 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom2));
        Custom3 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom3));
        Custom4 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom4));
        Custom5 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom5));
        Custom6 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom6));
        Custom7 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom7));
        Custom8 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom8));
        Custom9 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom9));
        Custom10 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom10));
        Custom11 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom11));
        Custom12 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom12));
        Custom13 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom13));
        Custom14 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom14));
        Custom15 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom15));
        Custom16 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Custom16));
        Virtual1 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual1));
        Virtual2 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual2));
        Virtual3 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual3));
        Virtual4 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual4));
        Virtual5 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual5));
        Virtual6 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual6));
        Virtual7 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual7));
        Virtual8 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual8));
        Virtual9 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual9));
        Virtual10 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual10));
        Virtual11 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual11));
        Virtual12 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual12));
        Virtual13 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual13));
        Virtual14 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual14));
        Virtual15 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual15));
        Virtual16 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual16));
        Virtual17 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual17));
        Virtual18 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual18));
        Virtual19 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual19));
        Virtual20 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual20));
        Virtual21 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual21));
        Virtual22 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual22));
        Virtual23 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual23));
        Virtual24 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual24));
        Virtual25 = readOnlyVariantFieldFactory(() => GetTagValue(MetaDataType.Virtual25));

        #endregion

        _cachedTagValues = new Dictionary<MetaDataType, string>();

        Path = path;
    }

    public string GetTagValue(MetaDataType metaDataType)
    {
        if (_cachedTagValues.TryGetValue(metaDataType, out var value))
        {
            return value;
        }

        value = _musicBeeApi.Library_GetFileTag(Path, metaDataType);
        _cachedTagValues[metaDataType] = value;
        return value;
    }
}
