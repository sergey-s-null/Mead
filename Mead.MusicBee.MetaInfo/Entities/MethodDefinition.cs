namespace Mead.MusicBee.MetaInfo.Entities;

public sealed record MethodDefinition(
    string Name,
    IReadOnlyCollection<ParameterDefinition> InputParameters,
    IReadOnlyCollection<ParameterDefinition> OutputParameters,
    ParameterDefinition ReturnParameter
);