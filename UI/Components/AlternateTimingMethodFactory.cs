﻿using LiveSplit.Model;
using System;
using System.Reflection;

namespace LiveSplit.UI.Components
{
    public class AlternateTimingMethodFactory : IComponentFactory
    {
        public string ComponentName
        {
            get { return "Alternate Timing Method"; }
        }

        public string Description
        {
            get { return "Displays Real Time if the comparison is set to Game Time and vice versa."; }
        }

        public ComponentCategory Category
        {
            get { return ComponentCategory.Information; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new AlternateTimingMethod(state);
        }

        public string UpdateName
        {
            get { return ComponentName; }
        }

        public string UpdateURL
        {
            get { return "https://raw.githubusercontent.com/dalet/LiveSplit.AlternateTimingMethod/master/"; }
        }

        public string XMLURL
        {
            get { return this.UpdateURL + "Components/update.LiveSplit.AlternateTimingMethod.xml"; }
        }

        public Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }
    }
}
