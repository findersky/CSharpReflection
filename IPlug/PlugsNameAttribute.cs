using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IPlug
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PlugsNameAttribute : Attribute
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public PlugsNameAttribute(string name)
        {
            this.name = name;
        }
    }
}
