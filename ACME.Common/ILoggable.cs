using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.Common
{
    public interface ILoggable
    {
        string Log(); //Automatically public in interface
                      //Interfaces only define list of members, not implementation
    }
}
