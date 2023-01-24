namespace Mead.MusicBee.Enums;

public enum CallbackType
{
    SettingsUpdated = 1,
    StorageReady = 2,
    StorageFailed = 3,
    FilesRetrievedChanged = 4,
    FilesRetrievedNoChange = 5,
    FilesRetrievedFail = 6,
    LyricsDownloaded = 7,
    StorageEject = 8,
    SuspendPlayCounters = 9,
    ResumePlayCounters = 10,
    EnablePlugin = 11,
    DisablePlugin = 12,
    RenderingDevicesChanged = 13,
    FullscreenOn = 14,
    FullscreenOff = 15
}