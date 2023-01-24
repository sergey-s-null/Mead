using System;

namespace Mead.MusicBee.Enums;

[Flags]
public enum PictureLocations: byte
{
    None = 0,
    EmbedInFile = 1,
    LinkToOrganisedCopy = 2,
    LinkToSource = 4,
    FolderThumb = 8
}