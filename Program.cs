using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
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
