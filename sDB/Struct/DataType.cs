using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.Struct
{
    class DataType
    {
        public int LDepth { get; set; }
        public object LValue { get; set; }
        public Type LValueType { get; set; }
        public JsonToken LTokenType { get; set; }
        public string LPath { get; set; }
    }
    class DataTypeXML
    {
        public int LDepth { get; set; }
        public string LValue { get; set; }
        public string LValueType { get; set; }
        public string LTokenType { get; set; }
        public string LPath { get; set; }
        public int LPosition { get; set; }
    }
}
