using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGeneratorGadgetMedium
    {
        private static volatile SerialNumberGeneratorGadgetMedium instance;

        private static object synchronizationRoot = new object();

        private string _prefix = "04MED";
        private int _count = 2356;

        public static SerialNumberGeneratorGadgetMedium Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGeneratorGadgetMedium();
                        }
                    }
                }
                return instance;
            }
        }

        private SerialNumberGeneratorGadgetMedium() { }

        public string NextSerial
        {
            get { return _prefix + ++_count; }
        }
    }
}
