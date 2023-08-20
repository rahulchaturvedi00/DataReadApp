using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataReadApp
{
    public enum Source : long
    {
        [Description("Capterra")]
        Capterra = 1,

        [Description("Softwaredvice")]
        Softwaredvice = 2
    }
}
