namespace QuickTNC
{
    partial class QuickTNC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickTNC));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comPortCombo = new System.Windows.Forms.ComboBox();
            this.stopBitsCombo = new System.Windows.Forms.ComboBox();
            this.parityCombo = new System.Windows.Forms.ComboBox();
            this.dataBitsCombo = new System.Windows.Forms.ComboBox();
            this.speedCombo = new System.Windows.Forms.ComboBox();
            this.stopBitsLabel = new System.Windows.Forms.Label();
            this.parityLabel = new System.Windows.Forms.Label();
            this.dataBitsLabel = new System.Windows.Forms.Label();
            this.speedLabel = new System.Windows.Forms.Label();
            this.comPortLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.scriptClearButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.scriptText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.comPortCombo);
            this.groupBox1.Controls.Add(this.stopBitsCombo);
            this.groupBox1.Controls.Add(this.parityCombo);
            this.groupBox1.Controls.Add(this.dataBitsCombo);
            this.groupBox1.Controls.Add(this.speedCombo);
            this.groupBox1.Controls.Add(this.stopBitsLabel);
            this.groupBox1.Controls.Add(this.parityLabel);
            this.groupBox1.Controls.Add(this.dataBitsLabel);
            this.groupBox1.Controls.Add(this.speedLabel);
            this.groupBox1.Controls.Add(this.comPortLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Settings";
            // 
            // comPortCombo
            // 
            this.comPortCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortCombo.FormattingEnabled = true;
            this.comPortCombo.Location = new System.Drawing.Point(114, 27);
            this.comPortCombo.Name = "comPortCombo";
            this.comPortCombo.Size = new System.Drawing.Size(121, 21);
            this.comPortCombo.TabIndex = 0;
            this.comPortCombo.SelectedIndexChanged += new System.EventHandler(this.commSettingsChanged);
            // 
            // stopBitsCombo
            // 
            this.stopBitsCombo.FormattingEnabled = true;
            this.stopBitsCombo.Items.AddRange(new object[] {
            "None",
            "1",
            "1.5",
            "2"});
            this.stopBitsCombo.Location = new System.Drawing.Point(326, 87);
            this.stopBitsCombo.Name = "stopBitsCombo";
            this.stopBitsCombo.Size = new System.Drawing.Size(96, 21);
            this.stopBitsCombo.TabIndex = 4;
            this.stopBitsCombo.Text = "1";
            this.stopBitsCombo.SelectedIndexChanged += new System.EventHandler(this.commSettingsChanged);
            // 
            // parityCombo
            // 
            this.parityCombo.FormattingEnabled = true;
            this.parityCombo.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.parityCombo.Location = new System.Drawing.Point(220, 87);
            this.parityCombo.Name = "parityCombo";
            this.parityCombo.Size = new System.Drawing.Size(96, 21);
            this.parityCombo.TabIndex = 3;
            this.parityCombo.Text = "None";
            this.parityCombo.SelectedIndexChanged += new System.EventHandler(this.commSettingsChanged);
            // 
            // dataBitsCombo
            // 
            this.dataBitsCombo.FormattingEnabled = true;
            this.dataBitsCombo.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBitsCombo.Location = new System.Drawing.Point(114, 87);
            this.dataBitsCombo.Name = "dataBitsCombo";
            this.dataBitsCombo.Size = new System.Drawing.Size(96, 21);
            this.dataBitsCombo.TabIndex = 2;
            this.dataBitsCombo.Text = "8";
            this.dataBitsCombo.SelectedIndexChanged += new System.EventHandler(this.commSettingsChanged);
            // 
            // speedCombo
            // 
            this.speedCombo.FormattingEnabled = true;
            this.speedCombo.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.speedCombo.Location = new System.Drawing.Point(8, 87);
            this.speedCombo.Name = "speedCombo";
            this.speedCombo.Size = new System.Drawing.Size(96, 21);
            this.speedCombo.TabIndex = 1;
            this.speedCombo.Text = "9600";
            this.speedCombo.SelectedIndexChanged += new System.EventHandler(this.commSettingsChanged);
            // 
            // stopBitsLabel
            // 
            this.stopBitsLabel.AutoSize = true;
            this.stopBitsLabel.Location = new System.Drawing.Point(350, 62);
            this.stopBitsLabel.Name = "stopBitsLabel";
            this.stopBitsLabel.Size = new System.Drawing.Size(49, 13);
            this.stopBitsLabel.TabIndex = 4;
            this.stopBitsLabel.Text = "Stop Bits";
            // 
            // parityLabel
            // 
            this.parityLabel.AutoSize = true;
            this.parityLabel.Location = new System.Drawing.Point(252, 62);
            this.parityLabel.Name = "parityLabel";
            this.parityLabel.Size = new System.Drawing.Size(33, 13);
            this.parityLabel.TabIndex = 3;
            this.parityLabel.Text = "Parity";
            // 
            // dataBitsLabel
            // 
            this.dataBitsLabel.AutoSize = true;
            this.dataBitsLabel.Location = new System.Drawing.Point(137, 62);
            this.dataBitsLabel.Name = "dataBitsLabel";
            this.dataBitsLabel.Size = new System.Drawing.Size(50, 13);
            this.dataBitsLabel.TabIndex = 2;
            this.dataBitsLabel.Text = "Data Bits";
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(37, 62);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(38, 13);
            this.speedLabel.TabIndex = 1;
            this.speedLabel.Text = "Speed";
            // 
            // comPortLabel
            // 
            this.comPortLabel.AutoSize = true;
            this.comPortLabel.Location = new System.Drawing.Point(51, 31);
            this.comPortLabel.Name = "comPortLabel";
            this.comPortLabel.Size = new System.Drawing.Size(53, 13);
            this.comPortLabel.TabIndex = 0;
            this.comPortLabel.Text = "COM Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.clearButton);
            this.groupBox2.Controls.Add(this.outputText);
            this.groupBox2.Location = new System.Drawing.Point(12, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TNC Output";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.clearButton.Location = new System.Drawing.Point(347, 195);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // outputText
            // 
            this.outputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputText.BackColor = System.Drawing.SystemColors.Window;
            this.outputText.Location = new System.Drawing.Point(8, 19);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.Size = new System.Drawing.Size(410, 170);
            this.outputText.TabIndex = 5;
            this.outputText.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.scriptClearButton);
            this.groupBox3.Controls.Add(this.sendButton);
            this.groupBox3.Controls.Add(this.scriptText);
            this.groupBox3.Location = new System.Drawing.Point(12, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(427, 179);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Script";
            // 
            // scriptClearButton
            // 
            this.scriptClearButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.scriptClearButton.Location = new System.Drawing.Point(266, 150);
            this.scriptClearButton.Name = "scriptClearButton";
            this.scriptClearButton.Size = new System.Drawing.Size(75, 23);
            this.scriptClearButton.TabIndex = 9;
            this.scriptClearButton.Text = "Clear";
            this.scriptClearButton.UseVisualStyleBackColor = true;
            this.scriptClearButton.Click += new System.EventHandler(this.scriptClearButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.Location = new System.Drawing.Point(347, 149);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // scriptText
            // 
            this.scriptText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptText.Location = new System.Drawing.Point(8, 27);
            this.scriptText.Multiline = true;
            this.scriptText.Name = "scriptText";
            this.scriptText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.scriptText.Size = new System.Drawing.Size(413, 117);
            this.scriptText.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(454, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem1,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator6,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // contentsToolStripMenuItem1
            // 
            this.contentsToolStripMenuItem1.Name = "contentsToolStripMenuItem1";
            this.contentsToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.contentsToolStripMenuItem1.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(149, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "&About...";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // QuickTNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 582);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(470, 620);
            this.Name = "QuickTNC";
            this.Text = "Quick TNC";
            this.Deactivate += new System.EventHandler(this.QuickTNC_Deactivate);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label comPortLabel;
        private System.Windows.Forms.Label stopBitsLabel;
        private System.Windows.Forms.Label parityLabel;
        private System.Windows.Forms.Label dataBitsLabel;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.ComboBox stopBitsCombo;
        private System.Windows.Forms.ComboBox parityCombo;
        private System.Windows.Forms.ComboBox dataBitsCombo;
        private System.Windows.Forms.ComboBox speedCombo;
        private System.Windows.Forms.ComboBox comPortCombo;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox scriptText;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button scriptClearButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
    }
}

