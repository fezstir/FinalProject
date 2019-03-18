using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public class GadgetLargeWidgetLarge : IWidgetLarge
    {
        public string WidgetLargeParts
        {
            get { return "widget large parts for gadget large"; }
        }
    }
}
