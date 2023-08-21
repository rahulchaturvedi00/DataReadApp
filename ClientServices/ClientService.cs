using DataReadApp.Utilities.JsonOperations;
using DataReadApp.Utilities.YamlOperations;

namespace DataReadApp.ClientServices
{
    public class ClientService : IClientService
    {
        private readonly IYamlParser yamlParser;
        private readonly IJsonParser jsonParser;

        public ClientService(IYamlParser yamlParser, IJsonParser jsonParser)
        {
            this.yamlParser = yamlParser;
            this.jsonParser = jsonParser;
        }

        public void DataRetriever(string sourceName, string path)
        {
            Enum.TryParse(typeof(Source), sourceName, out var result);

            switch (result)
            {
                case Source.Capterra:
                    yamlParser.ParseYamlValues(path);

                    break;

                case Source.Softwaredvice:
                    jsonParser.ParseJsonValues(path);

                    break;

            }

        }
    }
}
