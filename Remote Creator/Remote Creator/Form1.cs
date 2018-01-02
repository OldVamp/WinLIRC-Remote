using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Remote_Creator
{
    public partial class Form1 : Form
    {
        string ImagePath = "";
        Point PanelMouseDownLocation;
        static List<string> ListofButtons = new List<string>();
        static List<string> ListofRemotes = new List<string>();
        static List<string> ListofButtonNames = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }//Form1
        
        private void loadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog getimage = new OpenFileDialog();
            getimage.Title = "Import Picture of Remote";
            getimage.Filter = "Images|*.jpg;*.jpeg;*.bmp;*.png;*.gif|All Files|*.*";
            getimage.FilterIndex = 1;
            getimage.Multiselect = false;
            ;

            if (getimage.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(getimage.FileName);
                ImagePath = getimage.FileName;
                Image thepicture = new Bitmap(ImagePath);
                remoteimage.Image = thepicture;
                remoteimage.Width = thepicture.Width;
                remoteimage.Height = thepicture.Height;
                if (Form1.ActiveForm.Width < (remoteimage.Width + 6)) Form1.ActiveForm.Width = remoteimage.Width + 6;
                if (Form1.ActiveForm.Height < (remoteimage.Height + 50)) Form1.ActiveForm.Height = remoteimage.Height + 50;
            }
        }//loadimage_Click

        private void Dragspot_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) PanelMouseDownLocation = e.Location;
        }//Dragspot_MouseDown

        private void Dragspot_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                toolbox.Left += e.X - PanelMouseDownLocation.X;
                toolbox.Top += e.Y - PanelMouseDownLocation.Y;
            }
        }//Dragspot_MouseMove

        protected void button_Click(object sender, EventArgs e)
        {
            RemoteButton button = sender as RemoteButton;
            buttonlist.SelectedIndex = buttonlist.FindStringExact(button.Name);
            UpdateButtondata();
        }//button_Click

        protected void button_Mouseup(object sender, EventArgs e)
        {
            RemoteButton button = sender as RemoteButton;
            buttonlist.SelectedIndex = buttonlist.FindStringExact(button.Name);
            UpdateButtondata();
        }//button_Mouseup

        private void New_Click(object sender, EventArgs e)
        {
            RemoteButton button = new RemoteButton();
            button.Click += new EventHandler(button_Click);
            button.MouseUp += new MouseEventHandler(button_Mouseup);
            string newbutton = "newbutton";
            string newremote = "change";
            string newbuttonname = "change";
            

            while (ListofButtons.Contains(newbutton))
            {
                newbutton = newbutton + "1";
            }

            button.Name = newbutton;
            button.Top = 0;
            button.Left = 0;
            button.Width = 30;
            button.Height = 30;
            button.BackColor = Color.Red;
            button.TabStop = false;

            remoteimage.Controls.Add(button);
            ListofButtons.Add(newbutton);
            ListofRemotes.Add(newremote);
            ListofButtonNames.Add(newbuttonname);

            buttonlist.Items.Clear();
            foreach (string test in ListofButtons)
            {
               buttonlist.Items.Add(test);
            }
            buttonlist.SelectedIndex = buttonlist.Items.IndexOf(button.Name);
        }//New_Click

        private void Duplicate_Click(object sender, EventArgs e)
        {
            int pos = ListofButtons.IndexOf(buttonlist.Text);

            if (pos < 0) return;

            RemoteButton button = new RemoteButton();
            button.Click += new EventHandler(button_Click);
            button.MouseUp += new MouseEventHandler(button_Mouseup);
            string newbutton = buttonlist.Text;
            string newremote = ListofRemotes[pos];
            string newbuttonname = ListofButtonNames[pos];

            while (ListofButtons.Contains(newbutton))
            {
                newbutton = newbutton + "1";
            }
            button.Name = newbutton;

            foreach (Control test in remoteimage.Controls)
            {
                if (test is RemoteButton)
                {
                    if (test.Name == buttonlist.Text)
                    {
                        test.Left = (int)posx.Value;
                        button.Top = test.Top ;
                        button.Left = test.Left ;
                        button.Width = test.Width;
                        button.Height = test.Height;
                    }
                }
            }

            remoteimage.Controls.Add(button);
            ListofButtons.Add(newbutton);
            ListofRemotes.Add(newremote);
            ListofButtonNames.Add(newbuttonname);

            buttonlist.Items.Clear();
            foreach (string test in ListofButtons)
            {
                buttonlist.Items.Add(test);
            }
            buttonlist.SelectedIndex = buttonlist.Items.IndexOf(button.Name);
        }//Duplicate_Click

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (Control test in remoteimage.Controls)
            {
                if (test is RemoteButton)
                {
                    if (test.Name == buttonlist.Text)
                    {
                        int pos = ListofButtons.IndexOf(buttonlist.Text);
                        ListofButtons.RemoveAt(pos);
                        ListofRemotes.RemoveAt(pos);
                        ListofButtonNames.RemoveAt(pos);
                        buttonlist.Items.Clear();
                        foreach (string test2 in ListofButtons)
                        {
                            buttonlist.Items.Add(test2);
                        }

                        remoteimage.Controls.Remove(test);

                        foreach (Control test3 in remoteimage.Controls)
                        {
                            if (test is RemoteButton)
                            {
                                if (test.Name == buttonlist.Text)
                                {
                                    posx.Value = test3.Left;
                                    posy.Value = test3.Top;
                                    width.Value = test3.Width;
                                    height.Value = test3.Height;
                                    name.Text = test3.Name;
                                    int pos2 = ListofButtons.IndexOf(test3.Name);
                                    remote.Text = ListofRemotes[pos2];
                                    button.Text = ListofButtonNames[pos2];
                                }
                            }
                        }
                    }
                }
            }//foreach

            buttonlist.SelectedIndex = buttonlist.Items.Count - 1;
            if (buttonlist.Items.Count == 0)
            {
                buttonlist.Text = "";
                posx.Value = 0;
                posy.Value = 0;
                width.Value = 0;
                height.Value = 0;
                name.Text = "";
                remote.Text = "";
                button.Text = "";
            }
        }//Delete_Click

        private void posx_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control test in remoteimage.Controls)
            {
                if (test is RemoteButton)
                {
                    if (test.Name == buttonlist.Text)
                    {
                        test.Left = (int)posx.Value;
                        test.Width -= 1;//refresh trick
                        test.Width += 1;//refresh trick
                    }
                }
            }
        }//posx_ValueChanged

        private void posy_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control test in remoteimage.Controls)
            {
                if (test is RemoteButton)
                {
                    if (test.Name == buttonlist.Text)
                    {
                        test.Top = (int)posy.Value;
                        test.Width -= 1;//refresh trick
                        test.Width += 1;//refresh trick
                    }
                }
            }
        }//posy_ValueChanged

        private void width_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control test in remoteimage.Controls)
            {
                if (test is RemoteButton)
                {
                    if (test.Name == buttonlist.Text)
                    {
                        test.Width = (int)width.Value ;
                    }
                }
            }
        }//width_ValueChanged

        private void height_ValueChanged(object sender, EventArgs e)
        {
            foreach (Control test in remoteimage.Controls)
            {
                if (test is RemoteButton)
                {
                    if (test.Name == buttonlist.Text)
                    {
                        test.Height = (int)height.Value;
                    }
                }
            }
        }//height_ValueChanged

        private void UpdateButtondata()
        {
            foreach (Control test in remoteimage.Controls)
            {
                if (test is RemoteButton)
                {
                    if (test.Name == buttonlist.Text)
                    {
                        test.BackColor = Color.Yellow;
                        posx.Value = test.Left;
                        posy.Value = test.Top;
                        width.Value = test.Width;
                        height.Value = test.Height;
                        name.Text = test.Name;
                        int pos = ListofButtons.IndexOf(test.Name);
                        remote.Text = ListofRemotes[pos];
                        button.Text = ListofButtonNames[pos];
                    }
                    else
                    {
                        test.BackColor = Color.Red;
                    }
                }
            }
        }//UpdateButtondata

        private void buttonlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtondata();
        }//buttonlist_SelectedIndexChanged

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (ListofButtons.Contains(name.Text)) return; //dont make duplicate button names
            if (ListofButtons.Count == 0) return;

            int pos = ListofButtons.IndexOf(buttonlist.Text);
            if (pos == -1) return;
            ListofButtons[pos] = name.Text;

            foreach (Control test in remoteimage.Controls)
            {
                if (test is RemoteButton)
                {
                    if (test.Name == buttonlist.Text)
                    {
                        test.Name = name.Text;
                    }
                }
            }//foreach

            buttonlist.Items.Clear();
            foreach (string test in ListofButtons)
            {
                buttonlist.Items.Add(test);
            }
            buttonlist.SelectedIndex = pos;
        }//name_TextChanged

        private void remote_TextChanged(object sender, EventArgs e)
        {
            if (ListofRemotes.Count == 0) return;
            int pos = ListofButtons.IndexOf(buttonlist.Text);
            ListofRemotes[pos] = remote.Text;
        }//remote_TextChanged

        private void button_TextChanged(object sender, EventArgs e)
        {
            if (ListofButtonNames.Count == 0) return;
            int pos = ListofButtons.IndexOf(buttonlist.Text);
            ListofButtonNames[pos] = button.Text;
        }//button_TextChanged

        private void saveconfig_Click(object sender, EventArgs e)
        {
            int howmany = ListofButtons.Count;
            string config = "imagefile,," + ImagePath;
            int index = 0;
            
            for (index = 0; index < howmany; index++ )
            {
                string name = ListofButtons[index];
                string remote = ListofRemotes[index];
                string buttonname = ListofButtonNames[index];
                int x = 0, y = 0, w = 0, h = 0;
                foreach (Control test in remoteimage.Controls)
                {
                    if (test is RemoteButton)
                    {
                        if (test.Name == name)
                        {
                            x = test.Left;
                            y = test.Top;
                            w = test.Width;
                            h = test.Height;
                        }
                    }
                }//foreach
                config = config + "\r\nbutton,," + name + ",," + remote + ",," + buttonname + ",," + x.ToString() + ",," + y.ToString() + ",," + w.ToString() + ",," + h.ToString();
            }//for
            //MessageBox.Show(config);
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save Remote Defination";
            save.Filter = "Remote Defination|*.remote";
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (save.FileName != "")
                {
                    System.IO.File.WriteAllText(@save.FileName, config);
                }
            }
        }//saveconfig_Click

        private void newconfig_Click(object sender, EventArgs e)
        {
            buttonlist.Items.Clear();
            ListofButtons = new List<string>();
            ListofRemotes = new List<string>();
            ListofButtonNames = new List<string>();
            foreach (Control test in remoteimage.Controls)
            {
                if (test is RemoteButton)
                {
                    remoteimage.Controls.Remove(test);
                }
            }//foreach
            remoteimage.Image = null;
            buttonlist.Text = null;
            posx.Value = 0;
            posy.Value = 0;
            width.Value = 0;
            height.Value = 0;
            name.Text = "";
            remote.Text = "";
            button.Text = "";
        }//newconfig_Click

        private void loadconfig_Click(object sender, EventArgs e)
        {
            buttonlist.Items.Clear();
            ListofButtons.Clear();
            ListofRemotes.Clear();
            ListofButtonNames.Clear();
            foreach (Control test in remoteimage.Controls)
            {
                if (test is RemoteButton)
                {
                    remoteimage.Controls.Remove(test);
                }
            }//foreach
            remoteimage.Image = null;
            buttonlist.Text = "";
            posx.Value = 0;
            posy.Value = 0;
            width.Value = 0;
            height.Value = 0;
            name.Text = "";
            remote.Text = "";
            button.Text = "";


            OpenFileDialog getconfig = new OpenFileDialog();
            getconfig.Title = "Open Remote Defination";
            getconfig.Filter = "Remotes|*.remote";
            getconfig.FilterIndex = 1;
            getconfig.Multiselect = false;
            ;

            if (getconfig.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(getconfig.FileName);
                try
                {
                    using(System.IO.StreamReader reader = new System.IO.StreamReader(getconfig.FileName))
                    {
                        string line;
                        int lineNumber = 0;
                        while((line = reader.ReadLine())!= null)
                        {
                            lineNumber++;
                            string[] tokens = Regex.Split(line,",,");
                            if (tokens.Length > 1)
                            {
                                if (tokens[0] == "imagefile")
                                {
                                    if (File.Exists(tokens[1]))
                                    {
                                        ImagePath = tokens[1];
                                        Image thepicture = new Bitmap(tokens[1]);
                                        remoteimage.Image = thepicture;
                                        remoteimage.Width = thepicture.Width;
                                        remoteimage.Height = thepicture.Height;
                                        if (Form1.ActiveForm.Width < (remoteimage.Width + 6)) Form1.ActiveForm.Width = remoteimage.Width + 6;
                                        if (Form1.ActiveForm.Height < (remoteimage.Height + 50)) Form1.ActiveForm.Height = remoteimage.Height + 50;
                                    }
                                }//imagefile
                                if (tokens[0] == "button" && tokens.Length > 7)
                                {
                                    RemoteButton newremotebutton = new RemoteButton();
                                    newremotebutton.Click += new EventHandler(button_Click);
                                    newremotebutton.MouseUp += new MouseEventHandler(button_Mouseup);
                                    string newbutton = tokens[1];
                                    string newremote = tokens[2];
                                    string newbuttonname = tokens[3];
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
                                    ListofButtons.Add(newbutton);
                                    ListofRemotes.Add(newremote);
                                    ListofButtonNames.Add(newbuttonname);
                                }//button
                            }
                        }//while

                        buttonlist.Items.Clear();
                        foreach (string test in ListofButtons)
                        {
                            buttonlist.Items.Add(test);
                        }
                        buttonlist.SelectedIndex = buttonlist.Items.Count -1;
                    }//using
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file.");
                }
            }//ok clicked
        }//loadconfig_Click

    }//class
}//namespace
