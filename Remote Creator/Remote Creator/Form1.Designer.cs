namespace Remote_Creator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolbox = new System.Windows.Forms.Panel();
            this.Dragspot = new System.Windows.Forms.PictureBox();
            this.buttonlist = new System.Windows.Forms.ComboBox();
            this.loadconfig = new System.Windows.Forms.Button();
            this.saveconfig = new System.Windows.Forms.Button();
            this.newconfig = new System.Windows.Forms.Button();
            this.loadimage = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.remote = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.NumericUpDown();
            this.width = new System.Windows.Forms.NumericUpDown();
            this.posx = new System.Windows.Forms.NumericUpDown();
            this.Duplicate = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.remoteimage = new System.Windows.Forms.PictureBox();
            this.posy = new Remote_Creator.ReverseUpDown();
            this.toolbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dragspot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posy)).BeginInit();
            this.SuspendLayout();
            // 
            // toolbox
            // 
            this.toolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolbox.Controls.Add(this.posy);
            this.toolbox.Controls.Add(this.Dragspot);
            this.toolbox.Controls.Add(this.buttonlist);
            this.toolbox.Controls.Add(this.loadconfig);
            this.toolbox.Controls.Add(this.saveconfig);
            this.toolbox.Controls.Add(this.newconfig);
            this.toolbox.Controls.Add(this.loadimage);
            this.toolbox.Controls.Add(this.label7);
            this.toolbox.Controls.Add(this.button);
            this.toolbox.Controls.Add(this.label6);
            this.toolbox.Controls.Add(this.remote);
            this.toolbox.Controls.Add(this.label5);
            this.toolbox.Controls.Add(this.label4);
            this.toolbox.Controls.Add(this.label3);
            this.toolbox.Controls.Add(this.label2);
            this.toolbox.Controls.Add(this.label1);
            this.toolbox.Controls.Add(this.Delete);
            this.toolbox.Controls.Add(this.name);
            this.toolbox.Controls.Add(this.height);
            this.toolbox.Controls.Add(this.width);
            this.toolbox.Controls.Add(this.posx);
            this.toolbox.Controls.Add(this.Duplicate);
            this.toolbox.Controls.Add(this.New);
            this.toolbox.Location = new System.Drawing.Point(262, 0);
            this.toolbox.Name = "toolbox";
            this.toolbox.Size = new System.Drawing.Size(349, 157);
            this.toolbox.TabIndex = 0;
            // 
            // Dragspot
            // 
            this.Dragspot.BackColor = System.Drawing.Color.DarkBlue;
            this.Dragspot.Location = new System.Drawing.Point(0, 0);
            this.Dragspot.Name = "Dragspot";
            this.Dragspot.Size = new System.Drawing.Size(348, 21);
            this.Dragspot.TabIndex = 21;
            this.Dragspot.TabStop = false;
            this.Dragspot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dragspot_MouseDown);
            this.Dragspot.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dragspot_MouseMove);
            // 
            // buttonlist
            // 
            this.buttonlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buttonlist.FormattingEnabled = true;
            this.buttonlist.Location = new System.Drawing.Point(2, 52);
            this.buttonlist.Name = "buttonlist";
            this.buttonlist.Size = new System.Drawing.Size(172, 21);
            this.buttonlist.TabIndex = 7;
            this.buttonlist.SelectedIndexChanged += new System.EventHandler(this.buttonlist_SelectedIndexChanged);
            // 
            // loadconfig
            // 
            this.loadconfig.Location = new System.Drawing.Point(2, 22);
            this.loadconfig.Name = "loadconfig";
            this.loadconfig.Size = new System.Drawing.Size(80, 24);
            this.loadconfig.TabIndex = 0;
            this.loadconfig.Text = "Load Config";
            this.loadconfig.UseVisualStyleBackColor = true;
            this.loadconfig.Click += new System.EventHandler(this.loadconfig_Click);
            // 
            // saveconfig
            // 
            this.saveconfig.Location = new System.Drawing.Point(157, 22);
            this.saveconfig.Name = "saveconfig";
            this.saveconfig.Size = new System.Drawing.Size(73, 24);
            this.saveconfig.TabIndex = 2;
            this.saveconfig.Text = "Save Config";
            this.saveconfig.UseVisualStyleBackColor = true;
            this.saveconfig.Click += new System.EventHandler(this.saveconfig_Click);
            // 
            // newconfig
            // 
            this.newconfig.Location = new System.Drawing.Point(84, 22);
            this.newconfig.Name = "newconfig";
            this.newconfig.Size = new System.Drawing.Size(71, 24);
            this.newconfig.TabIndex = 1;
            this.newconfig.Text = "New Config";
            this.newconfig.UseVisualStyleBackColor = true;
            this.newconfig.Click += new System.EventHandler(this.newconfig_Click);
            // 
            // loadimage
            // 
            this.loadimage.Location = new System.Drawing.Point(274, 22);
            this.loadimage.Name = "loadimage";
            this.loadimage.Size = new System.Drawing.Size(71, 24);
            this.loadimage.TabIndex = 3;
            this.loadimage.Text = "Load Image";
            this.loadimage.UseVisualStyleBackColor = true;
            this.loadimage.Click += new System.EventHandler(this.loadimage_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Button Command";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(93, 108);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(140, 20);
            this.button.TabIndex = 9;
            this.button.TextChanged += new System.EventHandler(this.button_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Remote Name";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // remote
            // 
            this.remote.Location = new System.Drawing.Point(93, 130);
            this.remote.Name = "remote";
            this.remote.Size = new System.Drawing.Size(140, 20);
            this.remote.TabIndex = 10;
            this.remote.TextChanged += new System.EventHandler(this.remote_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Button Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pos Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pos X";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(298, 51);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(47, 22);
            this.Delete.TabIndex = 6;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(93, 86);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(140, 20);
            this.name.TabIndex = 8;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(292, 129);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(50, 20);
            this.height.TabIndex = 14;
            this.height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.height.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.height.ValueChanged += new System.EventHandler(this.height_ValueChanged);
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(236, 129);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(50, 20);
            this.width.TabIndex = 13;
            this.width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.width.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.width.ValueChanged += new System.EventHandler(this.width_ValueChanged);
            // 
            // posx
            // 
            this.posx.Location = new System.Drawing.Point(236, 91);
            this.posx.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.posx.Name = "posx";
            this.posx.Size = new System.Drawing.Size(50, 20);
            this.posx.TabIndex = 11;
            this.posx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.posx.ValueChanged += new System.EventHandler(this.posx_ValueChanged);
            // 
            // Duplicate
            // 
            this.Duplicate.Location = new System.Drawing.Point(228, 51);
            this.Duplicate.Name = "Duplicate";
            this.Duplicate.Size = new System.Drawing.Size(60, 22);
            this.Duplicate.TabIndex = 5;
            this.Duplicate.Text = "Duplicate";
            this.Duplicate.UseVisualStyleBackColor = true;
            this.Duplicate.Click += new System.EventHandler(this.Duplicate_Click);
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(180, 51);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(39, 22);
            this.New.TabIndex = 4;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // remoteimage
            // 
            this.remoteimage.Location = new System.Drawing.Point(0, 0);
            this.remoteimage.Name = "remoteimage";
            this.remoteimage.Size = new System.Drawing.Size(256, 512);
            this.remoteimage.TabIndex = 1;
            this.remoteimage.TabStop = false;
            // 
            // posy
            // 
            this.posy.Location = new System.Drawing.Point(293, 91);
            this.posy.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.posy.Name = "posy";
            this.posy.Size = new System.Drawing.Size(49, 20);
            this.posy.TabIndex = 22;
            this.posy.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.posy.ValueChanged += new System.EventHandler(this.posy_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 513);
            this.Controls.Add(this.toolbox);
            this.Controls.Add(this.remoteimage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Remote GUI Creator";
            this.toolbox.ResumeLayout(false);
            this.toolbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dragspot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toolbox;
        private System.Windows.Forms.Button Duplicate;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.NumericUpDown posx;
        private System.Windows.Forms.NumericUpDown height;
        private System.Windows.Forms.NumericUpDown width;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox remote;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button loadconfig;
        private System.Windows.Forms.Button saveconfig;
        private System.Windows.Forms.Button newconfig;
        private System.Windows.Forms.Button loadimage;
        private System.Windows.Forms.ComboBox buttonlist;
        private System.Windows.Forms.PictureBox remoteimage;
        private System.Windows.Forms.PictureBox Dragspot;
        private ReverseUpDown posy;
    }
}

