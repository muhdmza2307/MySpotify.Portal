using MudBlazor;

namespace MySpotify.Portal.Web.Themes
{
    public static class CustomTheme
    {
        public static MudTheme SpotifyTheme()
        {
            return new MudTheme()
            {
                PaletteLight = new PaletteLight()
                {
                    Primary = "#1DB954",
                    Secondary = "#191414",
                    Background = "#121212",
                    Surface = "#212121",
                    AppbarBackground = "#191414",
                    DrawerBackground = "#191414",
                    DrawerText = "#FFFFFF",
                    DrawerIcon = "#1DB954",
                    TextPrimary = "#FFFFFF",
                    TextSecondary = "#B3B3B3",
                    ActionDefault = "#1DB954",
                    ActionDisabled = "#555",
                    ActionDisabledBackground = "#333",
                    Divider = "#282828",
                    TableLines = "#282828",
                    LinesDefault = "#282828",
                    OverlayDark = "rgba(0, 0, 0, 0.7)"
                }
            };
        }
    }
}
