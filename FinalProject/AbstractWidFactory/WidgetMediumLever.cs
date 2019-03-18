using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWidFactory
{
    public class WidgetMediumLever : IWidgetLever
    {
        public string WidgetLeverParts
        {
            get { return "lever parts for widget medium gear"; }
        }
    }
}
