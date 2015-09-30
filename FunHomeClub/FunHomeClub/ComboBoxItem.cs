using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunHomeClub
{
    class ComboBoxItem
    {
        public ComboBoxItem(string value, string text)
        {
            Value = value;
            Text = text;
        }
        public string Value
        {
            get;
            set;
        }
        public string Text
        {
            get;
            set;
        }
        public override string ToString()
        {
            return Text;
        }
    }
}
