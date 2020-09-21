using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using sDB.Err;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.Struct
{
    class Ini_st
    {
        public void GatData(string str, string docName, int cnt)
        {
            var DStr = new DebugString();
            DStr.DStr(str, docName, cnt);
        }
    }
}


