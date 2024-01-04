using Microsoft.AspNetCore.Components;
using PowerBearWebsite_Assembly.Models;

namespace PowerBearWebsite_Assembly.Helper {
    public class NavHelper {
        private List<NavModel> _navList;
        private NavigationManager _navigationManager;
        public NavHelper(List<NavModel> navList, NavigationManager navigationManager) {
            _navigationManager = navigationManager;
            _navList = navList;
        }
    }
}
