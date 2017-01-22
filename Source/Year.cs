using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Leap
{
    public class Year
    {
        public static bool IsLeap(int year)
        {
            if (!DateTime.IsLeapYear(year))
                return false;
            return true;
        }
    }
}
