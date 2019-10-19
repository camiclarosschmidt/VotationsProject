using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Driver;
using MongoDB.Bson;

namespace WebApplication3.ConnectionDB
{
    public class MongoConnection
    {
        public static void OpenConnection()
        {
            IMongoDatabase database;

            var client = new MongoClient(
            "mongodb://127.0.0.1:27017/?compressors=disabled&gssapiServiceName=mongodb"
            );
            database = client.GetDatabase("VotationsDB");
            var collection = database.GetCollection<BsonDocument>("Votations");
        }

        public void AddVoteInDataBase(int value)
        {

        }
    }
}