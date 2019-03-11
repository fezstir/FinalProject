using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SerialNumberGeneratorWidgetMedium
    {
        private static volatile SerialNumberGeneratorWidgetMedium instance;

        private static object synchronizationRoot = new object();

        private string _prefix = "44MED";
        private int _count = 2457;

        public static SerialNumberGeneratorWidgetMedium Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (synchronizationRoot)
                    {
                        if (instance == null)
                        {
                            instance = new SerialNumberGeneratorWidgetMedium();
                        }
                    }
                }
                return instance;
            }
        }

        private SerialNumberGeneratorWidgetMedium() { }

        public string NextSerial
        {
            get { return _prefix + ++_count; }
        }
    }
}
