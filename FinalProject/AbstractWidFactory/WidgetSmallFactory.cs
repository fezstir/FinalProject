using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWidFactory
{
    public class WidgetSmallFactory : AbstractWidgetFactory
    {
        public override IWidgetGear CreateWidgetGear()
        {
            return new WidgetSmallGear();
        }

        public override IWidgetLever CreateWidgetLever()
        {
            return new WidgetSmallLever();
        }

        public override IWidgetSpring CreateWidgetSpring()
        {
            return new WidgetSmallSpring();
        }
    }
}
