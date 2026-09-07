namespace Verso.Abstractions;

/// <summary>
/// Defines the elevation (drop shadow) scale for a Verso notebook theme.
/// Each value is a complete CSS <c>box-shadow</c> expression, or <c>none</c>.
/// </summary>
/// <remarks>
/// Elevation is how one surface separates from the one beneath it. Themes that
/// separate surfaces by lightness alone (most dark themes) can lean on small
/// shadows. Themes whose surfaces compress near white (most light themes) cannot
/// step above the page in lightness at all, so the defaults below carry that step
/// themselves: levels 1 and 2 begin with a one pixel spread ring, a hairline that
/// gives a white surface an edge on a white page from the same <c>box-shadow</c>
/// rule that gives it depth, with no border rule for a dark theme to cancel.
/// Level 3 has no ring because floating surfaces carry a real border in every
/// theme. High-contrast themes should set every level to <c>none</c> and separate
/// with borders instead.
///
/// The emitted custom properties drop the <c>Level</c> prefix, so a stylesheet
/// reads <c>var(--verso-elevation-1)</c> rather than <c>--verso-elevation-level1</c>.
/// </remarks>
public sealed record ThemeElevation
{
    /// <summary>No elevation. A surface flush with its parent.</summary>
    public string Level0 { get; init; } = "none";

    /// <summary>Resting cards: notebook cells, panels, and other content surfaces.</summary>
    public string Level1 { get; init; } = "0 0 0 1px rgba(16, 18, 32, 0.07), 0 1px 2px rgba(16, 18, 32, 0.05)";

    /// <summary>Raised cards: hover and active states of anything at level 1.</summary>
    public string Level2 { get; init; } = "0 0 0 1px rgba(16, 18, 32, 0.08), 0 4px 12px rgba(16, 18, 32, 0.10)";

    /// <summary>Floating surfaces that overlay the page: dialogs, dropdowns, popovers.</summary>
    public string Level3 { get; init; } = "0 12px 32px rgba(16, 18, 32, 0.16), 0 2px 6px rgba(16, 18, 32, 0.08)";
}
