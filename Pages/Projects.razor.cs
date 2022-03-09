using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace aboutme.Pages
{
    public partial class Projects
    {
        [Inject]
        private IJSRuntime JSRuntime
        {
            get; set;
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JSRuntime.InvokeVoidAsync("twttr.widgets.load");
            }
        }
    }
}
