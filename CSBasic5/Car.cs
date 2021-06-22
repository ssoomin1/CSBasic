using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSBasic5
{
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetIntime()
        {
            this.inTime = DateTime.Now;
        }

        public void SetoutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}
