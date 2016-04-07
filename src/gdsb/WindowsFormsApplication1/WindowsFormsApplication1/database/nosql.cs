using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace WindowsFormsApplication1.database
{
    public class mongoDB
    {
        public string service = "mongodb://127.0.0.1:27017";
        public string databasename = "gd";
        public string datatablename = "people";

        public MongoCollection getConn()
        {
            MongoServer server = MongoDB.Driver.MongoServer.Create(service);
            //获得数据库cnblogs
            MongoDatabase db = server.GetDatabase(databasename);

            MongoCollection conn = db.GetCollection(datatablename);
            return conn;
        }
    }
}
