namespace ImGuiNET
{
    [System.Flags]
    public enum ImGuiSelectableFlagsPrivate
    {
        ImGuiSelectableFlags_NoHoldingActiveID = 1 << 20,
        ImGuiSelectableFlags_PressedOnClick = 1 << 21,
        ImGuiSelectableFlags_PressedOnRelease = 1 << 22,
        ImGuiSelectableFlags_DrawFillAvailWidth = 1 << 23,
        ImGuiSelectableFlags_DrawHoveredWhenHeld = 1 << 24,
        ImGuiSelectableFlags_SetNavIdOnHover = 1 << 25,
    }
}
