using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace AmazFit_Watchface_2
{
    public class DarkTabControl : CustomTabControl
    {
        public DarkTabControl()
        {
            DisplayStyle = TabStyle.Dark;            
        }
    }
}
