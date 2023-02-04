﻿using Mead.MusicBee.Enums;
using Mead.MusicBee.MetaInfo.Entities;
using Mead.MusicBee.MetaInfo.Enums;

namespace Mead.MusicBee.MetaInfo.Helpers;

public static class FieldsInfoProvider
{
    private static readonly IReadOnlyList<MusicFileFieldInfo> FieldsInfo = new[]
    {
        new MusicFileFieldInfo(MetaDataType.TrackTitle, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.Album, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.AlbumArtist, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.AlbumArtistRaw, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.Artist, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.MultiArtist, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.PrimaryArtist, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.Artists, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.ArtistsWithArtistRole, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.ArtistsWithPerformerRole, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.ArtistsWithGuestRole, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.ArtistsWithRemixerRole, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.Artwork, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.BeatsPerMin, FieldType.Number),
        new MusicFileFieldInfo(MetaDataType.Composer, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.MultiComposer, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.Comment, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.Conductor, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.Custom1, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom2, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom3, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom4, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom5, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom6, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom7, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom8, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom9, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom10, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom11, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom12, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom13, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom14, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom15, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Custom16, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.DiscNo, FieldType.Number),
        new MusicFileFieldInfo(MetaDataType.DiscCount, FieldType.Number),
        new MusicFileFieldInfo(MetaDataType.Encoder, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.Genre, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.Genres, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.GenreCategory, FieldType.Enum),
        new MusicFileFieldInfo(MetaDataType.Grouping, FieldType.Enum),
        new MusicFileFieldInfo(MetaDataType.Keywords, FieldType.Enum),
        new MusicFileFieldInfo(MetaDataType.HasLyrics, FieldType.Bool),
        new MusicFileFieldInfo(MetaDataType.Lyricist, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.Lyrics, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.Mood, FieldType.Enum),
        new MusicFileFieldInfo(MetaDataType.Occasion, FieldType.Enum),
        new MusicFileFieldInfo(MetaDataType.Origin, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.Publisher, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.Quality, FieldType.Enum),
        new MusicFileFieldInfo(MetaDataType.Rating, FieldType.Rating),
        new MusicFileFieldInfo(MetaDataType.RatingLove, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.RatingAlbum, FieldType.Rating),
        new MusicFileFieldInfo(MetaDataType.Tempo, FieldType.Enum),
        new MusicFileFieldInfo(MetaDataType.TrackNo, FieldType.Number),
        new MusicFileFieldInfo(MetaDataType.TrackCount, FieldType.Number),
        new MusicFileFieldInfo(MetaDataType.Virtual1, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual2, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual3, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual4, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual5, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual6, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual7, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual8, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual9, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual10, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual11, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual12, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual13, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual14, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual15, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual16, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual17, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual18, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual19, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual20, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual21, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual22, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual23, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual24, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Virtual25, FieldType.Variant),
        new MusicFileFieldInfo(MetaDataType.Year, FieldType.Number),
        new MusicFileFieldInfo(MetaDataType.SortTitle, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.SortAlbum, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.SortAlbumArtist, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.SortArtist, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.SortComposer, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.Work, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.MovementName, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.MovementNo, FieldType.Number),
        new MusicFileFieldInfo(MetaDataType.MovementCount, FieldType.Number),
        new MusicFileFieldInfo(MetaDataType.ShowMovement, FieldType.String), // todo check field type
        new MusicFileFieldInfo(MetaDataType.Language, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.OriginalArtist, FieldType.String),
        new MusicFileFieldInfo(MetaDataType.OriginalYear, FieldType.Date),
        new MusicFileFieldInfo(MetaDataType.OriginalTitle, FieldType.String), // todo check field type
    };

    public static IReadOnlyList<MusicFileFieldInfo> GetFieldsInfo()
    {
        return FieldsInfo;
    }
}