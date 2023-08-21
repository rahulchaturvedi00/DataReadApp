using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReadApp.Utilities.YamlOperations
{
    public interface IYamlParser
    {
        void ParseYamlValues(string path);
    }
}
