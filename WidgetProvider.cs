﻿using MMDUI.Widgets;
using MMEdit;
using System;
using System.Reflection;

namespace MMDUI
{
    public class WidgetProvider : PluginClass, IWidgetProvider
    {
        #region Properties
        public override Guid Guid
        {
            get
            {
                return new Guid("{C33EF5FA-6B4D-4518-B367-19F46A2A2ACD}");
            }
        }

        public override string Name
        {
            get
            {
                return "MMDUI Widget Provider";
            }
        }

        public override string Version
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public override string Description
        {
            get
            {
                return "提供基本的 MMDUI 小部件。\r\n小部件：Color / Numeric / Slider / Spinner / *MMDUI.Widgets.WidgetProxy";
            }
        }

        #endregion

        #region Methods
        public IWidget[] GetWidgets()
        {
            return new IWidget[]
            {
                new WidgetClass("MMDUI.Widgets.WidgetProxy", obj => new WidgetProxy(obj, Host)),
                new WidgetClass("Color", obj => new SliderWidget(true) { ObjectFX = obj }),
                new WidgetClass("Slider", obj => new SliderWidget { ObjectFX = obj }),
                new WidgetClass("Numeric", obj => new NumericWidget { ObjectFX = obj }),
                new WidgetClass("Spinner", obj => new NumericWidget { ObjectFX = obj }),
            };
        }
        #endregion
    }
}