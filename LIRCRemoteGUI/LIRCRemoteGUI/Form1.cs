using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace LIRCRemoteGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<string> ListofButtons = new List<string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arguments = Environment.GetCommandLineArgs();//program,file
            if (arguments.Length > 1)
            {
                //MessageBox.Show(string.Join(Environment.NewLine, arguments));
                string filename = arguments[1];
                string title = Path.GetFileNameWithoutExtension(filename);
                if (title != "" ) this.Text = title;
                try
                {
                    using (System.IO.StreamReader reader = new System.IO.StreamReader(filename))
                    {
                        string line;
                        int lineNumber = 0;
                        while ((line = reader.ReadLine()) != null)
                        {
                            lineNumber++;
                            string[] tokens = Regex.Split(line, ",,");
                            if (tokens.Length > 1)
                            {
                                if (tokens[0] == "imagefile")
                                {
                                    if (File.Exists(tokens[1]))
                                    {
                                        Image thepicture = new Bitmap(tokens[1]);
                                        remoteimage.Image = thepicture;
                                        remoteimage.Width = thepicture.Width;
                                        remoteimage.Height = thepicture.Height;

                                        Rectangle screenrectange = RectangleToScreen(this.ClientRectangle);
                                        int titleheight = screenrectange.Top - this.Top;

                                        this.Width = remoteimage.Width + SystemInformation.BorderSize.Width;
                                        this.Height = remoteimage.Height + titleheight +4;
                                        this.CenterToScreen();
                                    }
                                }//imagefile
                                if (tokens[0] == "button" && tokens.Length > 7)
                                {
                                    RemoteButton newremotebutton = new RemoteButton();
                                    string newbutton = tokens[1];
                                    newremotebutton.Text = tokens[2] + ",," + tokens[3];//remote,,button
                                    
                                    while (ListofButtons.Contains(newbutton))
                                    {
                                        newbutton = newbutton + "1";
                                    }
                                    newremotebutton.Name = newbutton;
                                    newremotebutton.Left = int.Parse(tokens[4]);
                                    newremotebutton.Top = int.Parse(tokens[5]);
                                    newremotebutton.Width = int.Parse(tokens[6]);
                                    newremotebutton.Height = int.Parse(tokens[7]);
                                    newremotebutton.BackColor = Color.Red;
                                    remoteimage.Controls.Add(newremotebutton);
                                }//button
                            }
                        }//while
                    }//using
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file."+Environment.NewLine + ex.ToString());
                }
            }//arguments present
        }
    }//class
}//namespace