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
            kjclean();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

    }

}
