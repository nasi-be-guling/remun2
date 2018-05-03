using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace remun2.CLASS
{
    class Class_TOOLS
    {
        public bool CekTeksBoxKosong(Control.ControlCollection controls)
        {
            foreach (Control tb in controls)
            {
                if (tb is TextBox)
                {
                    if (string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text))
                    {
                        return false;                        
                    }
                }
                if (tb is ComboBox)
                {
                    if (string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text))
                        return false;
                }
            }
            return true;
        }

        public double ParseInt(string value, double defaultIntValue = 0)
        {
            double parsedInt;
            if (double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out parsedInt))
            {
                return parsedInt;
            }

            return defaultIntValue;
        }

        public bool ControlNameIteration(Control.ControlCollection controls, string controlName)
        {
            foreach (Control tb in controls)
            {
                if (tb.Name == controlName)
                {
                    if (ParseInt(tb.Text) <= 0)
                    return true;
                }
            }
            return false;
        }
    }
}
