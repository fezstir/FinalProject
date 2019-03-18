using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public class GadgetSmallFactory : AbstractGadgetFactory
    {
        public override IWidgetSmall CreateWidgetSmall()
        {
            return new GadgetSmallWidgetSmall();
        }

        public override IWidgetMedium CreateWidgetMedium()
        {
            return new GadgetSmallWidgetMedium();
        }

        public override IWidgetLarge CreateWidgetLarge()
        {
            return new GadgetSmallWidgetLarge();
        }

    }
}
