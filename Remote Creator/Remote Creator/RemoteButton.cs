using System;
using System.Windows.Forms;
using System.Drawing;

namespace Remote_Creator
{
    class RemoteButton : Control
    {
        Point ButtonDownLocation;
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }
        
        protected override void OnLocationChanged(EventArgs e)
        {
            //base.OnLocationChanged(e);
            Invalidate();
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
 	            //base.OnPaintBackground(pevent);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Pen outine = new Pen(this.BackColor, 2f);
            Rectangle spot = ClientRectangle ;
            spot.Height -= 1;
            spot.Width -= 1;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(outine, spot);
        }//OnPaint

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               ButtonDownLocation = e.Location;
            }
        }//OnMouseDown

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                
            }
        }//OnMouseUp

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - ButtonDownLocation.X;
                this.Top += e.Y - ButtonDownLocation.Y;
            }
        }//OnMouseMove



    }//class
}//namespace