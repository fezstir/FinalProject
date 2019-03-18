using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public class GadgetMediumWidgetLarge : IWidgetLarge
    {
        public string WidgetLargeParts
        {
            get { return "widget large parts for gadget medium"; }
        }
    }
}
