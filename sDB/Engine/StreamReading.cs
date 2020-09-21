using Newtonsoft.Json;
using sDB.Struct;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.Err
{
    class StreamReading
    {
        public void ReadST(string str, LCustomer addCustomer, string docName, int cnt)
        {
            System.IO.StreamReader re = new StreamReader(str);
            JsonTextReader reader = new JsonTextReader(re);
            while (reader.Read())
            {
                var dep = reader.Depth;
                var v = reader.Value;
                var vt = reader.ValueType;
                var to = reader.TokenType;
                var path = reader.Path;
                addCustomer.ACustomer(dep, v, vt, to, path);
            }
            addCustomer.OCustomer(docName, cnt);
        }
    }
}
