using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.Struct
{
    class TimeStamp
    {
        private string Timestamp;
        public String TStamp()
        {
            Timestamp = string.Format("{0:yyyy-MM-dd hh:mm:ss:fff tt}", DateTime.Now);
            return Timestamp;
        }
    }
}
