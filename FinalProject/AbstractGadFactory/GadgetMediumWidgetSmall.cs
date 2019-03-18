using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public class GadgetMediumWidgetSmall : IWidgetSmall
    {
        public string WidgetSmallParts
        {
            get { return "widget small parts for gadget medium"; }
        }
    }
}
