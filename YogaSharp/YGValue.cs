using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace YogaSharp;

[StructLayout(LayoutKind.Sequential)]
public struct YGValue
{
    public float Value;
    public YGUnit Unit;

    public static YGValue Zero
        => new() { Value = 0, Unit = YGUnit.Point };

    public static YGValue Undefined
        => new() { Value = float.NaN, Unit = YGUnit.Undefined };

    public static YGValue Auto
        => new() { Value = float.NaN, Unit = YGUnit.Auto };

    public static YGValue Percent(float value)
    {
        if (float.IsNaN(value) || float.IsInfinity(value))
            return Undefined;

        return new() { Value = value, Unit = YGUnit.Percent };
    }

    public static YGValue Point(float value)
    {
        if (float.IsNaN(value) || float.IsInfinity(value))
            return Undefined;

        return new() { Value = value, Unit = YGUnit.Point };
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]

    public static implicit operator YGValue(float value) => Point(value);

    public bool IsAuto
        => Unit is YGUnit.Auto;

    public bool IsUndefined
        => Unit is YGUnit.Undefined;

    public bool IsDefined
        => !IsUndefined;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool IsApproximately(YGValue other)
    {
        return Unit == other.Unit && Value.IsApproximately(other.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator ==(YGValue? a, YGValue? b)
    {
        if (a is null && b is null)
            return true;

        if (a is null || b is null)
            return false;

        return a.Equals(b);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool operator !=(YGValue? a, YGValue? b)
    {
        return !(a == b);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override bool Equals([NotNullWhen(true)] object? obj)
    {
        return obj is YGValue other && Unit == other.Unit && (Unit is YGUnit.Undefined or YGUnit.Auto || Value == other.Value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override int GetHashCode()
    {
        return HashCode.Combine(Value, Unit);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public override string ToString()
    {
        return Unit switch
        {
            YGUnit.Auto => "Auto",
            YGUnit.Point => $"{Value.ToString("0", CultureInfo.InvariantCulture)}px",
            YGUnit.Percent => $"{Value.ToString("0", CultureInfo.InvariantCulture)}%",
            _ => "Undefined"
        };
    }
}
