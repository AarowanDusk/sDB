using sDB.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sDB.CmdStruct
{
    class CRUD
    {
        public void CrReUpDe(string docName)
        {
            var CStart = new ConsoleStart();
            CStart.ConsoleSt(docName);
        }
    }
}
