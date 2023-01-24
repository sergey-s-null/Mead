using System;

namespace Mead.MusicBee.Enums;

[Flags]
public enum ReceiveNotificationFlags
{
    StartupOnly = 0x0,
    PlayerEvents = 0x1,
    DataStreamEvents = 0x2,
    TagEvents = 0x04,
    DownloadEvents = 0x08
}