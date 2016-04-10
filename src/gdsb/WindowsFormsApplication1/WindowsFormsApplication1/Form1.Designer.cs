namespace WindowsFormsApplication1
{
    partial class form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("校长室");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("教务处");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("行政处");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("后勤处");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除人员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改人员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找人员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加奖赏条件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加惩罚调理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.数据操作ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.删除人员ToolStripMenuItem,
            this.修改人员信息ToolStripMenuItem,
            this.查找人员ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.新建ToolStripMenuItem.Text = "添加人员";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 删除人员ToolStripMenuItem
            // 
            this.删除人员ToolStripMenuItem.Name = "删除人员ToolStripMenuItem";
            this.删除人员ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除人员ToolStripMenuItem.Text = "删除人员";
            this.删除人员ToolStripMenuItem.Click += new System.EventHandler(this.删除人员ToolStripMenuItem_Click);
            // 
            // 修改人员信息ToolStripMenuItem
            // 
            this.修改人员信息ToolStripMenuItem.Name = "修改人员信息ToolStripMenuItem";
            this.修改人员信息ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改人员信息ToolStripMenuItem.Text = "修改人员信息";
            this.修改人员信息ToolStripMenuItem.Click += new System.EventHandler(this.修改人员信息ToolStripMenuItem_Click);
            // 
            // 查找人员ToolStripMenuItem
            // 
            this.查找人员ToolStripMenuItem.Name = "查找人员ToolStripMenuItem";
            this.查找人员ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.查找人员ToolStripMenuItem.Text = "查找人员";
            this.查找人员ToolStripMenuItem.Click += new System.EventHandler(this.查找人员ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.helpToolStripMenuItem.Text = "help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.aboutToolStripMenuItem.Text = "about";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // 数据操作ToolStripMenuItem
            // 
            this.数据操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加奖赏条件ToolStripMenuItem,
            this.添加惩罚调理ToolStripMenuItem});
            this.数据操作ToolStripMenuItem.Name = "数据操作ToolStripMenuItem";
            this.数据操作ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据操作ToolStripMenuItem.Text = "数据操作";
            // 
            // 添加奖赏条件ToolStripMenuItem
            // 
            this.添加奖赏条件ToolStripMenuItem.Name = "添加奖赏条件ToolStripMenuItem";
            this.添加奖赏条件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加奖赏条件ToolStripMenuItem.Text = "奖赏条例";
            this.添加奖赏条件ToolStripMenuItem.Click += new System.EventHandler(this.添加奖赏条件ToolStripMenuItem_Click);
            // 
            // 添加惩罚调理ToolStripMenuItem
            // 
            this.添加惩罚调理ToolStripMenuItem.Name = "添加惩罚调理ToolStripMenuItem";
            this.添加惩罚调理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加惩罚调理ToolStripMenuItem.Text = "惩罚条例";
            this.添加惩罚调理ToolStripMenuItem.Click += new System.EventHandler(this.添加惩罚调理ToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(31, 41);
            this.treeView1.Name = "treeView1";
            treeNode1.BackColor = System.Drawing.Color.GhostWhite;
            treeNode1.Name = "xzs";
            treeNode1.Text = "校长室";
            treeNode1.ToolTipText = "校长那一帮人的数据";
            treeNode2.BackColor = System.Drawing.Color.GhostWhite;
            treeNode2.Name = "jwc";
            treeNode2.Text = "教务处";
            treeNode2.ToolTipText = "老师们的集合";
            treeNode3.BackColor = System.Drawing.Color.GhostWhite;
            treeNode3.Name = "xzc";
            treeNode3.Text = "行政处";
            treeNode3.ToolTipText = "专门做行政工作的那群狗东西";
            treeNode4.BackColor = System.Drawing.Color.GhostWhite;
            treeNode4.Name = "hqc";
            treeNode4.Text = "后勤处";
            treeNode4.ToolTipText = "做出猪吃的食物的那帮人";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(137, 408);
            this.treeView1.TabIndex = 1;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.richTextBox1.Location = new System.Drawing.Point(174, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(276, 408);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(456, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "重置密码";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(456, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "惩 罚";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(552, 41);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "清空记录";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "奖 赏";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(552, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "清空记录";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 483);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(706, 521);
            this.MinimumSize = new System.Drawing.Size(706, 521);
            this.Name = "form1";
            this.Text = "KPIk考核系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除人员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改人员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem 查找人员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加奖赏条件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加惩罚调理ToolStripMenuItem;

    }
}

