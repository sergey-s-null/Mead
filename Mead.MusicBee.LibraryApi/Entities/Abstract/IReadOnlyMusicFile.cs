using Mead.MusicBee.Enums;

namespace Mead.MusicBee.LibraryApi.Entities.Abstract;

public interface IReadOnlyMusicFile
{
    string Path { get; }

    string TrackTitle { get; }
    string Album { get; }
    string AlbumArtist { get; }
    string AlbumArtistRaw { get; }
    string Artist { get; }
    string MultiArtist { get; }
    string PrimaryArtist { get; }
    string Artists { get; }
    string ArtistsWithArtistRole { get; }
    string ArtistsWithPerformerRole { get; }
    string ArtistsWithGuestRole { get; }
    string ArtistsWithRemixerRole { get; }
    string Artwork { get; }
    long BeatsPerMin { get; }
    string Composer { get; }
    string MultiComposer { get; }
    string Comment { get; }
    string Conductor { get; }
    IReadOnlyVariantField Custom1 { get; }
    IReadOnlyVariantField Custom2 { get; }
    IReadOnlyVariantField Custom3 { get; }
    IReadOnlyVariantField Custom4 { get; }
    IReadOnlyVariantField Custom5 { get; }
    IReadOnlyVariantField Custom6 { get; }
    IReadOnlyVariantField Custom7 { get; }
    IReadOnlyVariantField Custom8 { get; }
    IReadOnlyVariantField Custom9 { get; }
    IReadOnlyVariantField Custom10 { get; }
    IReadOnlyVariantField Custom11 { get; }
    IReadOnlyVariantField Custom12 { get; }
    IReadOnlyVariantField Custom13 { get; }
    IReadOnlyVariantField Custom14 { get; }
    IReadOnlyVariantField Custom15 { get; }
    IReadOnlyVariantField Custom16 { get; }
    long DiscNo { get; }
    long DiscCount { get; }
    string Encoder { get; }
    string Genre { get; }
    string Genres { get; }
    IReadOnlyList<string> GenreCategory { get; }
    IReadOnlyList<string> Grouping { get; }
    IReadOnlyList<string> Keywords { get; }
    bool HasLyrics { get; }
    string Lyricist { get; }
    string Lyrics { get; }
    IReadOnlyList<string> Mood { get; }
    IReadOnlyList<string> Occasion { get; }
    string Origin { get; }
    string Publisher { get; }
    IReadOnlyList<string> Quality { get; }
    Rating Rating { get; }
    string RatingLove { get; }
    Rating RatingAlbum { get; }
    IReadOnlyList<string> Tempo { get; }
    long TrackNo { get; }
    long TrackCount { get; }
    IReadOnlyVariantField Virtual1 { get; }
    IReadOnlyVariantField Virtual2 { get; }
    IReadOnlyVariantField Virtual3 { get; }
    IReadOnlyVariantField Virtual4 { get; }
    IReadOnlyVariantField Virtual5 { get; }
    IReadOnlyVariantField Virtual6 { get; }
    IReadOnlyVariantField Virtual7 { get; }
    IReadOnlyVariantField Virtual8 { get; }
    IReadOnlyVariantField Virtual9 { get; }
    IReadOnlyVariantField Virtual10 { get; }
    IReadOnlyVariantField Virtual11 { get; }
    IReadOnlyVariantField Virtual12 { get; }
    IReadOnlyVariantField Virtual13 { get; }
    IReadOnlyVariantField Virtual14 { get; }
    IReadOnlyVariantField Virtual15 { get; }
    IReadOnlyVariantField Virtual16 { get; }
    IReadOnlyVariantField Virtual17 { get; }
    IReadOnlyVariantField Virtual18 { get; }
    IReadOnlyVariantField Virtual19 { get; }
    IReadOnlyVariantField Virtual20 { get; }
    IReadOnlyVariantField Virtual21 { get; }
    IReadOnlyVariantField Virtual22 { get; }
    IReadOnlyVariantField Virtual23 { get; }
    IReadOnlyVariantField Virtual24 { get; }
    IReadOnlyVariantField Virtual25 { get; }
    long Year { get; }
    string SortTitle { get; }
    string SortAlbum { get; }
    string SortAlbumArtist { get; }
    string SortArtist { get; }
    string SortComposer { get; }
    string Work { get; }
    string MovementName { get; }
    long MovementNo { get; }
    long MovementCount { get; }
    string ShowMovement { get; }
    string Language { get; }
    string OriginalArtist { get; }
    DateTime OriginalYear { get; }
    string OriginalTitle { get; }

    string GetTagValue(MetaDataType metaDataType);
}