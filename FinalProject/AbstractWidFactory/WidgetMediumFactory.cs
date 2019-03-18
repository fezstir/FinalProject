using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWidFactory
{
    public class WidgetMediumFactory : AbstractWidgetFactory
    {
        public override IWidgetGear CreateWidgetGear()
        {
            return new WidgetMediumGear();
        }

        public override IWidgetLever CreateWidgetLever()
        {
            return new WidgetMediumLever();
        }

        public override IWidgetSpring CreateWidgetSpring()
        {
            return new WidgetMediumSpring();
        }
    }
}
