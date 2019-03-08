using FinalProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public class WidgetSmall : AbstractWidget
    {
        private int _gears = 2, _springs = 3, _levers = 1, _quantity;
        private WidgetColor _widgetColor;

        public override int Quantity
        {
            set
            {
                this._quantity = Quantity;
            }
            get
            {
                return _quantity;
            }
        }
    }
}