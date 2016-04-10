using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApplication1.user
{
    class dataUser
    {
        public ObjectId _id;
        string[] awardindex = new string[]{};
        string[] awardgrade = new string[]{};
        public string ID = "0";
        public string[] Awardgrade
        {
            get { return awardgrade; }
            set { awardgrade = value; }
        }
        public string[] Awardindex
        {
            get { return awardindex; }
            set { awardindex = value; }
        }

        string[] punindex = new string[]{};

        public string[] Punindex
        {
            get { return punindex; }
            set { punindex = value; }
        }
        string[] pungrade = new string[]{};

        public string[] Pungrade
        {
            get { return pungrade; }
            set { pungrade = value; }
        }


    }
}
