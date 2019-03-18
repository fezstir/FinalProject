using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public class GadgetSmallWidgetSmall : IWidgetSmall
    {
        public string WidgetSmallParts
        {
            get { return "widget small parts for gadget small"; }
        }
    }
}
