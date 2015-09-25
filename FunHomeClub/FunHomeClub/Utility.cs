using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    class Utility
    {
        public static bool  checkFieldPresense(ErrorProvider err, Control ctr, String errMsg)
        {
            if (ctr.Text.Trim().Length <= 0)
            {
                err.SetError(ctr, errMsg);
                return true;
            }
            err.SetError(ctr, "");
            return false;
        }

        public static bool checkFieldPresense(Control ctr)
        {
            if (ctr.Text.Trim().Length <= 0)
            {
                return true;
            }
            return false;
        }
    }
}
