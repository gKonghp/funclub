using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunHomeClub
{
    class Utility
    {
        public static bool checkFieldPresense(ErrorProvider err, Control ctr, String errMsg)
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

        public static string firstChar2UpperCase(string str)
        {
            string firstChar = str[0].ToString();
            str = firstChar.ToUpper() + str.Substring(1, str.Length - 1);
            return str;
        }

        public static string findAvailableID(DataTable dt, string tableID, string headerPattern, string middlePattern)
        {
            string idHeader = headerPattern;
            string idMiddle = middlePattern;
            int idNumber = 1;

            Console.WriteLine(idHeader + idMiddle + idNumber);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (!dt.Rows[i][tableID].ToString().Equals(idHeader + idMiddle + idNumber))
                {
                    return idHeader + idMiddle + idNumber;
                }
                else
                {
                    idNumber += 1;
                    if (idNumber == 10 || idNumber == 100 || idNumber == 1000)
                    {
                        idMiddle = idMiddle.Substring(0, idMiddle.Length - 1);
                    }
                    else if (idNumber > 10000)
                    {
                        return "ERROR";
                    }
                }
            }
            return idHeader + idMiddle + idNumber;
        }

        public static void repaintFrameSize(Form targetForm, Form sourceForm)
        {
            System.Drawing.Size size = sourceForm.PreferredSize;
            targetForm.Size = size;
            targetForm.Width = sourceForm.Width + 20;
            targetForm.Height = sourceForm.Height + 75;

        }

        public static void repaintFrameSize(Form targetForm, Form sourceForm, Control mainCtr, int supWidth)
        {
            targetForm.Width = mainCtr.Size.Width + 20 + supWidth;
            targetForm.Height = sourceForm.Height + 75;
        }
        public static bool IsNumeric(string s)
        {
            double dummy = 0;
            return Double.TryParse(s, out dummy);
        }


    }
}
