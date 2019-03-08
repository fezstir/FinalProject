using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Base
{
    public Abstract class AbstractGadget : IGadget
    { }
    private GadgetColor _color;
    private IWidget _widget;
    public WidgetColor ColorType
    {
        get { return _color; }
    }
    public IWidget GetWidget { get { return _widget; } }

    public abstract decimal Price { get; }

    public AbstractGadget(GadgetColor color, IWidget widget)
    {
        this._wheel = wheel;
        this._color = color;
    }

    public virtual void Paint(GadgetColor color)
    { this._color = color; }

    public override string ToString()
    {
        return this.GetType().Name + " Gadget Color is" + _color
            + " and costs $" + Price;
    }

    public virtual void CleanGadget()
    {
        Console.WriteLine("Cleaning Gadget...");
    }

    public virtual void Wrap Gadget()
    {
        Console.WriteLine("Wrapping Gadget");
    }

    public virtual void TestGadget()
    {
        Console.WriteLine("Testing Gadget...");
    }
}
}

}
