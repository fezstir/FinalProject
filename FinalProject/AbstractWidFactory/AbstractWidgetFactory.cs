using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWidFactory
{
    public abstract class AbstractWidgetFactory
    {
        public abstract IWidgetGear CreateWidgetGear();

        public abstract IWidgetLever CreateWidgetLever();

        public abstract IWidgetSpring CreateWidgetSpring();
    }
}
