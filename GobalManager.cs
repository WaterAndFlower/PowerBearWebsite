using BlazorComponent;

namespace PowerBearWebsite_Assembly {
    public class PageRoute {
        public string PageTitle { get; set; } = "";
        public string PageHref { get; set; } = "/";
        public string IconName { get; set; } = "";
        public bool ToolBarAbsoulte { get; set; } = false;
    }

    public static class GobalManager {
        public static PageRoute[] GobalPageRoute { get; set; } = new PageRoute[] {
            new() { PageTitle = "HOME", PageHref = "/", IconName = "mdi-home",ToolBarAbsoulte=true },
            new() { PageTitle = "RESEARCH", PageHref = "/passage", IconName = "mdi-heart" },
            new(){ PageTitle="TOOLS", PageHref = "/tools", IconName = "mdi-tools"},
            new() { PageTitle = "ABOUT", PageHref = "/about", IconName = "mdi-information" } };
        public static StringNumber PageValue = 0;
    }
}
