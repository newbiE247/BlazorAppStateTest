using BlazorApp1.AppStates;
using Microsoft.AspNetCore.Components;
using System;

namespace BlazorApp1.Components
{
    public class SortComponentBase: ComponentBase
    {
        [CascadingParameter] protected AppState AppState { get; set; }
        [Parameter] public RenderFragment ChildContent { get; set; }
        public bool IsSortedAscending { get; set; }

        protected override void OnInitialized()
        {
            if (AppState == null)
                throw new ArgumentNullException("AppState was not initialized.");

            AppState.AddStateMember(this);
        }

        protected void HandleOnClick()
        {
            AppState.ChangeStateOfMember(this);
            AppState.SetActiveMember(this);
            AppState.OnStateChange += StateHasChanged;
        }

        protected string GetButtonClass()
        {
            if(AppState.ActiveMember == this)
                return "btn btn-primary";
            
            return "btn btn-secondary";
        }
    }
}
