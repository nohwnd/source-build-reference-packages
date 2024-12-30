﻿// <auto-generated />
#pragma warning disable

#if !NET6_0_OR_GREATER

namespace System.Runtime.Versioning;

using Diagnostics;
using Diagnostics.CodeAnalysis;

using Targets = AttributeTargets;

/// <summary>
/// Annotates a custom guard field, property or method with a supported platform name and optional version.
/// Multiple attributes can be applied to indicate guard for multiple supported platforms.
/// </summary>
/// <remarks>
/// Callers can apply a <see cref="SupportedOSPlatformGuardAttribute " /> to a field, property or method
/// and use that field, property or method in a conditional or assert statements in order to safely call platform specific APIs.
///
/// The type of the field or property should be boolean, the method return type should be boolean in order to be used as platform guard.
/// </remarks>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
[AttributeUsage(
    validOn: Targets.Field |
             Targets.Method |
             Targets.Property,
    AllowMultiple = true,
    Inherited = false)]
#if PolyPublic
public
#endif
sealed class SupportedOSPlatformGuardAttribute(string platformName) :
    OSPlatformAttribute(platformName)
{
}

#endif