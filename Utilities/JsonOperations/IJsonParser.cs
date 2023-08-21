using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReadApp.Utilities.JsonOperations
{
    public interface IJsonParser
    {
        void ParseJsonValues(string path);
    }
}
