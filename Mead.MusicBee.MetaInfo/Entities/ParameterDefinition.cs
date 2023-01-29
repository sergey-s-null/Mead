using System;

namespace Mead.MusicBee.MetaInfo.Entities;

public sealed record ParameterDefinition(
    Type Type,
    string Name,
    bool IsNullable
);