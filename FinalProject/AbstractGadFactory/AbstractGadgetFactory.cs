using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGadFactory
{
    public abstract class AbstractGadgetFactory
    {
        public abstract IWidgetSmall CreateWidgetSmall();

        public abstract IWidgetMedium CreateWidgetMedium();

        public abstract IWidgetLarge CreateWidgetLarge();
    }
}
