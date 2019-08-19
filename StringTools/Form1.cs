using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringTools
{
    public partial class MainForm : Form
    {
        Function function = new Function();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;    //最大化窗体 
            SplitBox.Hide();
            var selectDic = new Dictionary<int, string>();
            selectDic.Add(0, "换行符");
            selectDic.Add(1, "空格");
            selectDic.Add(2, "输入字符");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = selectDic;
            SplitComboBox.DataSource = bindingSource;
            SplitComboBox.ValueMember = "Key";
            SplitComboBox.DisplayMember = "Value";
            BeforeTextBox.Hide();
            BackTextBox.Hide();
            DeleteTextBox.Hide();
            RegexTextBox.Hide();
        }

        private void ExcuteButton_Click(object sender, EventArgs e)
        {
            var input = InputTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("请输入处理文本！");
                return;
            }
            //正则表达式
            if (RegexCheckBox.Checked)
            {
                if (string.IsNullOrWhiteSpace(RegexTextBox.Text))
                {
                    MessageBox.Show("请输入正则表达式！");
                    return;
                }
                try
                {
                    var regexStr = Regex.Match(input, RegexTextBox.Text);
                    OutputTextBox.Text = regexStr.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error,{ex.ToString()}");
                    return;
                }
            }
            else
            {
                //删除特定字符
                if (DeleteCheckBox.Checked)
                {
                    if (string.IsNullOrWhiteSpace(DeleteTextBox.Text))
                    {
                        MessageBox.Show("请输入删除字符！");
                        return;
                    }
                    input = input.Replace(DeleteTextBox.Text, "");
                }
                var select = (int)SplitComboBox.SelectedValue;
                //分割字符
                if (select == 2)
                {
                    if (string.IsNullOrWhiteSpace(SplitBox.Text))
                    {
                        MessageBox.Show("请输入分割字符！");
                        return;
                    }
                    if (SplitBox.Text.Length > 1)
                    {
                        MessageBox.Show("分割字符长度只能为1！");
                        return;
                    }
                }
                var stringList = function.SplitString(input, select, SplitBox.Text);
                //前后新增字符串
                if (BeforeCheckBox.Checked && string.IsNullOrWhiteSpace(BeforeTextBox.Text))
                {
                    MessageBox.Show("请输入前面新增字符串！");
                    return;
                }
                if (BackCheckBox.Checked && string.IsNullOrWhiteSpace(BackTextBox.Text))
                {
                    MessageBox.Show("请输入前面新增字符串！");
                    return;
                }
                for (int i = 0; i < stringList.Count; i++)
                {
                    if (BeforeCheckBox.Checked)
                    {
                        stringList[i] = BeforeTextBox.Text + stringList[i];
                    }
                    if (BackCheckBox.Checked)
                    {
                        stringList[i] = stringList[i] + BackTextBox.Text;
                    }
                }
                //连接字符
                if (string.IsNullOrWhiteSpace(JoinBox.Text))
                {
                    MessageBox.Show("请输入连接字符！");
                    return;
                }
                var joinString = string.Join(JoinBox.Text, stringList);
                OutputTextBox.Text = joinString;
            }
        }

        /// <summary>
        /// 分割字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select = SplitComboBox.SelectedValue;
            if (select.GetType().Name == "Int32" && (int)select == 2)
            {
                SplitBox.Show();
            }
            else
            {
                SplitBox.Hide();
                SplitBox.Text = "";
            }
        }

        /// <summary>
        /// 前面新增字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BeforeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BeforeCheckBox.Checked)
            {
                BeforeTextBox.Show();
            }
            else
            {
                BeforeTextBox.Hide();
                BeforeTextBox.Text = "";
            }
        }

        /// <summary>
        /// 后面新增字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BackCheckBox.Checked)
            {
                BackTextBox.Show();
            }
            else
            {
                BackTextBox.Hide();
                BackTextBox.Text = "";
            }
        }

        /// <summary>
        /// 删除特定字符
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DeleteCheckBox.Checked)
            {
                DeleteTextBox.Show();
            }
            else
            {
                DeleteTextBox.Hide();
                DeleteTextBox.Text = "";
            }
        }

        /// <summary>
        /// 正则表达式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegexCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RegexCheckBox.Checked)
            {
                RegexTextBox.Show();
            }
            else
            {
                RegexTextBox.Hide();
                RegexTextBox.Text = "";
            }
        }
    }
}
