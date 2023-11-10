using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class klk
    {
        public void hh(Control au)
        {
            foreach (var y in au.Controls)
            {
                if (y is Panel)
                {
                    ((Panel)y).Enabled = false;
                }
            }

    }
    }
}
