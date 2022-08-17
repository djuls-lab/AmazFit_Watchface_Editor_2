using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace AmazFit_Watchface_2
{    
    class DarkTabControl : CustomTabControl
    {
        public DarkTabControl()
        {
            this.DisplayStyle = TabStyle.Dark;            
        }
    }
}
