namespace BTLHelper
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.castersTab = new System.Windows.Forms.TabPage();
            this.Guest4ComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Guest3ComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Guest2ComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Guest1ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Host2ComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Host1ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.questionsTab = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.clearQuestionButton = new System.Windows.Forms.Button();
            this.clearQuestionsButton = new System.Windows.Forms.Button();
            this.manualQuestionButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.twitterHashtagBox = new System.Windows.Forms.TextBox();
            this.twitterGetQuestionsButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.twitchGetQuestionsButton = new System.Windows.Forms.Button();
            this.splashTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.splashBottomBox = new System.Windows.Forms.TextBox();
            this.splashTopBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.masterPublishButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.castersTab.SuspendLayout();
            this.questionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.splashTab.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.castersTab);
            this.tabControl1.Controls.Add(this.questionsTab);
            this.tabControl1.Controls.Add(this.splashTab);
            this.tabControl1.Location = new System.Drawing.Point(0, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 440);
            this.tabControl1.TabIndex = 1;
            // 
            // castersTab
            // 
            this.castersTab.Controls.Add(this.Guest4ComboBox);
            this.castersTab.Controls.Add(this.label6);
            this.castersTab.Controls.Add(this.Guest3ComboBox);
            this.castersTab.Controls.Add(this.label5);
            this.castersTab.Controls.Add(this.Guest2ComboBox);
            this.castersTab.Controls.Add(this.label4);
            this.castersTab.Controls.Add(this.Guest1ComboBox);
            this.castersTab.Controls.Add(this.label3);
            this.castersTab.Controls.Add(this.Host2ComboBox);
            this.castersTab.Controls.Add(this.label2);
            this.castersTab.Controls.Add(this.Host1ComboBox);
            this.castersTab.Controls.Add(this.label1);
            this.castersTab.Location = new System.Drawing.Point(4, 22);
            this.castersTab.Name = "castersTab";
            this.castersTab.Padding = new System.Windows.Forms.Padding(3);
            this.castersTab.Size = new System.Drawing.Size(1115, 414);
            this.castersTab.TabIndex = 1;
            this.castersTab.Text = "Hosts & Guests";
            this.castersTab.UseVisualStyleBackColor = true;
            // 
            // Guest4ComboBox
            // 
            this.Guest4ComboBox.FormattingEnabled = true;
            this.Guest4ComboBox.Items.AddRange(new object[] {
            "STEPH MORRISON",
            "EVAN MORRISON",
            "TY TREMBLAY",
            "DAVID McLAUGHLIN",
            "FRANCIS O\'ROURKE",
            "NAVID SHAFA"});
            this.Guest4ComboBox.Location = new System.Drawing.Point(72, 154);
            this.Guest4ComboBox.Name = "Guest4ComboBox";
            this.Guest4ComboBox.Size = new System.Drawing.Size(176, 21);
            this.Guest4ComboBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Guest 4";
            // 
            // Guest3ComboBox
            // 
            this.Guest3ComboBox.FormattingEnabled = true;
            this.Guest3ComboBox.Items.AddRange(new object[] {
            "STEPH MORRISON",
            "EVAN MORRISON",
            "TY TREMBLAY",
            "DAVID McLAUGHLIN",
            "FRANCIS O\'ROURKE",
            "NAVID SHAFA"});
            this.Guest3ComboBox.Location = new System.Drawing.Point(72, 127);
            this.Guest3ComboBox.Name = "Guest3ComboBox";
            this.Guest3ComboBox.Size = new System.Drawing.Size(176, 21);
            this.Guest3ComboBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Guest 3";
            // 
            // Guest2ComboBox
            // 
            this.Guest2ComboBox.FormattingEnabled = true;
            this.Guest2ComboBox.Items.AddRange(new object[] {
            "STEPH MORRISON",
            "EVAN MORRISON",
            "TY TREMBLAY",
            "DAVID McLAUGHLIN",
            "FRANCIS O\'ROURKE",
            "NAVID SHAFA"});
            this.Guest2ComboBox.Location = new System.Drawing.Point(72, 100);
            this.Guest2ComboBox.Name = "Guest2ComboBox";
            this.Guest2ComboBox.Size = new System.Drawing.Size(176, 21);
            this.Guest2ComboBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Guest 2";
            // 
            // Guest1ComboBox
            // 
            this.Guest1ComboBox.FormattingEnabled = true;
            this.Guest1ComboBox.Items.AddRange(new object[] {
            "STEPH MORRISON",
            "EVAN MORRISON",
            "TY TREMBLAY",
            "DAVID McLAUGHLIN",
            "FRANCIS O\'ROURKE",
            "NAVID SHAFA"});
            this.Guest1ComboBox.Location = new System.Drawing.Point(72, 73);
            this.Guest1ComboBox.Name = "Guest1ComboBox";
            this.Guest1ComboBox.Size = new System.Drawing.Size(176, 21);
            this.Guest1ComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Guest 1";
            // 
            // Host2ComboBox
            // 
            this.Host2ComboBox.FormattingEnabled = true;
            this.Host2ComboBox.Items.AddRange(new object[] {
            "STEPH MORRISON",
            "EVAN MORRISON",
            "TY TREMBLAY",
            "DAVID McLAUGHLIN",
            "FRANCIS O\'ROURKE",
            "NAVID SHAFA"});
            this.Host2ComboBox.Location = new System.Drawing.Point(72, 46);
            this.Host2ComboBox.Name = "Host2ComboBox";
            this.Host2ComboBox.Size = new System.Drawing.Size(176, 21);
            this.Host2ComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Host 2";
            // 
            // Host1ComboBox
            // 
            this.Host1ComboBox.FormattingEnabled = true;
            this.Host1ComboBox.Items.AddRange(new object[] {
            "STEPH MORRISON",
            "EVAN MORRISON",
            "TY TREMBLAY",
            "DAVID McLAUGHLIN",
            "FRANCIS O\'ROURKE",
            "NAVID SHAFA"});
            this.Host1ComboBox.Location = new System.Drawing.Point(72, 19);
            this.Host1ComboBox.Name = "Host1ComboBox";
            this.Host1ComboBox.Size = new System.Drawing.Size(176, 21);
            this.Host1ComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host 1";
            // 
            // questionsTab
            // 
            this.questionsTab.Controls.Add(this.dataGridView2);
            this.questionsTab.Controls.Add(this.dataGridView1);
            this.questionsTab.Controls.Add(this.label11);
            this.questionsTab.Controls.Add(this.label10);
            this.questionsTab.Controls.Add(this.clearQuestionButton);
            this.questionsTab.Controls.Add(this.clearQuestionsButton);
            this.questionsTab.Controls.Add(this.manualQuestionButton);
            this.questionsTab.Controls.Add(this.groupBox2);
            this.questionsTab.Controls.Add(this.groupBox1);
            this.questionsTab.Location = new System.Drawing.Point(4, 22);
            this.questionsTab.Name = "questionsTab";
            this.questionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.questionsTab.Size = new System.Drawing.Size(1115, 414);
            this.questionsTab.TabIndex = 2;
            this.questionsTab.Text = "Questions";
            this.questionsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(665, 42);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(444, 366);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView2_MouseDown);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(210, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 366);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(851, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "QUEUE";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(394, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "POOL";
            // 
            // clearQuestionButton
            // 
            this.clearQuestionButton.Location = new System.Drawing.Point(6, 186);
            this.clearQuestionButton.Name = "clearQuestionButton";
            this.clearQuestionButton.Size = new System.Drawing.Size(190, 28);
            this.clearQuestionButton.TabIndex = 0;
            this.clearQuestionButton.Text = "Clear Question from Screen";
            this.clearQuestionButton.UseVisualStyleBackColor = true;
            this.clearQuestionButton.Click += new System.EventHandler(this.clearQuestionButton_Click);
            // 
            // clearQuestionsButton
            // 
            this.clearQuestionsButton.Location = new System.Drawing.Point(8, 383);
            this.clearQuestionsButton.Name = "clearQuestionsButton";
            this.clearQuestionsButton.Size = new System.Drawing.Size(190, 28);
            this.clearQuestionsButton.TabIndex = 0;
            this.clearQuestionsButton.Text = "Clear All Questions";
            this.clearQuestionsButton.UseVisualStyleBackColor = true;
            this.clearQuestionsButton.Click += new System.EventHandler(this.clearQuestionsButton_Click);
            // 
            // manualQuestionButton
            // 
            this.manualQuestionButton.Location = new System.Drawing.Point(8, 140);
            this.manualQuestionButton.Name = "manualQuestionButton";
            this.manualQuestionButton.Size = new System.Drawing.Size(190, 40);
            this.manualQuestionButton.TabIndex = 0;
            this.manualQuestionButton.Text = "Add Manual Question";
            this.manualQuestionButton.UseVisualStyleBackColor = true;
            this.manualQuestionButton.Click += new System.EventHandler(this.manualQuestionButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.twitterHashtagBox);
            this.groupBox2.Controls.Add(this.twitterGetQuestionsButton);
            this.groupBox2.Location = new System.Drawing.Point(8, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 71);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Twitter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "#";
            // 
            // twitterHashtagBox
            // 
            this.twitterHashtagBox.Location = new System.Drawing.Point(32, 16);
            this.twitterHashtagBox.Name = "twitterHashtagBox";
            this.twitterHashtagBox.Size = new System.Drawing.Size(152, 20);
            this.twitterHashtagBox.TabIndex = 0;
            // 
            // twitterGetQuestionsButton
            // 
            this.twitterGetQuestionsButton.Location = new System.Drawing.Point(7, 39);
            this.twitterGetQuestionsButton.Name = "twitterGetQuestionsButton";
            this.twitterGetQuestionsButton.Size = new System.Drawing.Size(177, 23);
            this.twitterGetQuestionsButton.TabIndex = 1;
            this.twitterGetQuestionsButton.Text = "Get Questions";
            this.twitterGetQuestionsButton.UseVisualStyleBackColor = true;
            this.twitterGetQuestionsButton.Click += new System.EventHandler(this.twitterGetQuestionsButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.twitchGetQuestionsButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Twitch";
            // 
            // twitchGetQuestionsButton
            // 
            this.twitchGetQuestionsButton.Location = new System.Drawing.Point(6, 19);
            this.twitchGetQuestionsButton.Name = "twitchGetQuestionsButton";
            this.twitchGetQuestionsButton.Size = new System.Drawing.Size(178, 23);
            this.twitchGetQuestionsButton.TabIndex = 0;
            this.twitchGetQuestionsButton.Text = "Start Getting Questions";
            this.twitchGetQuestionsButton.UseVisualStyleBackColor = true;
            this.twitchGetQuestionsButton.Click += new System.EventHandler(this.twitchGetQuestionsButton_Click);
            // 
            // splashTab
            // 
            this.splashTab.Controls.Add(this.label9);
            this.splashTab.Controls.Add(this.label8);
            this.splashTab.Controls.Add(this.splashBottomBox);
            this.splashTab.Controls.Add(this.splashTopBox);
            this.splashTab.Location = new System.Drawing.Point(4, 22);
            this.splashTab.Name = "splashTab";
            this.splashTab.Padding = new System.Windows.Forms.Padding(3);
            this.splashTab.Size = new System.Drawing.Size(1115, 414);
            this.splashTab.TabIndex = 3;
            this.splashTab.Text = "Splash";
            this.splashTab.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Bottom";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Top";
            // 
            // splashBottomBox
            // 
            this.splashBottomBox.Location = new System.Drawing.Point(21, 84);
            this.splashBottomBox.Name = "splashBottomBox";
            this.splashBottomBox.Size = new System.Drawing.Size(630, 20);
            this.splashBottomBox.TabIndex = 1;
            // 
            // splashTopBox
            // 
            this.splashTopBox.Location = new System.Drawing.Point(21, 27);
            this.splashTopBox.Name = "splashTopBox";
            this.splashTopBox.Size = new System.Drawing.Size(630, 20);
            this.splashTopBox.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editrToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editrToolStripMenuItem
            // 
            this.editrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editrToolStripMenuItem.Name = "editrToolStripMenuItem";
            this.editrToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editrToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // masterPublishButton
            // 
            this.masterPublishButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.masterPublishButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(179)))));
            this.masterPublishButton.Font = new System.Drawing.Font("Futura LT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterPublishButton.ForeColor = System.Drawing.Color.White;
            this.masterPublishButton.Location = new System.Drawing.Point(4, 29);
            this.masterPublishButton.Name = "masterPublishButton";
            this.masterPublishButton.Size = new System.Drawing.Size(1119, 40);
            this.masterPublishButton.TabIndex = 0;
            this.masterPublishButton.Text = "PUBLISH";
            this.masterPublishButton.UseVisualStyleBackColor = false;
            this.masterPublishButton.Click += new System.EventHandler(this.masterPublishButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 517);
            this.Controls.Add(this.masterPublishButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BTL Helper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.castersTab.ResumeLayout(false);
            this.castersTab.PerformLayout();
            this.questionsTab.ResumeLayout(false);
            this.questionsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.splashTab.ResumeLayout(false);
            this.splashTab.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage castersTab;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editrToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Host2ComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Host1ComboBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button masterPublishButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox Guest2ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Guest1ComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Guest4ComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Guest3ComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage questionsTab;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button twitchGetQuestionsButton;
        private System.Windows.Forms.Button manualQuestionButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button twitterGetQuestionsButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox twitterHashtagBox;
        private System.Windows.Forms.Button clearQuestionsButton;
        private System.Windows.Forms.TabPage splashTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox splashBottomBox;
        private System.Windows.Forms.TextBox splashTopBox;
        private System.Windows.Forms.Button clearQuestionButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;

    }
}

