using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApplication1.user
{

    public class User
    {
        public ObjectId _id;
        string birth, age, sub, timeComeStu, timeRuzhi, numID, xl, Grade, money, zhiwei, password, bzrclass, tel, address, jxmoney;

        public string Jxmoney
        {
            get { return jxmoney; }
            set { jxmoney = value; }
        }
        string[] classed;
        string[] reward;
        string[] punish;

        public string[] Punish
        {
            get { return punish; }
            set { punish = value; }
        }
        public string[] Reward
        {
            get { return reward; }
            set { reward = value; }
        }
        


        public string[] Classed
        {
            get { return classed; }
            set { classed = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Bzrclass
        {
            get { return bzrclass; }
            set { bzrclass = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Zhiwei
        {
            get { return zhiwei; }
            set { zhiwei = value; }
        }

        public string Money
        {
            get { return money; }
            set { money = value; }
        }

        public string grade
        {
            get { return Grade; }
            set { Grade = value; }
        }

        public string Xl
        {
            get { return xl; }
            set { xl = value; }
        }

        public string NumID
        {
            get { return numID; }
            set { numID = value; }
        }

        public string TimeRuzhi
        {
            get { return timeRuzhi; }
            set { timeRuzhi = value; }
        }

        public string TimeComeStu
        {
            get { return timeComeStu; }
            set { timeComeStu = value; }
        }

        public string Sub
        {
            get { return sub; }
            set { sub = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Birth
        {
            get { return birth; }
            set { birth = value; }
        }



        public User(string Name = null, string ID = null, string birth = null, string age = null, string sub = null, string[] classed = null, string timeComeStu = null, string timeRuzhi = null, string numID = null, string xl = null, string Grade = null, string money = null, string zhiwei = null,string password = "123456")
        {
            this.name = Name;
            this.ID = ID;
            this.birth = birth;
            this.age = age;
            this.sub = sub;
            this.classed = classed;
            this.timeComeStu = timeComeStu;
            this.timeRuzhi = timeRuzhi;
            this.numID = numID;
            this.xl = xl;
            this.Grade = Grade;
            this.money = money;
            this.zhiwei = zhiwei;
            this.password = password;
        }
        public string name
        {
            get;
            set;
        }
        public string ID
        {
            get;
            set;
        }
    }



}
