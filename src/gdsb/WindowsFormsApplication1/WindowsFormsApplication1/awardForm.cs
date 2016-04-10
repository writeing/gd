using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication1.user;
using WindowsFormsApplication1.database;
using MongoDB.Driver;
using MongoDB.Bson;
namespace WindowsFormsApplication1
{
    class awardForm : recordBaseForm
    {
        public awardForm()
        {           
            var query = new QueryDocument { { "ID", "0" } };
            var result = conn.FindAs<dataUser>(query);
            dataUser user = result.ElementAt<dataUser>(0);
            Record = user.Awardindex;
            LabelText = "奖励";
        }
    }
}
