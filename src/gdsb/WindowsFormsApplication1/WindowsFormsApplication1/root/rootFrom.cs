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
using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.VisualBasic;
//microsoft.visualbasic

namespace WindowsFormsApplication1.root
{
    public partial class rootFrom : Form
    {
        string returnValue = null;
        int flag = 1;
        public User addUser;
        public rootFrom()
        {
            InitializeComponent();

        }
        public rootFrom(bool change):this()
        {
            if(change == true)
            {                
                this.changeValue();
                this.showDB();
            }

        }
        public void showDB()
        {            
            this.returnValue = Interaction.InputBox("提示", "请输入用户的ID", "please input user ID", 100, 100);
            if (returnValue == "")
            {
                flag = 0;                
                //MessageBox.Show("你真的是空？"+returnValue);
                //this.returnValue = Interaction.InputBox("提示", "请输入用户的ID", "please input user ID", 100, 100);
            }
            else
            {
                this.seachUser(this.returnValue, true);
            }


                        
        }
        public void changeValue()
        {
            button1.Text = "修 改";
            rtbShowmdb.Hide();
        }
        private void cleanKJ()
        {
            tbName.Clear();
            tbID.Clear();
            tbAge.Clear();
            maskedTextBox1.Clear();
            tbGrade.Clear();
            tbgz.Clear();
            textBox4.Clear();
            tbClassed.Clear();
            tbTel.Clear();
            tbCard.Clear();
            tbAdress.Clear();
            maskedTextBox3.Clear();
            cbbXl.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            tbjxmeney.Clear();
            comboBox3.Text = "";
        }
        private void seachUser(string ID,bool showCox=false)
        {
            mongoDB db = new mongoDB();
            MongoCollection conn = db.getConn();
            var query = new QueryDocument { { "ID", ID } };
            var result = conn.FindAs<User>(query);
            
            if (showCox == false)
            {
                for (long oc = 0; oc < result.Count(); oc++)
                {
                    User userfind = result.ElementAtOrDefault<User>(Convert.ToInt32(oc));
                    string str = "";
                    str += userfind.ID;
                    str += '\n';
                    str += userfind.Zhiwei;
                    str += '\n';
                    str += userfind.Password;
                    str += '\n';
                    str += userfind.name;
                    str += '\n';
                    str += userfind.Xl;
                    str += '\n';
                    str += userfind.NumID;
                    str += '\n';
                    foreach (string cl in userfind.Classed)
                    {
                        str += cl;
                        str += '\n';
                    }
                    rtbShowmdb.AppendText(str);
                }                
            }
            else
            {
                if(result.Count() == 0)
                {
                    MessageBox.Show("not found the ID");
                    flag = 0;
                }
                else
                {
                    
                    for (int oc = 0; oc < result.Count(); oc++)
                    {
                        User userfind = result.ElementAt<User>(0);
                        tbName.Text = userfind.name;
                        tbID.Text = userfind.ID;
                        tbAge.Text = userfind.Age;
                        tbTel.Text = userfind.Tel;
                        maskedTextBox1.Text = userfind.TimeComeStu;
                        cbbXl.Text = userfind.Xl;
                        tbCard.Text = userfind.NumID;
                        tbAdress.Text = userfind.Address;
                        maskedTextBox3.Text = userfind.Birth;
                        comboBox1.Text = userfind.Zhiwei;
                        tbGrade.Text = userfind.grade;
                        tbgz.Text = userfind.Money;
                        tbjxmeney.Text = userfind.Jxmoney;
                        tbClassed.Text = userfind.Bzrclass;
                        comboBox2.Text = userfind.Sub;
                        comboBox3.Text = userfind.Bgs;
                        string comclass = userfind.Classed[0];
                        for (int i = 1; userfind.Classed.Length>1&&i < userfind.Classed.Length; i++)
                        {
                            comclass += ',' + userfind.Classed[i];
                        }
                        tbClassed.Text = comclass;
                    }
                    conn.Remove(query);
                }
                
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            mongoDB db = new mongoDB();
            MongoCollection conn = db.getConn();
           
            string name = tbName.Text;
            string ID = tbID.Text;
            string age = tbAge.Text;
            string rzTime = maskedTextBox1.Text;
            
            if (maskedTextBox1.Text.Equals(""))
            {
                rzTime = DateTime.Now.ToLongDateString();
            }            
            string renTime = (DateTime.Now.Year - int.Parse(rzTime.Substring(0, 4))).ToString();

            string grade = tbGrade.Text;
            string money = tbgz.Text;
            string zhiwei = comboBox1.Text;
            string bzrClassed = null;
            string xl = cbbXl.Text;
            string tel = tbTel.Text;
            string xjmoney = tbjxmeney.Text;
            string address = tbAdress.Text;
            string bgs = comboBox3.Text;
            string sex = comboBox4.Text;
            if (comboBox1.Text == "班主任")
            {
                bzrClassed = textBox4.Text;
            }
            string[] classed = tbClassed.Text.Split(',');
            string bzrclass = textBox4.Text;
            string numid = tbCard.Text;
            string sub = comboBox2.Text;
            string brith = maskedTextBox3.Text;


            User user = new User();
            user.Age = age;
            user.ID = ID;
            user.name = name;
            user.TimeRuzhi = renTime;
            user.grade = grade;
            user.TimeComeStu = rzTime;
            user.Zhiwei = zhiwei;
            user.Bzrclass = bzrClassed;
            user.Classed = classed;
            user.Money = money;
            user.Tel = tel;
            user.Xl = xl;
            user.Jxmoney = xjmoney;
            user.Address = address;
            user.Bzrclass = bzrclass;
            user.NumID = numid;
            user.Sub = sub;
            user.Birth = brith;
            user.Bgs = bgs;
            user.Sex = sex;
            user.Reward = new string[] { };
            user.Punish = new string[] { };
            var query = new QueryDocument { { "ID", ID } };
            var result = conn.FindAs<User>(query);
            if(result.Count()!=0)
            {
                MessageBox.Show("此ID已经存在了");
            }
            else
            {
                conn.Insert<User>(user);
                seachUser(ID);
                cleanKJ();
                if (MessageBox.Show("插入成功,是否退出?","提示", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                {
                    return;
                }
            }
            addUser = user;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void rootFrom_Load(object sender, EventArgs e)
        {
            label1.Hide();
            textBox4.Hide();
            if (flag == 0)
            {
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "班主任")
            {
                label1.Show();
                textBox4.Show();
            }
            else
            {
                label1.Hide();
                textBox4.Hide();
            }
            
        }
    }
}
