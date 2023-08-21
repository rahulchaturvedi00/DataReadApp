using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using DataReadApp.SoftwareDevice;
using DataReadApp.Captera;

namespace DataReadApp.Utilities.JsonOperations
{

    public class JsonParser : IJsonParser
    {
        public void ParseJsonValues(string path)
        {
            string filePath = path;

            if (File.Exists(filePath))
            {
                try
                {
                    string jsonContent = File.ReadAllText(filePath);

                    SoftwareDevice.SoftwareDevice data = JsonConvert.DeserializeObject<SoftwareDevice.SoftwareDevice>(jsonContent);

                    if (data != null)
                    {
                        foreach (var product in data.products)
                        {
                            Console.WriteLine($"importing: Name: {product.title}; Categories: {string.Join(", ", product.categories)}; Twitter: {product.twitter}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }

        }
    }
}
