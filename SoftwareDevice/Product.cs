using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReadApp.SoftwareDevice
{
    [Serializable]
    public class Product
    {
        public List<string> categories { get; set; }

        public string twitter { get; set; }

        public string title { get; set; }
    }
}
