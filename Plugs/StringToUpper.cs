using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPlug;


namespace Plugs
{
    [PlugsName("小写转大写")]
    public class StringToUpper:IPlugs
    {
        
        public string ProcessText(string messages)
        {
            //throw new NotImplementedException();
            return messages.ToUpper();
        }
    }
}
