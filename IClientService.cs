using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReadApp
{
    public interface IClientService
    {
        public void DataRetriever(string sourceName, string path);
    }
}
