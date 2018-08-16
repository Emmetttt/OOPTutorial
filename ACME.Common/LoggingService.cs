using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public class LoggingService
    {
        public static void WriteToFile(List<ILoggable> changedItems)
        {
            //List of ILoggable items.
            foreach(var item in changedItems)
            {
                Console.WriteLine(item.Log());
                //Log is polymorphic.
            }
        }
    }
}
