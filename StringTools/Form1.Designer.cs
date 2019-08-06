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
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(23, 46);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(53, 12);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "输入文本";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(92, 12);
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
            this.OutputTextBox.Location = new System.Drawing.Point(92, 186);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(294, 117);
            this.OutputTextBox.TabIndex = 4;
            this.OutputTextBox.Text = "";
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(23, 234);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(53, 12);
            this.OutputLabel.TabIndex = 5;
            this.OutputLabel.Text = "输出文本";
            // 
            // SplitComboBox
            // 
            this.SplitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SplitComboBox.FormattingEnabled = true;
            this.SplitComboBox.Location = new System.Drawing.Point(497, 38);
            this.SplitComboBox.Name = "SplitComboBox";
            this.SplitComboBox.Size = new System.Drawing.Size(121, 20);
            this.SplitComboBox.TabIndex = 6;
            this.SplitComboBox.SelectedIndexChanged += new System.EventHandler(this.SplitComboBox_SelectedIndexChanged);
            // 
            // SplitLabel
            // 
            this.SplitLabel.AutoSize = true;
            this.SplitLabel.Location = new System.Drawing.Point(429, 41);
            this.SplitLabel.Name = "SplitLabel";
            this.SplitLabel.Size = new System.Drawing.Size(53, 12);
            this.SplitLabel.TabIndex = 7;
            this.SplitLabel.Text = "分割字符";
            // 
            // SplitBox
            // 
            this.SplitBox.Location = new System.Drawing.Point(647, 37);
            this.SplitBox.Name = "SplitBox";
            this.SplitBox.Size = new System.Drawing.Size(100, 21);
            this.SplitBox.TabIndex = 8;
            // 
            // JoinLabel
            // 
            this.JoinLabel.AutoSize = true;
            this.JoinLabel.Location = new System.Drawing.Point(429, 87);
            this.JoinLabel.Name = "JoinLabel";
            this.JoinLabel.Size = new System.Drawing.Size(53, 12);
            this.JoinLabel.TabIndex = 9;
            this.JoinLabel.Text = "连接字符";
            // 
            // JoinBox
            // 
            this.JoinBox.Location = new System.Drawing.Point(497, 84);
            this.JoinBox.Name = "JoinBox";
            this.JoinBox.Size = new System.Drawing.Size(100, 21);
            this.JoinBox.TabIndex = 10;
            this.JoinBox.Text = ",";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "MainForm";
            this.Text = "字符串处理小工具";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

