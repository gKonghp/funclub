using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    class XButton: Button
    {
        public XButton() {
            this.EnabledChanged += new System.EventHandler(this.Button_EnabledChanged);
        }

        private void Button_EnabledChanged(Object sender, EventArgs e) {
            if (this.Enabled == true)
                this.BackColor = System.Drawing.Color.Coral;
            else
                this.BackColor = System.Drawing.SystemColors.ControlDark;
        }
    }
}
