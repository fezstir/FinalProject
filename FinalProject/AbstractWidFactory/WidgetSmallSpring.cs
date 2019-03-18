using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractWidFactory
{
    public class WidgetSmallSpring : IWidgetSpring
    {
        public string WidgetSpringParts
        {
            get { return "spring parts for widget small gear"; }
        }
    }
}
