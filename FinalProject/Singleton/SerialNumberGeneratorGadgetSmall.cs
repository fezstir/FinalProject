using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGeneratorGadgetSmall
    {
        private static volatile SerialNumberGeneratorGadgetSmall instance;

        private static object synchronizationRoot = new object();

        private string _prefix = "02SML";
        private int _count = 1245;

        public static SerialNumberGeneratorGadgetSmall Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGeneratorGadgetSmall();
                        }
                    }
                }
                return instance;
            }
        }

        private SerialNumberGeneratorGadgetSmall() { }

        public string NextSerial
        {
            get { return _prefix + ++_count; }
        }
    }
}
