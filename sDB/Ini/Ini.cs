using Newtonsoft.Json;
using sDB.Struct;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.Ini
{
    public class Init
    {
        public string Str { get; set; }
        public void StrData(string docName, int cnt)
        {
            var data = new Ini_st();
            data.GatData(Str, docName, cnt);
        }
    }
}
