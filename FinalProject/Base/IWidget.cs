using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public interface IWidget
    {
        WidgetColor Colortype { get; }
        int Springs { get; }
        int Levers { get; }
        int Gears { get; }
        int Quantity { get; set; }

    }
}
