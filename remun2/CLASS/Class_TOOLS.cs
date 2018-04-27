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
                    if (string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text) || Convert.ToInt16(tb.Text) == 0)
                        return false;
                }
                if (tb is ComboBox)
                {
                    if (string.IsNullOrEmpty(tb.Text) || string.IsNullOrWhiteSpace(tb.Text))
                        return false;
                }
            }
            return true;
        }        
    }
}
