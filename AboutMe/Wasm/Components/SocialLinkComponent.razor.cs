namespace AboutMe.Wasm.Components;

public partial class SocialLinkComponent
{
    private static RenderFragment SocialLinkFragment(SocialLink socialLink, bool compactMode = false,
        string? nameOverride = null, string? titleOverride = null) => compactMode
        ? SocialLinkFragmentCompact(socialLink, nameOverride, titleOverride)
        : SocialLinkFragmentExpanded(socialLink, nameOverride, titleOverride);
}
