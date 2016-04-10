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
    public partial class form1 : Form
    {
        delForm m_dlg;
        public static mongoDB db = new mongoDB();
        public HashSet<User> userinfo = new HashSet<User>();                   
        public static MongoCollection conn = db.getConn();
        private awardForm af;
        private puishFrom pf;
        public string about = "本考核系统是猪油仔设计，超哥制作的主要的目的是完成毕业设计并且完成请吃饭的任务";

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
            if (newpeople.ShowDialog() == DialogResult.OK)
            {
                this.showRich(newpeople.addUser);
            }
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
            if (user.Reward!= null)
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
            MessageBox.Show("重置成功password：123456");           
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Parent == null)
            {
                MessageBox.Show("请先选择人员");
            }
            else
            {
                TreeNode userNode = treeView1.SelectedNode;
                string userID = userNode.Name;
                var query = new QueryDocument { { "ID", userID } };
                var result = conn.FindAs<User>(query);
                User user = result.ElementAt<User>(0);
                user.Reward = new string[] { };
                conn.Remove(query);
                conn.Insert<User>(user);
                MessageBox.Show("删除奖励成功");
                showRich(user);
            }
            
        }
        public void writeRewardInDB(string str)
        {
            TreeNode userNode = treeView1.SelectedNode;
            string userID = userNode.Name;
            var query = new QueryDocument { { "ID", userID } };
            var result = conn.FindAs<User>(query);
            User user = result.ElementAt<User>(0);
            string reward="";
            for (int i = 0; i < user.Reward.Length; i++)
            {
                reward += user.Reward[i]+'-';
            }
            reward += str;
            string[] aw = reward.Split('-');
            user.Reward = aw;

            conn.Remove(query);
            conn.Insert<User>(user);
            showRich(user);
            MessageBox.Show("添加奖励成功"+str);    
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Parent == null)
            {
                MessageBox.Show("请先选择人员");
            }
            else
            {
                af = new awardForm();                
                if (af.ShowDialog() == DialogResult.OK)
                {
                    writeRewardInDB(af.strIndex);
                }
            }
        }
        public void writePunishInDB(string str)
        {
            TreeNode userNode = treeView1.SelectedNode;
            string userID = userNode.Name;
            var query = new QueryDocument { { "ID", userID } };
            var result = conn.FindAs<User>(query);
            User user = result.ElementAt<User>(0);
            string reward = "";
            for (int i = 0; i < user.Punish.Length; i++)
            {
                reward += user.Punish[i] + '-';
            }
            reward += str;
            string[] aw = reward.Split('-');
            user.Punish = aw;

            conn.Remove(query);
            conn.Insert<User>(user);
            showRich(user);
            MessageBox.Show("添加惩罚成功" + str);            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Parent == null)
            {
                MessageBox.Show("请先选择人员");
            }
            else
            {
                pf = new puishFrom();
                if (pf.ShowDialog() == DialogResult.OK)
                {
                    writePunishInDB(pf.strIndex);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TreeNode userNode = treeView1.SelectedNode;
            if (treeView1.SelectedNode == null || treeView1.SelectedNode.Parent == null)
            {
                MessageBox.Show("请先选择人员");
            }
            else
            {
                
                string userID = userNode.Name;
                var query = new QueryDocument { { "ID", userID } };
                var result = conn.FindAs<User>(query);
                User user = result.ElementAt<User>(0);
                user.Punish = new string[] { };
                conn.Remove(query);
                conn.Insert<User>(user);
                MessageBox.Show("删除惩罚成功");
                showRich(user);
            }
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void findandshow(string fID, string fName)
        {
            if (fID == "")
            {
                var query = new QueryDocument { { "name", fName } };        
                var result = conn.FindAs<User>(query);                                
                if (result.Count() != 0)
                {
                    User user = result.ElementAt<User>(0);
                    showRich(user);
                }
                else
                {
                    MessageBox.Show("没有找到name为:" + fName + "的人");
                }
            }
            else           
                if (fName == "")
                {
                    var query = new QueryDocument { { "ID", fID } };
                    var result = conn.FindAs<User>(query);
                    if (result.Count() != 0)
                    {
                        User user = result.ElementAt<User>(0);
                        showRich(user);
                    }
                    else
                    {
                        MessageBox.Show("没有找到ID为:" + fID + "的人");
                    }
                }
        }
        private void 查找人员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findPeople fp = new findPeople();
            if (fp.ShowDialog() == DialogResult.OK)
            {
                string findID = fp.FindId1;
                string findName = fp.FindName1;
                findandshow(findID, findName);
            }

        }

        private void 添加奖赏条件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rearddataForm rrdd = new rearddataForm();
            rrdd.ShowDialog();
        }

        private void 添加惩罚调理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Punidataform pf = new Punidataform();
            pf.ShowDialog();
        }
    }
}


