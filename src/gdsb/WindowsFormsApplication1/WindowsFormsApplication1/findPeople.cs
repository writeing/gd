using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class findPeople : delForm
    {
         
        public findPeople()
        {
            this.Text = "查找人员";
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // findPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Name = "findPeople";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
