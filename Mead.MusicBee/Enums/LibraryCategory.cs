using System;

namespace Mead.MusicBee.Enums;

[Flags]
public enum LibraryCategory
{
    Music = 0,
    Audiobook = 1,
    Video = 2,
    Inbox = 4
}