﻿using DataReadApp.Captera;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace DataReadApp.Utility
{
    public static class YamlParser
    {
        public static void ParseYamlValues(string path)
        {
            string filePath = path;
            
            if (File.Exists(filePath))
            {
                try
                {
                    string yamlContent = File.ReadAllText(filePath);

                    List<DataReadApp.Captera.Captera> data = DeserializeYaml<List<DataReadApp.Captera.Captera>>(yamlContent);

                    if (data != null)
                    {
                        foreach (var feature in data)
                        { 
                            Console.WriteLine($"importing: Name: {feature.name}; Categories: {feature.tags}; Twitter: @{feature.twitter}");
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
        static T DeserializeYaml<T>(string yamlContent)
        {
            var deserializer = new DeserializerBuilder().Build();
            T result = deserializer.Deserialize<T>(new StringReader(yamlContent));
            return result;
        }
    }
}
