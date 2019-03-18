using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public class GadgetLargeFactory : AbstractGadgetFactory
    {
        public override IWidgetSmall CreateWidgetSmall()
        {
            return new GadgetLargeWidgetSmall();
        }

        public override IWidgetMedium CreateWidgetMedium()
        {
            return new GadgetLargeWidgetMedium();
        }

        public override IWidgetLarge CreateWidgetLarge()
        {
            return new GadgetLargeWidgetLarge();
        }

    }
}
