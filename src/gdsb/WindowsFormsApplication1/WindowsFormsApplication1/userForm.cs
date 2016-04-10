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
using WindowsFormsApplication1.user;
using WindowsFormsApplication1.root;
using WindowsFormsApplication1;
using Microsoft.VisualBasic;
using WindowsFormsApplication1.database;
namespace WindowsFormsApplication1
{
    public partial class userForm : Form
    {
        public User user;
        public userForm()
        {
            InitializeComponent();
        }
        public userForm(User user)
        {
            this.user = user;
            InitializeComponent();
        }
        private void showRich(User user)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("ID：" + user.ID + "\n");
            richTextBox1.AppendText("姓名：" + user.name + "\n");
            richTextBox1.AppendText("性别：" + user.Sex + "\n");
            richTextBox1.AppendText("身份证：" + user.NumID + "\n");
            richTextBox1.AppendText("入职时间:" + user.TimeComeStu + "\n");
            richTextBox1.AppendText("工作时间：" + user.TimeRuzhi + "\n");
            richTextBox1.AppendText("职位：" + user.Zhiwei + "\n");
            richTextBox1.AppendText("学历：" + user.Xl + "\n");
            richTextBox1.AppendText("家庭住址：" + user.Address + "\n");
            richTextBox1.AppendText("年龄：" + user.Age + "\n");
            richTextBox1.AppendText("生日：" + user.Birth + "\n");
            richTextBox1.AppendText("班主任班级：" + user.Bzrclass + "\n");
            if (user.Classed.Length != 0)
            {
                foreach (string c in user.Classed)
                    richTextBox1.AppendText("班级:" + c + "\n");
            }
            richTextBox1.AppendText("绩效：" + user.grade + "\n");
            richTextBox1.AppendText("绩效工资：" + user.Jxmoney + "\n");
            richTextBox1.AppendText("工资：" + user.Money + "\n");
            richTextBox1.AppendText("所教科目" + user.Sub + "\n");
            richTextBox1.AppendText("电话号码：" + user.Tel + "\n");
            if (user.Reward != null)
            {
                foreach (string jl in user.Reward)
                    richTextBox1.AppendText("奖励：" + jl + "\n");
            }
            if (user.Punish != null)
            {
                foreach (string cf in user.Punish)
                    richTextBox1.AppendText("惩罚:" + cf + "\n");
            }
        }
        private void userForm_Load(object sender, EventArgs e)
        {
            showRich(user);
        }
    }
}
