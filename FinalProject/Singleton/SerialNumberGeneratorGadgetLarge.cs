using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGeneratorGadgetLarge
    {
        private static volatile SerialNumberGeneratorGadgetLarge instance;

        private static object synchronizationRoot = new object();

        private string _prefix = "06LRG";
        private int _count = 3467;

        public static SerialNumberGeneratorGadgetLarge Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGeneratorGadgetLarge();
                        }
                    }
                }
                return instance;
            }
        }

        private SerialNumberGeneratorGadgetLarge() { }

        public string NextSerial
        {
            get { return _prefix + ++_count; }
        }
    }
}
