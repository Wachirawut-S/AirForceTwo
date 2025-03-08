namespace Computer_Vision_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            splitContainer1 = new SplitContainer();
            checkBox1 = new CheckBox();
            trackBar5 = new TrackBar();
            trackBar6 = new TrackBar();
            label6 = new Label();
            trackBar3 = new TrackBar();
            label3 = new Label();
            trackBar4 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            label1 = new Label();
            button1 = new Button();
            imageBox1 = new Emgu.CV.UI.ImageBox();
            saveFileDialog1 = new SaveFileDialog();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            filesToolStripMenuItem = new ToolStripMenuItem();
            saveImageToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            presetToolStripMenuItem = new ToolStripMenuItem();
            trackRedToolStripMenuItem = new ToolStripMenuItem();
            trackGreenToolStripMenuItem = new ToolStripMenuItem();
            trackBlueToolStripMenuItem = new ToolStripMenuItem();
            trackYellowToolStripMenuItem = new ToolStripMenuItem();
            trackOrangeToolStripMenuItem = new ToolStripMenuItem();
            trackPurpleToolStripMenuItem = new ToolStripMenuItem();
            trackPinkToolStripMenuItem = new ToolStripMenuItem();
            trackCyanToolStripMenuItem = new ToolStripMenuItem();
            trackBlackToolStripMenuItem = new ToolStripMenuItem();
            trackWhiteToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BackColor = SystemColors.ControlText;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.ControlText;
            splitContainer1.Panel1.Controls.Add(checkBox1);
            splitContainer1.Panel1.Controls.Add(trackBar5);
            splitContainer1.Panel1.Controls.Add(trackBar6);
            splitContainer1.Panel1.Controls.Add(label6);
            splitContainer1.Panel1.Controls.Add(trackBar3);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(trackBar4);
            splitContainer1.Panel1.Controls.Add(trackBar2);
            splitContainer1.Panel1.Controls.Add(trackBar1);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(imageBox1);
            splitContainer1.Size = new Size(923, 525);
            splitContainer1.SplitterDistance = 164;
            splitContainer1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.ControlText;
            checkBox1.ForeColor = SystemColors.ControlLightLight;
            checkBox1.Location = new Point(48, 60);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(69, 19);
            checkBox1.TabIndex = 14;
            checkBox1.Text = "Activate";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // trackBar5
            // 
            trackBar5.Location = new Point(6, 349);
            trackBar5.Maximum = 255;
            trackBar5.Name = "trackBar5";
            trackBar5.Size = new Size(156, 45);
            trackBar5.TabIndex = 13;
            trackBar5.Value = 255;
            // 
            // trackBar6
            // 
            trackBar6.Location = new Point(5, 400);
            trackBar6.Maximum = 255;
            trackBar6.Name = "trackBar6";
            trackBar6.Size = new Size(156, 45);
            trackBar6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(47, 331);
            label6.Name = "label6";
            label6.Size = new Size(79, 15);
            label6.TabIndex = 10;
            label6.Text = " Value: 0 - 255";
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(6, 232);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(156, 45);
            trackBar3.TabIndex = 9;
            trackBar3.Value = 255;
            trackBar3.Scroll += trackBar3_Scroll;
            trackBar3.ValueChanged += trackBar3_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(28, 214);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 8;
            label3.Text = "Saturation: 0 - 255";
            label3.Click += label3_Click;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(6, 283);
            trackBar4.Maximum = 255;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(156, 45);
            trackBar4.TabIndex = 7;
            trackBar4.ValueChanged += trackBar4_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(6, 166);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(156, 45);
            trackBar2.TabIndex = 5;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = SystemColors.ControlText;
            trackBar1.Location = new Point(6, 115);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(156, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 127;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(47, 97);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Hue: 0 - 127";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(3, 12);
            button1.Name = "button1";
            button1.Size = new Size(156, 42);
            button1.TabIndex = 0;
            button1.Text = "Start Camera";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // imageBox1
            // 
            imageBox1.BackColor = Color.Black;
            imageBox1.BackgroundImage = (Image)resources.GetObject("imageBox1.BackgroundImage");
            imageBox1.BackgroundImageLayout = ImageLayout.Zoom;
            imageBox1.Dock = DockStyle.Fill;
            imageBox1.Location = new Point(0, 0);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(755, 525);
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(64, 64, 64);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, filesToolStripMenuItem, presetToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(923, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.ForeColor = SystemColors.ControlLightLight;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveImageToolStripMenuItem, exitToolStripMenuItem });
            filesToolStripMenuItem.ForeColor = Color.Silver;
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(50, 20);
            filesToolStripMenuItem.Text = "Menu";
            // 
            // saveImageToolStripMenuItem
            // 
            saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            saveImageToolStripMenuItem.Size = new Size(180, 22);
            saveImageToolStripMenuItem.Text = "Save Image";
            saveImageToolStripMenuItem.Click += saveImageToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Reset";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // presetToolStripMenuItem
            // 
            presetToolStripMenuItem.BackColor = Color.FromArgb(64, 64, 64);
            presetToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { trackRedToolStripMenuItem, trackGreenToolStripMenuItem, trackBlueToolStripMenuItem, trackYellowToolStripMenuItem, trackOrangeToolStripMenuItem, trackPurpleToolStripMenuItem, trackPinkToolStripMenuItem, trackCyanToolStripMenuItem, trackBlackToolStripMenuItem, trackWhiteToolStripMenuItem });
            presetToolStripMenuItem.ForeColor = Color.Silver;
            presetToolStripMenuItem.Name = "presetToolStripMenuItem";
            presetToolStripMenuItem.Size = new Size(51, 20);
            presetToolStripMenuItem.Text = "Preset";
            // 
            // trackRedToolStripMenuItem
            // 
            trackRedToolStripMenuItem.Name = "trackRedToolStripMenuItem";
            trackRedToolStripMenuItem.Size = new Size(180, 22);
            trackRedToolStripMenuItem.Text = "Track red";
            trackRedToolStripMenuItem.Click += trackRedToolStripMenuItem_Click;
            // 
            // trackGreenToolStripMenuItem
            // 
            trackGreenToolStripMenuItem.Name = "trackGreenToolStripMenuItem";
            trackGreenToolStripMenuItem.Size = new Size(180, 22);
            trackGreenToolStripMenuItem.Text = "Track green";
            trackGreenToolStripMenuItem.Click += trackGreenToolStripMenuItem_Click;
            // 
            // trackBlueToolStripMenuItem
            // 
            trackBlueToolStripMenuItem.Name = "trackBlueToolStripMenuItem";
            trackBlueToolStripMenuItem.Size = new Size(180, 22);
            trackBlueToolStripMenuItem.Text = "Track blue";
            trackBlueToolStripMenuItem.Click += trackBlueToolStripMenuItem_Click;
            // 
            // trackYellowToolStripMenuItem
            // 
            trackYellowToolStripMenuItem.Name = "trackYellowToolStripMenuItem";
            trackYellowToolStripMenuItem.Size = new Size(180, 22);
            trackYellowToolStripMenuItem.Text = "Track yellow";
            trackYellowToolStripMenuItem.Click += trackYellowToolStripMenuItem_Click;
            // 
            // trackOrangeToolStripMenuItem
            // 
            trackOrangeToolStripMenuItem.Name = "trackOrangeToolStripMenuItem";
            trackOrangeToolStripMenuItem.Size = new Size(180, 22);
            trackOrangeToolStripMenuItem.Text = "Track orange";
            trackOrangeToolStripMenuItem.Click += trackOrangeToolStripMenuItem_Click;
            // 
            // trackPurpleToolStripMenuItem
            // 
            trackPurpleToolStripMenuItem.Name = "trackPurpleToolStripMenuItem";
            trackPurpleToolStripMenuItem.Size = new Size(180, 22);
            trackPurpleToolStripMenuItem.Text = "Track purple";
            trackPurpleToolStripMenuItem.Click += trackPurpleToolStripMenuItem_Click;
            // 
            // trackPinkToolStripMenuItem
            // 
            trackPinkToolStripMenuItem.Name = "trackPinkToolStripMenuItem";
            trackPinkToolStripMenuItem.Size = new Size(180, 22);
            trackPinkToolStripMenuItem.Text = "Track pink";
            trackPinkToolStripMenuItem.Click += trackPinkToolStripMenuItem_Click;
            // 
            // trackCyanToolStripMenuItem
            // 
            trackCyanToolStripMenuItem.Name = "trackCyanToolStripMenuItem";
            trackCyanToolStripMenuItem.Size = new Size(180, 22);
            trackCyanToolStripMenuItem.Text = "Track cyan";
            trackCyanToolStripMenuItem.Click += trackCyanToolStripMenuItem_Click;
            // 
            // trackBlackToolStripMenuItem
            // 
            trackBlackToolStripMenuItem.Name = "trackBlackToolStripMenuItem";
            trackBlackToolStripMenuItem.Size = new Size(180, 22);
            trackBlackToolStripMenuItem.Text = "Track black";
            trackBlackToolStripMenuItem.Click += trackBlackToolStripMenuItem_Click;
            // 
            // trackWhiteToolStripMenuItem
            // 
            trackWhiteToolStripMenuItem.Name = "trackWhiteToolStripMenuItem";
            trackWhiteToolStripMenuItem.Size = new Size(180, 22);
            trackWhiteToolStripMenuItem.Text = "Track white";
            trackWhiteToolStripMenuItem.Click += trackWhiteToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 549);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "AirForceOne";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private SaveFileDialog saveFileDialog1;
        private Label label1;
        private TrackBar trackBar6;
        private Label label6;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private TrackBar trackBar5;
        private CheckBox checkBox1;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem saveImageToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem modeToolStripMenuItem;
        private ToolStripMenuItem cameraToolStripMenuItem;
        private ToolStripMenuItem canvasToolStripMenuItem;
        private ToolStripMenuItem maskToolStripMenuItem;
        private ToolStripMenuItem presetToolStripMenuItem;
        private ToolStripMenuItem trackRedToolStripMenuItem;
        private ToolStripMenuItem trackGreenToolStripMenuItem;
        private ToolStripMenuItem trackBlueToolStripMenuItem;
        private ToolStripMenuItem trackYellowToolStripMenuItem;
        private ToolStripMenuItem trackOrangeToolStripMenuItem;
        private ToolStripMenuItem trackPurpleToolStripMenuItem;
        private ToolStripMenuItem trackPinkToolStripMenuItem;
        private ToolStripMenuItem trackCyanToolStripMenuItem;
        private ToolStripMenuItem trackBlackToolStripMenuItem;
        private ToolStripMenuItem trackWhiteToolStripMenuItem;
    }
}
