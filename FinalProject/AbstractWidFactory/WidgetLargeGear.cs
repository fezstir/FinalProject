﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWidFactory
{
    public class WidgetLargeGear : IWidgetGear
    {
        public string WidgetGearParts
        {
            get { return "gear parts for widget large gear"; }
        }
    }
}
