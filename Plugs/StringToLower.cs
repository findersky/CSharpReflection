using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPlug;

namespace Plugs
{
    [PlugsName("大写转小写")]
    public class StringToLower:IPlugs
    {
        
        public string ProcessText(string messages)
        {
            //throw new NotImplementedException();
            return messages.ToLower();
        }
    }
}
