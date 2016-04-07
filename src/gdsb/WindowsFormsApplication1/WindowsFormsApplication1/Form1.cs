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
using WindowsFormsApplication1.root;
using WindowsFormsApplication1;
using Microsoft.VisualBasic;
namespace WindowsFormsApplication1
{
    public partial class form1 : Form
    {
        delForm m_dlg;
        public static mongoDB db = new mongoDB();
        public HashSet<User> userinfo = new HashSet<User>();                   
        public static MongoCollection conn = db.getConn();
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadPeople();
        }
        public void loadPeople()
        {
            var result = conn.FindAllAs<User>();

            for (int i = 0; i < result.Count(); i++)
            {
                User userfind = result.ElementAt<User>(i);

            }
        }
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            root.rootFrom newpeople = new root.rootFrom();
            newpeople.Show();
        }

        private void 删除人员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_dlg == null)
            {
                m_dlg = new delForm();
                m_dlg.ButtonClik += new EventHandler(
                    (sender1, e1) =>
                    {                        
                        string ID = m_dlg.TextBox1value;
                        string name = m_dlg.TextBox2value;
                        MessageBox.Show("ID" + ID + "\n" + "name" + name);
                        if (ID == "" && name == "")
                        {
                            MessageBox.Show("请填写ID或者name");
                        }
                        if(name=="")
                        {
                            var query = new QueryDocument { { "ID", ID } };                            
                            if (MessageBox.Show("你确定删除ID为:" + ID + "的人员") == DialogResult.OK)
                            {
                                
                                conn.Remove(query);
                                MessageBox.Show("ID:" + ID + "删除成功");
                                userinfo.Clear();
                            }
                        }
                        if (ID == "")
                        {
                            var query = new QueryDocument { { "name", name } };
                            if (MessageBox.Show("你确定删除name为:" + name + "的人员") == DialogResult.OK)
                            {
                                conn.Remove(query);
                                MessageBox.Show("Name:" + name + "删除成功");
                                userinfo.Clear();
                            }
                        }
                        if(ID!=""&&name!="")
                        {
                            var query = new QueryDocument { { "name", name },{"ID",ID} };
                            if (MessageBox.Show("你确定删除name为:" + name +"ID:"+ ID+ "的人员") == DialogResult.OK)
                            {
                                conn.Remove(query);
                                MessageBox.Show("Name:" + name + "ID:" + ID + "删除成功");
                                userinfo.Clear();
                            }
                        }
                                                                                           
                    }
                );
                m_dlg.FormClosed += new FormClosedEventHandler(
                    (sender2, e2) => { m_dlg = null; }
                );
                m_dlg.Show(this);
            }
            else
            {
                m_dlg.Activate();
            }
          }

        private void 修改人员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rootFrom change = new rootFrom(true);
            change.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定退出程序？", "退出", MessageBoxButtons.OKCancel) == DialogResult.OK)
                this.Close();            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.about);
        }


        public string about = "本考核系统是猪油仔设计，超哥制作的主要的目的是完成毕业设计并且完成请吃饭的任务";
        private void showRich(User user)
        {
            richTextBox1.Clear();
            richTextBox1.AppendText("ID：" + user.ID + "\n");
            richTextBox1.AppendText("姓名：" + user.name + "\n");
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
            if (user.Punish!= null)
            {
                foreach (string jl in user.Punish)
                    richTextBox1.AppendText("奖励：" + jl + "\n");
            }
            if (user.Reward != null)
            {
                foreach (string cf in user.Reward)
                    richTextBox1.AppendText("惩罚" + cf + "\n");
            }
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
        private void addchildTv(TreeNode node,User user)
        {
            node.Nodes.Add(user.ID,user.name);
        }
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode index = treeView1.SelectedNode;
            if (index.Parent == null)       //判断是否是根节点
            {
                string nodeName_bgs = index.Text;
                //richTextBox1.AppendText(nodeName_bgs);
                var query = new QueryDocument { { "Bgs", nodeName_bgs } };
                var result = conn.FindAs<User>(query);
                if (result.Count() == 0)
                {
                    MessageBox.Show("这个栏目下没有人");
                }
                else
                {
                    for (int i = 0; i < result.Count(); i++)
                    {
                        User userfind = result.ElementAt<User>(i);
                        //if (!userinfo.Contains<User>(userfind))

                        if (userinfo.Count() != 0)
                        {
                            foreach (User user in userinfo.ToArray<User>())
                            {
                                if (user.ID == userfind.ID)
                                {
                                    return;
                                }
                            }
                        }
                        userinfo.Add(userfind);
                        addchildTv(index, userfind);

                        
                        
                    }

                }
            }
            else
            {
                string nodeName_name = index.Name;
                //richTextBox1.AppendText(nodeName_name+"hehe");
                var query = new QueryDocument { { "ID", nodeName_name } };
                var result = conn.FindAs<User>(query);
                if (result.Count() == 0)
                {
                    MessageBox.Show("这个人不存在");
                }
                else
                {
                    User userfind = result.ElementAt<User>(0);
                    this.showRich(userfind);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TreeNode userNode = treeView1.SelectedNode;
            string userID = userNode.Name;
            IMongoUpdate iu = MongoDB.Driver.Builders.Update.Set("Password", "123456");
            var query = new QueryDocument { { "ID", userID } };
            conn.Update(query, iu);                       
                       
            
        }
    }
}


