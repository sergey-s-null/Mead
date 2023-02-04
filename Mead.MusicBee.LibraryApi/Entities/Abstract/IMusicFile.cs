using Mead.MusicBee.Enums;
using Mead.MusicBee.LibraryApi.Enums;

namespace Mead.MusicBee.LibraryApi.Entities.Abstract;

public interface IMusicFile
{
    string Path { get; }

    string TrackTitle { get; set; }
    string Album { get; set; }
    string AlbumArtist { get; set; }
    string AlbumArtistRaw { get; set; }
    string Artist { get; set; }
    string MultiArtist { get; set; }
    string PrimaryArtist { get; set; }
    string Artists { get; set; }
    string ArtistsWithArtistRole { get; set; }
    string ArtistsWithPerformerRole { get; set; }
    string ArtistsWithGuestRole { get; set; }
    string ArtistsWithRemixerRole { get; set; }
    string Artwork { get; set; }
    long BeatsPerMin { get; set; }
    string Composer { get; set; }
    string MultiComposer { get; set; }
    string Comment { get; set; }
    string Conductor { get; set; }
    IVariantField Custom1 { get; }
    IVariantField Custom2 { get; }
    IVariantField Custom3 { get; }
    IVariantField Custom4 { get; }
    IVariantField Custom5 { get; }
    IVariantField Custom6 { get; }
    IVariantField Custom7 { get; }
    IVariantField Custom8 { get; }
    IVariantField Custom9 { get; }
    IVariantField Custom10 { get; }
    IVariantField Custom11 { get; }
    IVariantField Custom12 { get; }
    IVariantField Custom13 { get; }
    IVariantField Custom14 { get; }
    IVariantField Custom15 { get; }
    IVariantField Custom16 { get; }
    long DiscNo { get; set; }
    long DiscCount { get; set; }
    string Encoder { get; set; }
    string Genre { get; set; }
    string Genres { get; set; }
    IReadOnlyList<string> GenreCategory { get; set; }
    IReadOnlyList<string> Grouping { get; set; }
    IReadOnlyList<string> Keywords { get; set; }
    bool HasLyrics { get; set; }
    string Lyricist { get; set; }
    string Lyrics { get; set; }
    IReadOnlyList<string> Mood { get; set; }
    IReadOnlyList<string> Occasion { get; set; }
    string Origin { get; set; }
    string Publisher { get; set; }
    IReadOnlyList<string> Quality { get; set; }
    Rating Rating { get; set; }
    string RatingLove { get; set; }
    Rating RatingAlbum { get; set; }
    IReadOnlyList<string> Tempo { get; set; }
    long TrackNo { get; set; }
    long TrackCount { get; set; }
    IVariantField Virtual1 { get; }
    IVariantField Virtual2 { get; }
    IVariantField Virtual3 { get; }
    IVariantField Virtual4 { get; }
    IVariantField Virtual5 { get; }
    IVariantField Virtual6 { get; }
    IVariantField Virtual7 { get; }
    IVariantField Virtual8 { get; }
    IVariantField Virtual9 { get; }
    IVariantField Virtual10 { get; }
    IVariantField Virtual11 { get; }
    IVariantField Virtual12 { get; }
    IVariantField Virtual13 { get; }
    IVariantField Virtual14 { get; }
    IVariantField Virtual15 { get; }
    IVariantField Virtual16 { get; }
    IVariantField Virtual17 { get; }
    IVariantField Virtual18 { get; }
    IVariantField Virtual19 { get; }
    IVariantField Virtual20 { get; }
    IVariantField Virtual21 { get; }
    IVariantField Virtual22 { get; }
    IVariantField Virtual23 { get; }
    IVariantField Virtual24 { get; }
    IVariantField Virtual25 { get; }
    long Year { get; set; }
    string SortTitle { get; set; }
    string SortAlbum { get; set; }
    string SortAlbumArtist { get; set; }
    string SortArtist { get; set; }
    string SortComposer { get; set; }
    string Work { get; set; }
    string MovementName { get; set; }
    long MovementNo { get; set; }
    long MovementCount { get; set; }
    string ShowMovement { get; set; }
    string Language { get; set; }
    string OriginalArtist { get; set; }
    DateTime OriginalYear { get; set; }
    string OriginalTitle { get; set; }

    string GetTagValue(MetaDataType metaDataType);
    void SetTagValue(MetaDataType metaDataType, string value);

    void Restore();
    void Save();
}