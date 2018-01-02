using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Remote_Creator
{
    public class ReverseUpDown : NumericUpDown 
    {
        public override void UpButton()
        {
            base.DownButton();
        }
        public override void DownButton()
        {
            base.UpButton();
        }
    }//class
}//namespace
