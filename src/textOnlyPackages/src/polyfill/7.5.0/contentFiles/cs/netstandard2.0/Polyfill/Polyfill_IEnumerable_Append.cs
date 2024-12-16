// <auto-generated />
#pragma warning disable

#if NET46X || NET47

namespace Polyfills;

using System.Collections;
using System.Collections.Generic;
using System.Linq;

static partial class Polyfill
{
    /// <summary>
    /// Appends a value to the end of the sequence.
    /// </summary>
    /// <param name="source">A sequence of values.</param>
    /// <param name="element">The value to append to <paramref name="target" />.</param>
    /// <typeparam name="TSource">The type of the elements of source.</typeparam>
    /// <returns>A new sequence that ends with element.</returns>
    //Link: https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.append
    public static IEnumerable<TSource> Append<TSource>(
        this IEnumerable<TSource> target,
        TSource element)
    {
        foreach (var item in target)
        {
            yield return item;
        }

        yield return element;
    }
}
#endif