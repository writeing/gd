using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.database;
using WindowsFormsApplication1.user;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApplication1
{
    public partial class databaseForm : Form
    {
        public static mongoDB db = new mongoDB();
        public static MongoCollection conn = db.getdataConn();        
        private string strInputText;
        string strInputGrade;
        public int textindex;

        public int Textindex
        {
            get { return comboBox1.SelectedIndex; }
            set { textindex = value; }
        }
        public int gradeindex;

        public int Gradeindex
        {
            get { return comboBox2.SelectedIndex; }
            set { gradeindex = value; }
        }
        public string StrInputGrade
        {
            get { return comboBox2.Text; }
            set { comboBox2.Text = value; }
        }
        public string StrInputText
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }
        public void Insertbase()
        {
            var query = new QueryDocument { { "ID", "0" } };
            var result = conn.FindAs<dataUser>(query);
            if (result.Count() == 0)
            {
                dataUser user = new dataUser();
                conn.Insert<dataUser>(user);
            }
        }
        public databaseForm()
        {
            Insertbase();
            InitializeComponent();
        }
        public void setComText(string[] text)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(text);
        }
        public void setComGrade(string[] text)
        {
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(text);
        }
        private void databaseForm_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = comboBox1.SelectedIndex;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox2.SelectedIndex;
        }
    }
}
