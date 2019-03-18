using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public class GadgetSmallWidgetMedium : IWidgetMedium
    {
        public string WidgetMediumParts
        {
            get { return "widget medium parts for gadget small"; }
        }
    }
}
