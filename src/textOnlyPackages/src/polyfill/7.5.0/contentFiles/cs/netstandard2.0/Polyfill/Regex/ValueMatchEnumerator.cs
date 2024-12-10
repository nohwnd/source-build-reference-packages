// <auto-generated />
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#pragma warning disable

#if !NET7_0_OR_GREATER && FeatureMemory

namespace System.Text.RegularExpressions;

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

//https://github.com/dotnet/runtime/blob/main/src/libraries/System.Text.RegularExpressions/src/System/Text/RegularExpressions/Regex.EnumerateMatches.cs
/// <summary>
/// Represents an enumerator containing the set of successful matches found by iteratively applying a regular expression pattern to the input span.
/// </summary>
/// <remarks>
/// The enumerator has no public constructor. The <see cref="Regex.EnumerateMatches(ReadOnlySpan{char})"/> method returns a <see cref="Regex.ValueMatchEnumerator"/>
/// object.The enumerator will lazily iterate over zero or more <see cref="ValueMatch"/> objects. If there is at least one successful match in the span, then
/// <see cref="MoveNext"/> returns <see langword="true"/> and <see cref="Current"/> will contain the first <see cref="ValueMatch"/>. If there are no successful matches,
/// then <see cref="MoveNext"/> returns <see langword="false"/> and <see cref="Current"/> throws an <see cref="InvalidOperationException"/>.
///
/// This type is a ref struct since it stores the input span as a field in order to be able to lazily iterate over it.
/// </remarks>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
#if PolyPublic
public
#endif
ref struct ValueMatchEnumerator
{
    ReadOnlySpan<char> _input;
    ValueMatch _current;
    MatchCollection matchCollection;
    int index = 0;

    /// <summary>
    /// Creates an instance of the <see cref="ValueMatchEnumerator"/> for the passed in <paramref name="regex"/> which iterates over <paramref name="input"/>.
    /// </summary>
    /// <param name="regex">The <see cref="Regex"/> to use for finding matches.</param>
    /// <param name="input">The input span to iterate over.</param>
    /// <param name="startAt">The position where the engine should start looking for matches from.</param>
    internal ValueMatchEnumerator(Regex regex, ReadOnlySpan<char> input, int startAt)
    {
        matchCollection = regex.Matches(input.ToString(), startAt);
        _input = input;
        _current = default;
    }

    /// <summary>
    /// Provides an enumerator that iterates through the matches in the input span.
    /// </summary>
    /// <returns>A copy of this enumerator.</returns>
    public readonly ValueMatchEnumerator GetEnumerator() => this;

    /// <summary>
    /// Advances the enumerator to the next match in the span.
    /// </summary>
    /// <returns>
    /// <see langword="true"/> if the enumerator was successfully advanced to the next element; <see langword="false"/> if the enumerator cannot find additional matches.
    /// </returns>
    public bool MoveNext()
    {
        if (index == matchCollection.Count)
        {
            return false;
        }

        var match = matchCollection[index];
        _current = new ValueMatch(match.Index, match.Length);
        index++;
        return true;
    }

    /// <summary>
    /// Gets the <see cref="ValueMatch"/> element at the current position of the enumerator.
    /// </summary>
    /// <exception cref="InvalidOperationException">Enumeration has either not started or has already finished.</exception>
    public readonly ValueMatch Current => _current;
}

#endif