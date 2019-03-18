using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Singleton;
using AbstractWidFactory;
using AbstractGadFactory;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //SingletonPatternDemo();

            //AbstractWidFactoryDemo();

            AbstractGadFactoryDemo();
        }

        private static void AbstractGadFactoryDemo()
        {
            Console.WriteLine("create gadget small");
            AbstractGadgetFactory factory = new GadgetSmallFactory();
            IWidgetSmall widgetSmall = factory.CreateWidgetSmall();
            Console.WriteLine(widgetSmall.WidgetSmallParts);
            IWidgetMedium widgetMedium = factory.CreateWidgetMedium();
            Console.WriteLine(widgetMedium.WidgetMediumParts);
            Console.WriteLine("");


            Console.WriteLine("create gadget medium");
            AbstractGadgetFactory factoryMed = new GadgetMediumFactory();
            IWidgetSmall widgetSmallMed = factoryMed.CreateWidgetSmall();
            Console.WriteLine(widgetSmallMed.WidgetSmallParts);
            IWidgetMedium widgetMediumMed = factoryMed.CreateWidgetMedium();
            Console.WriteLine(widgetMediumMed.WidgetMediumParts);
            IWidgetLarge widgetLargeMed = factoryMed.CreateWidgetLarge();
            Console.WriteLine(widgetLargeMed.WidgetLargeParts);
            Console.WriteLine("");


            Console.WriteLine("create gadget large");
            AbstractGadgetFactory factoryLrg = new GadgetLargeFactory();
            IWidgetSmall widgetSmallLrg = factoryLrg.CreateWidgetSmall();
            Console.WriteLine(widgetSmallLrg.WidgetSmallParts);
            IWidgetMedium widgetMediumLrg = factoryLrg.CreateWidgetMedium();
            Console.WriteLine(widgetMediumLrg.WidgetMediumParts);
            IWidgetLarge widgetLargeLrg = factoryLrg.CreateWidgetLarge();
            Console.WriteLine(widgetLargeLrg.WidgetLargeParts);
            Console.WriteLine("");
        }

        private static void AbstractWidFactoryDemo()
        {
            Console.WriteLine("create widget small");
            AbstractWidgetFactory factory = new WidgetSmallFactory();
            IWidgetGear widgetGear = factory.CreateWidgetGear();
            Console.WriteLine(widgetGear.WidgetGearParts);
            IWidgetLever widgetLever = factory.CreateWidgetLever();
            Console.WriteLine(widgetLever.WidgetLeverParts);
            IWidgetSpring widgetSpring = factory.CreateWidgetSpring();
            Console.WriteLine(widgetSpring.WidgetSpringParts);
            Console.WriteLine("");

            Console.WriteLine("create widget medium");
            AbstractWidgetFactory factoryMedium = new WidgetMediumFactory();
            IWidgetGear widgetMediumGear = factoryMedium.CreateWidgetGear();
            Console.WriteLine(widgetMediumGear.WidgetGearParts);
            IWidgetLever widgetMediumLever = factoryMedium.CreateWidgetLever();
            Console.WriteLine(widgetMediumLever.WidgetLeverParts);
            IWidgetSpring widgetMediumSpring = factoryMedium.CreateWidgetSpring();
            Console.WriteLine(widgetMediumSpring.WidgetSpringParts);
            Console.WriteLine("");

            Console.WriteLine("create widget Large");
            AbstractWidgetFactory factoryLarge = new WidgetLargeFactory();
            IWidgetGear widgetLargeGear = factoryLarge.CreateWidgetGear();
            Console.WriteLine(widgetLargeGear.WidgetGearParts);
            IWidgetLever widgetLargeLever = factoryLarge.CreateWidgetLever();
            Console.WriteLine(widgetLargeLever.WidgetLeverParts);
            IWidgetSpring widgetLargeSpring = factoryLarge.CreateWidgetSpring();
            Console.WriteLine(widgetLargeSpring.WidgetSpringParts);
            Console.WriteLine("");
        }

        private static void SingletonPatternDemo()
        {
            SerialNumberGeneratorGadgetSmall generatorGadgetSmall = SerialNumberGeneratorGadgetSmall.Instance;
            Console.WriteLine("gadget small next serial number: " + generatorGadgetSmall.NextSerial);

            SerialNumberGeneratorGadgetMedium generatorGadgetMedium = SerialNumberGeneratorGadgetMedium.Instance;
            Console.WriteLine("gadget medium next serial number: " + generatorGadgetMedium.NextSerial);

            SerialNumberGeneratorGadgetLarge generatorGadgetLarge = SerialNumberGeneratorGadgetLarge.Instance;
            Console.WriteLine("gadget large next serial number: " + generatorGadgetLarge.NextSerial);

            SerialNumberGeneratorWidgetSmall generatorWidgetSmall = SerialNumberGeneratorWidgetSmall.Instance;
            Console.WriteLine("widget small next serial number: " + generatorWidgetSmall.NextSerial);

            SerialNumberGeneratorWidgetMedium generatorWidgetMedium = SerialNumberGeneratorWidgetMedium.Instance;
            Console.WriteLine("widget medium next serial number: " + generatorWidgetMedium.NextSerial);

            SerialNumberGeneratorWidgetLarge generatorWidgetLarge = SerialNumberGeneratorWidgetLarge.Instance;
            Console.WriteLine("widget large next serial number: " + generatorWidgetLarge.NextSerial);
        }
    }
}
