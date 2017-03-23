using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IPlug;
using System.Text.RegularExpressions;

namespace Plugs
{
    [PlugsName("首字母大写")]
    public class FirstWordToUpper : IPlugs
    {

        public string ProcessText(string messages)
        {
            //throw new NotImplementedException();
            return Regex.Replace(messages, @"\b[a-z]\w+?\b", delegate(Match match)
            {
                string v = match.ToString();
                return char.ToUpper(v[0]) + v.Substring(1);
            });
            
        }
    }
}
