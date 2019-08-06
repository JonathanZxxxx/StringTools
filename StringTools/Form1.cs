using System;
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
            selectDic.Add(3, "输入字符");
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = selectDic;
            SplitComboBox.DataSource = bindingSource;
            SplitComboBox.ValueMember = "Key";
            SplitComboBox.DisplayMember = "Value";
        }

        private void ExcuteButton_Click(object sender, EventArgs e)
        {
            var a = InputTextBox.Text;
            OutputTextBox.Text = a;
        }

        private void SplitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var select = SplitComboBox.SelectedValue;
            if (select.GetType().Name == "Int32" && (int)select == 3)
            {
                SplitBox.Show();
            }
        }
    }
}
