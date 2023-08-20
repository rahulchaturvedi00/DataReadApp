using DataReadApp.SoftwareDevice;
using DataReadApp.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace DataReadApp
{
    public class ClientService : IClientService
    {
        public void DataRetriever(string sourceName, string path)
        {
            Enum.TryParse(typeof(Source),sourceName,out var result);

            switch (result)
            {
                case Source.Capterra:
                    YamlParser.ParseYamlValues(path);

                    break;

                case Source.Softwaredvice:
                    JsonParser.ParseJsonValues(path);
                    

                    break;
            
            }
            
        }
    }
}
