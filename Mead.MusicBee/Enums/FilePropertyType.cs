namespace Mead.MusicBee.Enums;

public enum FilePropertyType
{
    Url = 2,
    Kind = 4,
    Format = 5,
    Size = 7,
    Channels = 8,
    SampleRate = 9,
    Bitrate = 10,
    DateModified = 11,
    DateAdded = 12,
    LastPlayed = 13,
    PlayCount = 14,
    SkipCount = 15,
    Duration = 16,
    Status = 21,
    NowPlayingListIndex = 78,  // only has meaning when called from NowPlayingList_* commands
    ReplayGainTrack = 94,
    ReplayGainAlbum = 95
}