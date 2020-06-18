using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components
{
    public class SortWithoutAppStateBase: ComponentBase
    {
        [Parameter] public RenderFragment ChildContent { get; set; }
        protected bool IsSortedAscending { get; set; }
        protected void HandleOnClick()
        {
            IsSortedAscending = !IsSortedAscending;
            StateHasChanged();
        }
    }
}
