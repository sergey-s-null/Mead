namespace Mead.MusicBee.Enums;

public enum MetaDataType
{
    TrackTitle = 65,
    Album = 30,
    AlbumArtist = 31,        // displayed album artist
    AlbumArtistRaw = 34,     // stored album artist
    Artist = 32,             // displayed artist
    MultiArtist = 33,        // individual artists, separated by a null char
    /// <summary>
    /// Первый артист из списка артистов, иначе отображаемый артист
    /// </summary>
    PrimaryArtist = 19,
    Artists = 144,
    ArtistsWithArtistRole = 145,
    ArtistsWithPerformerRole = 146,
    ArtistsWithGuestRole = 147,
    ArtistsWithRemixerRole = 148,
    Artwork = 40,
    BeatsPerMin = 41,
    Composer = 43,           // displayed composer
    MultiComposer = 89,      // individual composers, separated by a null char
    /// <summary>
    /// Комментарий
    /// </summary>
    Comment = 44,
    Conductor = 45,
    Custom1 = 46,
    Custom2 = 47,
    Custom3 = 48,
    Custom4 = 49,
    Custom5 = 50,
    Custom6 = 96,
    Custom7 = 97,
    Custom8 = 98,
    Custom9 = 99,
    Custom10 = 128,
    Custom11 = 129,
    Custom12 = 130,
    Custom13 = 131,
    Custom14 = 132,
    Custom15 = 133,
    Custom16 = 134,
    DiscNo = 52,
    DiscCount = 54,
    Encoder = 55,
    Genre = 59,
    Genres = 143,
    GenreCategory = 60,
    Grouping = 61,
    Keywords = 84,
    HasLyrics = 63,
    Lyricist = 62,
    Lyrics = 114,
    Mood = 64,
    Occasion = 66,
    Origin = 67,
    Publisher = 73,
    Quality = 74,
    Rating = 75,
    RatingLove = 76,
    RatingAlbum = 104,
    Tempo = 85,
    TrackNo = 86,
    TrackCount = 87,
    Virtual1 = 109,
    Virtual2 = 110,
    Virtual3 = 111,
    Virtual4 = 112,
    Virtual5 = 113,
    Virtual6 = 122,
    Virtual7 = 123,
    Virtual8 = 124,
    Virtual9 = 125,
    Virtual10 = 135,
    Virtual11 = 136,
    Virtual12 = 137,
    Virtual13 = 138,
    Virtual14 = 139,
    Virtual15 = 140,
    Virtual16 = 141,
    Virtual17 = 149,
    Virtual18 = 150,
    Virtual19 = 151,
    Virtual20 = 152,
    Virtual21 = 153,
    Virtual22 = 154,
    Virtual23 = 155,
    Virtual24 = 156,
    Virtual25 = 157,
    Year = 88,
    /// <summary>
    /// Вероятно, по умолчанию может отличаться. Например "The" переносит в конец.
    /// </summary>
    SortTitle = 163,
    SortAlbum = 164,
    SortAlbumArtist = 165,
    SortArtist = 166,
    SortComposer = 167,
    Work = 168,
    MovementName = 169,
    MovementNo = 170,
    MovementCount = 171,
    ShowMovement = 172,
    Language = 173,
    /// <summary>
    /// Первоначальный исполнитель
    /// </summary>
    OriginalArtist = 174,
    /// <summary>
    /// Год первоначального исполнения
    /// </summary>
    OriginalYear = 175,
    /// <summary>
    /// Первоначальное название
    /// </summary>
    OriginalTitle = 177
}