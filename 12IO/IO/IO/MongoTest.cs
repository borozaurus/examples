using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace IO
{
    public static class MongoTest
    {
        public static void Exectute()
        {
            var document = new BsonDocument()
            {
                {"simple", true}
            };

            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("foo");
            var collection = database.GetCollection<BsonDocument>("bar");
            collection.InsertOne(document);

            var result = collection.FindSync(new BsonDocument()).FirstOrDefault();

            System.Console.WriteLine("is it simple :" + result["simple"]);
        }
    }
}
