using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWidFactory
{
    public class WidgetSmallLever : IWidgetLever
    {
        public string WidgetLeverParts
        {
            get { return "lever parts for widget small gear"; }
        }
    }
}
