﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWidFactory
{
    public class WidgetMediumSpring : IWidgetSpring
    {
        public string WidgetSpringParts
        {
            get { return "spring parts for widget medium gear"; }
        }
    }
}
