using Mead.MusicBee.Enums;
using Mead.MusicBee.MetaInfo.Enums;

namespace Mead.MusicBee.MetaInfo.Entities;

public sealed record MusicFileFieldInfo(
    MetaDataType MetaDataType,
    FieldType FieldType
);