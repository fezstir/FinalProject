﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Base
{
    public class GadgetLarger : AbstractGadget
    {

        public override decimal Price { get; } = 850.00m;

        public GadgetLarger(IWidget widget)
        : this(GadgetColor.Green, widget) { }

        public GadgetLarger(GadgetColor color, IWidget widget)
        : base(color, widget) { }

    }
}
