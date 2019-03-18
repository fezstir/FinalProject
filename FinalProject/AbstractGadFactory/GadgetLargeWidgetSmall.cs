using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public class GadgetLargeWidgetSmall : IWidgetSmall
    {
        public string WidgetSmallParts
        {
            get { return "widget small parts for gadget large"; }
        }
    }
}
