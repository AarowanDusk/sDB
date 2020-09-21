using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.log
{
    class SDBLog
    {
        public void Log(string strLg, string codeLog)
        {
            var filePath = @"..\..\log\log\" + codeLog + "_log.txt";
            StringBuilder sb = new StringBuilder();
            sb.Append(strLg);
            File.AppendAllText(filePath, sb.ToString());
            sb.Clear();
        }
    }
}
