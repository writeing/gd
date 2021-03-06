﻿using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.user;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class rearddataForm : databaseForm
    {
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        dataUser user;
        
        public rearddataForm()
        {
            this.InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "增 加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "删 除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rearddataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(491, 153);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "rearddataForm";
            this.Load += new System.EventHandler(this.rearddataForm_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (StrInputGrade == String.Empty || StrInputText == String.Empty)
            {
                MessageBox.Show("ntm倒是输入个数字啊");
                return;
            }
            var query = new QueryDocument { { "ID", "0" } };
            string index = "";
            string grade = "";
            if (Textindex == 0xffffffff)
            {
                user.Awardgrade[0] = StrInputText;
                user.Awardindex[0] = StrInputGrade;
            }
            {
                if (user.Awardindex != null)
                {
                    for (int i = 0; i < user.Awardindex.Length; i++)
                    {
                        index += user.Awardindex[i] + '-';
                        grade += user.Awardgrade[i] + '-';
                    }
                }
                index += StrInputText;
                grade += StrInputGrade;
                string[] strindex = index.Split('-');
                string[] strGrade = grade.Split('-');
                user.Awardindex = strindex;
                user.Awardgrade = strGrade;
                conn.Remove(query);
                conn.Insert<dataUser>(user);                
            }
            setComText(user.Awardindex);
            setComGrade(user.Awardgrade);

            StrInputGrade = "";
            StrInputText = "";
        }

        private void rearddataForm_Load(object sender, EventArgs e)
        {
            var query = new QueryDocument { { "ID", "0" } };
            var result = conn.FindAs<dataUser>(query);

            if (result.Count() != 0)
            {
                user = result.ElementAt<dataUser>(0);
                setComText(user.Awardindex);
                setComGrade(user.Awardgrade);
            }
            else
            {
                user = new dataUser();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (StrInputGrade == "")
            {
                MessageBox.Show("没有选中需要删除的数据");
                return;
            }

            Console.WriteLine(user.Awardgrade.Count());
            int i;
            var query = new QueryDocument { { "ID", "0" } };                        
            for (i = Gradeindex ; i < user.Awardgrade.Length-1; i++)
            {
                user.Awardgrade[i] = user.Awardgrade[i + 1];
                user.Awardindex[i] = user.Awardindex[i + 1];
            }
            user.Awardindex[i] = "";
            user.Awardgrade[i] = "";
            conn.Remove(query);
            conn.Insert<dataUser>(user);
            StrInputGrade = "";
            StrInputText = "";
            setComText(user.Awardindex);
            setComGrade(user.Awardgrade);

        }
    }
}
