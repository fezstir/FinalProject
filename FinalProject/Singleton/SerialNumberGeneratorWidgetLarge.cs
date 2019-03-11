using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGeneratorWidgetLarge
    {
        private static volatile SerialNumberGeneratorWidgetLarge instance;

        private static object synchronizationRoot = new object();

        private string _prefix = "66LRG";
        private int _count = 3568;

        public static SerialNumberGeneratorWidgetLarge Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGeneratorWidgetLarge();
                        }
                    }
                }
                return instance;
            }
        }

        private SerialNumberGeneratorWidgetLarge() { }

        public string NextSerial
        {
            get { return _prefix + ++_count; }
        }
    }
}
