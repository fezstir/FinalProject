using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Base
{
    class GadgetMedium : AbstractGadget
    {

        public override decimal Price { get; } = 850.00m;

        public GadgetMedium(Iwidget widget)
        : this(GadgetColor.Green, widget) { }

        public GadgetMedium(GadgetColor color, IWidget widget)
        : base(color, widget) { }

    }
}
