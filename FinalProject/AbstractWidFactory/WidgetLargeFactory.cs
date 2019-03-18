using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWidFactory
{
    public class WidgetLargeFactory : AbstractWidgetFactory
    {
        public override IWidgetGear CreateWidgetGear()
        {
            return new WidgetLargeGear();
        }

        public override IWidgetLever CreateWidgetLever()
        {
            return new WidgetLargeLever();
        }

        public override IWidgetSpring CreateWidgetSpring()
        {
            return new WidgetLargeSpring();
        }
    }
}
