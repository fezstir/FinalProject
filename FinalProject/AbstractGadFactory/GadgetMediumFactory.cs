using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public class GadgetMediumFactory : AbstractGadgetFactory
    {
        public override IWidgetSmall CreateWidgetSmall()
        {
            return new GadgetMediumWidgetSmall();
        }

        public override IWidgetMedium CreateWidgetMedium()
        {
            return new GadgetMediumWidgetMedium();
        }

        public override IWidgetLarge CreateWidgetLarge()
        {
            return new GadgetMediumWidgetLarge();
        }

    }
}
