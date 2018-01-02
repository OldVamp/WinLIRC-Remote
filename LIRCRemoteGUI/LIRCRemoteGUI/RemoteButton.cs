using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace LIRCRemoteGUI
{
    class RemoteButton : Control
    {
        //Used for WM_COPYDATA for string messages
        public struct COPYDATASTRUCT
        {
            public IntPtr dwData;
            public int cbData;
            [MarshalAs(UnmanagedType.LPStr)]
            public string lpData;
        }

        [DllImport("User32.dll", SetLastError = true, EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(String lpClassName, String lpWindowName);
        [DllImport("User32.dll", SetLastError = true, EntryPoint = "SendMessage")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, ref COPYDATASTRUCT lParam);

        public const int WM_COPYDATA = 0x4A;

        protected override CreateParams CreateParams
        { // hide fill of buttons
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }//CreateParams

        void transmit(string remote, string button, string repeats)
        {
            string commands = remote + " " + button + " " + repeats;

            COPYDATASTRUCT cpd;

            IntPtr pOtherWnd = FindWindow(null, "WinLirc");

            if (pOtherWnd == IntPtr.Zero)
            {
                MessageBox.Show("Win Lirc not found.\nPlease ensure it is running.");
            }
            else
            {
                cpd.dwData = IntPtr.Zero;
                cpd.cbData = commands.Length + 1;
                cpd.lpData = commands;
                var res = SendMessage(pOtherWnd, WM_COPYDATA, IntPtr.Zero, ref cpd);
            }

            //old send
            //Process transmitter = new Process();
            //transmitter.StartInfo.FileName = "Transmit.exe";
            //transmitter.StartInfo.UseShellExecute = false;
            //transmitter.StartInfo.Arguments = remote + " " + button + " " + repeats;
            //try
            //{
            //    //MessageBox.Show(remote + " " + button);
            //    transmitter.Start();
            //}
            //catch
            //{
            //    MessageBox.Show("Transmit.exe not found.\nMake sure this program is in the same directory.");
            //}
        }//transmit

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
            Rectangle spot = ClientRectangle;
            spot.Height -= 1;
            spot.Width -= 1;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawRectangle(outine, spot);
        }//OnPaint

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (e.Button == MouseButtons.Left)
                {
                    string[] tokens = Regex.Split(this.Text, ",,");//remote,,button
                    transmit(tokens[0], tokens[1], "0");
                }
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
                
            }
        }//OnMouseMove

    }//class
}//namespace