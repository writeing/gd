using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using WindowsFormsApplication1.database;
using WindowsFormsApplication1.user;
namespace WindowsFormsApplication1
{
    public partial class recordBaseForm : Form
    {

        public static mongoDB db = new mongoDB();
        public static MongoCollection conn = db.getdataConn();
        
        private string[] record = new string[]{"base"};
        private string labelText;
        private int index;
        public string strIndex;
        public int Index
        {
            get { return comboBox1.SelectedIndex; }
            set { comboBox1.SelectedIndex = value; }
        }
        public string LabelText
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string[] Record
        {
            get { return record; }
            set { record = value; }
        }
        public recordBaseForm()
        {
            InitializeComponent();
        }

        private void recordBaseForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(record);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            strIndex = comboBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

    }
}
