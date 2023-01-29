using System.Collections.Generic;
using System.Linq;

namespace Mead.MusicBee.MetaInfo.Extensions;

internal static class EnumerableExtensions
{
    public static IEnumerable<TDest> CastOrSkip<TSource, TDest>(this IEnumerable<TSource> items)
    {
        return items
            .Where(x => x is TDest)
            .Cast<TDest>();
    }
}