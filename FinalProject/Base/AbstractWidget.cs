using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Base
{
    class AbstractWidget
    {
    }
    public Abstract class AbstractWidget : IWidget
    { }
    private WidgetColor _color;
    private IWidget _widget;
    public WidgetColor ColorType
    {
        get { return _color; }
    }
    public IWidget GetWidget { get { return _widget; } }



    public AbstractGadget(GadgetColor color, IWidget widget)
    {
        this._wheel = wheel;
        this._color = color;
    }

    public virtual void Paint(WidgetColor color)
    { this._color = color; }

    public override string ToString()
    {
        return this.GetType().Name + " Widget Color is" + _color
            + " and costs $" + Price;
    }

    public virtual void CleanWidget()
    {
        Console.WriteLine("Cleaning Widget...");
    }

    public virtual void WrapWidget()
    {
        Console.WriteLine("Installing Widget");
    }

    public virtual void TestWidget()
    {
        Console.WriteLine("Inspecting Widget...");
    }
}
}

}
}
