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
        public static MongoCollection conn = db.getConn();
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
                            }
                        }
                        if (ID == "")
                        {
                            var query = new QueryDocument { { "name", name } };
                            if (MessageBox.Show("你确定删除name为:" + name + "的人员") == DialogResult.OK)
                            {
                                conn.Remove(query);
                                MessageBox.Show("Name:" + name + "删除成功");
                            }
                        }
                        if(ID!=""&&name!="")
                        {
                            var query = new QueryDocument { { "name", name },{"ID",ID} };
                            if (MessageBox.Show("你确定删除name为:" + name +"ID:"+ ID+ "的人员") == DialogResult.OK)
                            {
                                conn.Remove(query);
                                MessageBox.Show("Name:" + name + "ID:" + ID + "删除成功");
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
    }
}


