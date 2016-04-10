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
    class puishFrom :recordBaseForm
    {

        public puishFrom()
        {
            var query = new QueryDocument { { "ID", "0" } };
            var result = conn.FindAs<dataUser>(query);
            dataUser user = result.ElementAt<dataUser>(0);
            Record = user.Punindex;
            LabelText = "惩罚";
        }
    }
}
