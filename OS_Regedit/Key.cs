using System;
using System.Windows.Forms;

namespace OS_Regedit
{
    public class Key
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }

        public Key(string name, string type, string value)
        {
            Name = name;
            Type = type;
            Value = value;
        }

        public override string ToString()
        {
            return Name + '-' + Type + '-' + Value;
        }
    }
}
