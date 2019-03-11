using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGeneratorWidgetSmall
    {
        private static volatile SerialNumberGeneratorWidgetSmall instance;

        private static object synchronizationRoot = new object();

        private string _prefix = "22SML";
        private int _count = 1346;

        public static SerialNumberGeneratorWidgetSmall Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGeneratorWidgetSmall();
                        }
                    }
                }
                return instance;
            }
        }

        private SerialNumberGeneratorWidgetSmall() { }

        public string NextSerial
        {
            get { return _prefix + ++_count; }
        }
    }
}
