using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class delForm : Form
    {
        private string FindId;
        string FindName;

        public string FindName1
        {
            get { return FindName; }
            set { FindName = value; }
        }
        public string FindId1
        {
            get { return FindId; }
            set { FindId = value; }
        }
        string textBox1value;

        public string TextBox1value
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        string textBox2value;

        public string TextBox2value
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
        public event EventHandler ButtonClik;        
        public delForm()
        {
            InitializeComponent();
        }
        void kjclean()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (ButtonClik != null)
                ButtonClik(this, e);
            if (FindId1 == "" && FindName1 == "")
            {
                MessageBox.Show("请输入数据");
            }
            else
            {
                FindId1 = TextBox1value;
                FindName1 = TextBox2value;
            }
            kjclean();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void delForm_Load(object sender, EventArgs e)
        {
            button2.DialogResult = DialogResult.OK;
        }

    }

}
