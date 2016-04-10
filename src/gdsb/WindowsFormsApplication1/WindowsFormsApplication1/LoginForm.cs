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
using WindowsFormsApplication1;
namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        public static mongoDB db = new mongoDB();        
        public static MongoCollection conn = db.getConn();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var query = new QueryDocument{{"ID",textBox1.Text}};
            var result = conn.FindAs<User>(query);
            if (textBox1.Text == "admin" && textBox2.Text == "admin123")
            {
                this.Hide();
                //登陆管理员界面
                form1 root = new form1();
                root.ShowDialog();
                this.Close();
            }
            else
            {
                if (result.Count() == 0 )
                {
                    MessageBox.Show("用户名或密码输入错误");
                }
                else
                {
                    User user = result.ElementAt<User>(0);
                    if (!user.Password.Equals(textBox2.Text))
                    {
                        MessageBox.Show("用户名或密码输入错误");
                    }
                    else
                    {
                        this.Hide();
                        //分配到不同的用户去登陆
                        userForm uf = new userForm(user);
                        uf.ShowDialog();
                        this.Close();
                    }
                }
            }
        }
    }
}
