using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public class GadgetLargeWidgetMedium : IWidgetMedium
    {
        public string WidgetMediumParts
        {
            get { return "widget medium parts for gadget large"; }
        }
    }
}
