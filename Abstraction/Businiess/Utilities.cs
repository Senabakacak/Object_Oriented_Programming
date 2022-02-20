using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction.Businiess
{
    public static  class Utilities
    {
        public static void EraseArea (GroupBox groupbox)
        {
            foreach (Control control in groupbox.Controls)
            {
                if(control is TextBox)
                {
                    control.Text=String.Empty;
                }
            }

        }
    }
}
