using System;

namespace Mead.MusicBee.Enums;

public enum NotificationType
{
    PluginStartup = 0,          // notification sent after successful initialisation for an enabled plugin
    TrackChanging = 16,
    TrackChanged = 1,
    PlayStateChanged = 2,
    AutoDjStarted = 3,
    AutoDjStopped = 4,
    VolumeMuteChanged = 5,
    VolumeLevelChanged = 6,
    [Obsolete("Use PlayingTracksChanged")] NowPlayingListChanged = 7,
    NowPlayingListEnded = 18,
    NowPlayingArtworkReady = 8,
    NowPlayingLyricsReady = 9,
    TagsChanging = 10,
    TagsChanged = 11,
    RatingChanging = 15,
    RatingChanged = 12,
    PlayCountersChanged = 13,
    ScreenSaverActivating = 14,
    ShutdownStarted = 17,
    EmbedInPanel = 19,
    PlayerRepeatChanged = 20,
    PlayerShuffleChanged = 21,
    PlayerEqualiserOnOffChanged = 22,
    PlayerScrobbleChanged = 23,
    ReplayGainChanged = 24,
    FileDeleting = 25,
    FileDeleted = 26,
    ApplicationWindowChanged = 27,
    StopAfterCurrentChanged = 28,
    LibrarySwitched = 29,
    FileAddedToLibrary = 30,
    FileAddedToInbox = 31,
    SynchCompleted = 32,
    DownloadCompleted = 33,
    MusicBeeStarted = 34,
    PlayingTracksChanged = 35,
    PlayingTracksQueueChanged = 36,
    PlaylistCreated = 37,
    PlaylistUpdated = 38,
    PlaylistDeleted = 39
}