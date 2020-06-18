using BlazorApp1.AppStates;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Components
{
    public class SortComponentBase: ComponentBase
    {
        [CascadingParameter] protected AppState AppState { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        public bool IsSortedAscending { get; set; }

        protected override void OnInitialized()
        {
            AppState.AddStateMember(this);
        }

        protected void HandleOnClick()
        {
            AppState.ChangeStateOfMember(this);
        }
    }
}
