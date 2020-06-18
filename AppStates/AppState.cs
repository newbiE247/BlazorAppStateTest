using BlazorApp1.Components;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp1.AppStates
{
    public class AppState
    {
        protected List<SortComponentBase> StateMembers { get; set; } = new List<SortComponentBase>();

        public void AddStateMember(SortComponentBase member)
        {
            StateMembers.Add(member);
        }

        public void ChangeStateOfMember(SortComponentBase member)
        {
            var m = StateMembers.Where(m => m == member).First();
            m.IsSortedAscending = !m.IsSortedAscending;
        }
    }
}
