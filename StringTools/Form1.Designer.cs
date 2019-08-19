namespace StringTools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.RichTextBox();
            this.ExcuteButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SplitComboBox = new System.Windows.Forms.ComboBox();
            this.SplitLabel = new System.Windows.Forms.Label();
            this.SplitBox = new System.Windows.Forms.TextBox();
            this.JoinLabel = new System.Windows.Forms.Label();
            this.JoinBox = new System.Windows.Forms.TextBox();
            this.BeforeCheckBox = new System.Windows.Forms.CheckBox();
            this.BeforeTextBox = new System.Windows.Forms.TextBox();
            this.BackTextBox = new System.Windows.Forms.TextBox();
            this.BackCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AboutMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.作者ZhengXinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.邮箱zxjndxoutlookcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubJonathanZxxxxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloghttpswwwcnblogscomzxxxxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.版本号V11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.v11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCheckBox = new System.Windows.Forms.CheckBox();
            this.DeleteTextBox = new System.Windows.Forms.TextBox();
            this.RegexCheckBox = new System.Windows.Forms.CheckBox();
            this.RegexTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(22, 75);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(53, 12);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "输入文本";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(91, 41);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(294, 108);
            this.InputTextBox.TabIndex = 2;
            this.InputTextBox.Text = "";
            // 
            // ExcuteButton
            // 
            this.ExcuteButton.Location = new System.Drawing.Point(55, 389);
            this.ExcuteButton.Name = "ExcuteButton";
            this.ExcuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExcuteButton.TabIndex = 3;
            this.ExcuteButton.Text = "执行";
            this.ExcuteButton.UseVisualStyleBackColor = true;
            this.ExcuteButton.Click += new System.EventHandler(this.ExcuteButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(91, 215);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(294, 117);
            this.OutputTextBox.TabIndex = 4;
            this.OutputTextBox.Text = "";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(22, 263);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(53, 12);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "输出文本";
            // 
            // SplitComboBox
            // 
            this.SplitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SplitComboBox.FormattingEnabled = true;
            this.SplitComboBox.Location = new System.Drawing.Point(496, 67);
            this.SplitComboBox.Name = "SplitComboBox";
            this.SplitComboBox.Size = new System.Drawing.Size(121, 20);
            this.SplitComboBox.TabIndex = 6;
            this.SplitComboBox.SelectedIndexChanged += new System.EventHandler(this.SplitComboBox_SelectedIndexChanged);
            // 
            // SplitLabel
            // 
            this.SplitLabel.AutoSize = true;
            this.SplitLabel.Location = new System.Drawing.Point(428, 70);
            this.SplitLabel.Name = "SplitLabel";
            this.SplitLabel.Size = new System.Drawing.Size(53, 12);
            this.SplitLabel.TabIndex = 7;
            this.SplitLabel.Text = "分割字符";
            // 
            // SplitBox
            // 
            this.SplitBox.Location = new System.Drawing.Point(646, 66);
            this.SplitBox.Name = "SplitBox";
            this.SplitBox.Size = new System.Drawing.Size(100, 21);
            this.SplitBox.TabIndex = 8;
            // 
            // JoinLabel
            // 
            this.JoinLabel.AutoSize = true;
            this.JoinLabel.Location = new System.Drawing.Point(428, 116);
            this.JoinLabel.Name = "JoinLabel";
            this.JoinLabel.Size = new System.Drawing.Size(53, 12);
            this.JoinLabel.TabIndex = 9;
            this.JoinLabel.Text = "连接字符";
            // 
            // JoinBox
            // 
            this.JoinBox.Location = new System.Drawing.Point(496, 113);
            this.JoinBox.Name = "JoinBox";
            this.JoinBox.Size = new System.Drawing.Size(100, 21);
            this.JoinBox.TabIndex = 10;
            this.JoinBox.Text = ",";
            // 
            // BeforeCheckBox
            // 
            this.BeforeCheckBox.AutoSize = true;
            this.BeforeCheckBox.Location = new System.Drawing.Point(430, 162);
            this.BeforeCheckBox.Name = "BeforeCheckBox";
            this.BeforeCheckBox.Size = new System.Drawing.Size(72, 16);
            this.BeforeCheckBox.TabIndex = 12;
            this.BeforeCheckBox.Text = "前面新增";
            this.BeforeCheckBox.UseVisualStyleBackColor = true;
            this.BeforeCheckBox.CheckedChanged += new System.EventHandler(this.BeforeCheckBox_CheckedChanged);
            // 
            // BeforeTextBox
            // 
            this.BeforeTextBox.Location = new System.Drawing.Point(517, 162);
            this.BeforeTextBox.Name = "BeforeTextBox";
            this.BeforeTextBox.Size = new System.Drawing.Size(100, 21);
            this.BeforeTextBox.TabIndex = 13;
            // 
            // BackTextBox
            // 
            this.BackTextBox.Location = new System.Drawing.Point(517, 213);
            this.BackTextBox.Name = "BackTextBox";
            this.BackTextBox.Size = new System.Drawing.Size(100, 21);
            this.BackTextBox.TabIndex = 15;
            // 
            // BackCheckBox
            // 
            this.BackCheckBox.AutoSize = true;
            this.BackCheckBox.Location = new System.Drawing.Point(430, 213);
            this.BackCheckBox.Name = "BackCheckBox";
            this.BackCheckBox.Size = new System.Drawing.Size(72, 16);
            this.BackCheckBox.TabIndex = 14;
            this.BackCheckBox.Text = "后面新增";
            this.BackCheckBox.UseVisualStyleBackColor = true;
            this.BackCheckBox.CheckedChanged += new System.EventHandler(this.BackCheckBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuButton,
            this.版本号V11ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AboutMenuButton
            // 
            this.AboutMenuButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AboutMenuButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.作者ZhengXinToolStripMenuItem,
            this.邮箱zxjndxoutlookcomToolStripMenuItem,
            this.gitHubJonathanZxxxxToolStripMenuItem,
            this.bloghttpswwwcnblogscomzxxxxToolStripMenuItem});
            this.AboutMenuButton.Name = "AboutMenuButton";
            this.AboutMenuButton.Size = new System.Drawing.Size(44, 21);
            this.AboutMenuButton.Text = "关于";
            // 
            // 作者ZhengXinToolStripMenuItem
            // 
            this.作者ZhengXinToolStripMenuItem.Name = "作者ZhengXinToolStripMenuItem";
            this.作者ZhengXinToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.作者ZhengXinToolStripMenuItem.Text = "作者:ZhengXin";
            // 
            // 邮箱zxjndxoutlookcomToolStripMenuItem
            // 
            this.邮箱zxjndxoutlookcomToolStripMenuItem.Name = "邮箱zxjndxoutlookcomToolStripMenuItem";
            this.邮箱zxjndxoutlookcomToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.邮箱zxjndxoutlookcomToolStripMenuItem.Text = "邮箱:zxjndx@outlook.com";
            // 
            // gitHubJonathanZxxxxToolStripMenuItem
            // 
            this.gitHubJonathanZxxxxToolStripMenuItem.Name = "gitHubJonathanZxxxxToolStripMenuItem";
            this.gitHubJonathanZxxxxToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.gitHubJonathanZxxxxToolStripMenuItem.Text = "GitHub:JonathanZxxxx";
            // 
            // bloghttpswwwcnblogscomzxxxxToolStripMenuItem
            // 
            this.bloghttpswwwcnblogscomzxxxxToolStripMenuItem.Name = "bloghttpswwwcnblogscomzxxxxToolStripMenuItem";
            this.bloghttpswwwcnblogscomzxxxxToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.bloghttpswwwcnblogscomzxxxxToolStripMenuItem.Text = "Blog:https://www.cnblogs.com/zxxxx";
            // 
            // 版本号V11ToolStripMenuItem
            // 
            this.版本号V11ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.版本号V11ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v11ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.版本号V11ToolStripMenuItem.Name = "版本号V11ToolStripMenuItem";
            this.版本号V11ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.版本号V11ToolStripMenuItem.Text = "版本信息";
            // 
            // v11ToolStripMenuItem
            // 
            this.v11ToolStripMenuItem.Name = "v11ToolStripMenuItem";
            this.v11ToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.v11ToolStripMenuItem.Text = "版本号:V3.0";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(212, 22);
            this.toolStripMenuItem2.Text = "发布日期:2019年8月19日";
            // 
            // DeleteCheckBox
            // 
            this.DeleteCheckBox.AutoSize = true;
            this.DeleteCheckBox.Location = new System.Drawing.Point(430, 258);
            this.DeleteCheckBox.Name = "DeleteCheckBox";
            this.DeleteCheckBox.Size = new System.Drawing.Size(72, 16);
            this.DeleteCheckBox.TabIndex = 17;
            this.DeleteCheckBox.Text = "删除字符";
            this.DeleteCheckBox.UseVisualStyleBackColor = true;
            this.DeleteCheckBox.CheckedChanged += new System.EventHandler(this.DeleteCheckBox_CheckedChanged);
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(517, 256);
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(100, 21);
            this.DeleteTextBox.TabIndex = 18;
            // 
            // RegexCheckBox
            // 
            this.RegexCheckBox.AutoSize = true;
            this.RegexCheckBox.Location = new System.Drawing.Point(430, 300);
            this.RegexCheckBox.Name = "RegexCheckBox";
            this.RegexCheckBox.Size = new System.Drawing.Size(108, 16);
            this.RegexCheckBox.TabIndex = 19;
            this.RegexCheckBox.Text = "匹配正则表达式";
            this.RegexCheckBox.UseVisualStyleBackColor = true;
            this.RegexCheckBox.CheckedChanged += new System.EventHandler(this.RegexCheckBox_CheckedChanged);
            // 
            // RegexTextBox
            // 
            this.RegexTextBox.Location = new System.Drawing.Point(544, 298);
            this.RegexTextBox.Name = "RegexTextBox";
            this.RegexTextBox.Size = new System.Drawing.Size(100, 21);
            this.RegexTextBox.TabIndex = 20;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RegexTextBox);
            this.Controls.Add(this.RegexCheckBox);
            this.Controls.Add(this.DeleteTextBox);
            this.Controls.Add(this.DeleteCheckBox);
            this.Controls.Add(this.BackTextBox);
            this.Controls.Add(this.BackCheckBox);
            this.Controls.Add(this.BeforeTextBox);
            this.Controls.Add(this.BeforeCheckBox);
            this.Controls.Add(this.JoinBox);
            this.Controls.Add(this.JoinLabel);
            this.Controls.Add(this.SplitBox);
            this.Controls.Add(this.SplitLabel);
            this.Controls.Add(this.SplitComboBox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.ExcuteButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "字符串处理小工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.RichTextBox InputTextBox;
        private System.Windows.Forms.Button ExcuteButton;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.ComboBox SplitComboBox;
        private System.Windows.Forms.Label SplitLabel;
        private System.Windows.Forms.TextBox SplitBox;
        private System.Windows.Forms.Label JoinLabel;
        private System.Windows.Forms.TextBox JoinBox;
        private System.Windows.Forms.CheckBox BeforeCheckBox;
        private System.Windows.Forms.TextBox BeforeTextBox;
        private System.Windows.Forms.TextBox BackTextBox;
        private System.Windows.Forms.CheckBox BackCheckBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuButton;
        private System.Windows.Forms.ToolStripMenuItem 作者ZhengXinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 邮箱zxjndxoutlookcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gitHubJonathanZxxxxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloghttpswwwcnblogscomzxxxxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 版本号V11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem v11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.CheckBox DeleteCheckBox;
        private System.Windows.Forms.TextBox DeleteTextBox;
        private System.Windows.Forms.CheckBox RegexCheckBox;
        private System.Windows.Forms.TextBox RegexTextBox;
    }
}

