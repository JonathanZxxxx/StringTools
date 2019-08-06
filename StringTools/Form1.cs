﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }

        private void ExcuteButton_Click(object sender, EventArgs e)
        {
            var input = InputTextBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("请输入处理文本！");
                return;
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
            //连接字符
            if (string.IsNullOrWhiteSpace(JoinBox.Text))
            {
                MessageBox.Show("请输入连接字符！");
                return;
            }
            var joinString = string.Join(JoinBox.Text, stringList);
            OutputTextBox.Text = joinString;
        }

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
            }
        }
    }
}
