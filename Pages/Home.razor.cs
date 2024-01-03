using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using System.Threading.Tasks;
using System.Linq;
using System.Collections;

namespace PowerBearWebsite_Assembly.Pages {
    public partial class Home : ComponentBase {

        public int Id { get; set; }

        protected override async Task OnInitializedAsync() {
            Console.WriteLine("hello world");
            forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }

        public void IncreaseNumber(string number) {
            if (number == null) { }
        }
    }
}
