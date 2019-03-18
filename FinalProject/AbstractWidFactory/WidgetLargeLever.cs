using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWidFactory
{
    public class WidgetLargeLever : IWidgetLever
    {
        public string WidgetLeverParts
        {
            get { return "lever parts for widget large gear"; }
        }
    }
}
