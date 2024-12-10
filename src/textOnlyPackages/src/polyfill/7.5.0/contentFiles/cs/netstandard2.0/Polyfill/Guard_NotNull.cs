// <auto-generated />
#pragma warning disable

namespace Polyfills;

#if PolyGuard

using System;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

#if PolyPublic
public
#endif
static partial class Guard
{
    public static T NotNull<T>(
        [NotNull] T? argument,
        [CallerArgumentExpression("argument")] string? name = null)
        where T : class
    {
        if (argument is null)
        {
            throw new ArgumentNullException(name);
        }

        return argument;
    }

    public static string NotNull(
        [NotNull] string? argument,
        [CallerArgumentExpression("argument")] string? name = null)
    {
        if (argument is null)
        {
            throw new ArgumentNullException(name);
        }

        return argument;
    }
}
#endif