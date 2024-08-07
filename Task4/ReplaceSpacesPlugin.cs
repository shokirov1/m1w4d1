using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m1w4d1.Task4
{
    public class ReplaceSpacesPlugin : IPlugin
    {
        public string Execute(string text)
        {
            return text.Replace(" ", "_");
        }
    }
}
