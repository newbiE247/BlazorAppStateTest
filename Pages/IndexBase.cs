using BlazorApp1.AppStates;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public class IndexBase: ComponentBase
    {
        protected AppState AppState { get; set; } = new AppState();
    }
}
