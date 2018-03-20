using System;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using SimpleApi.DataObject

namespace SimpleApi.Data
{
    public class SimpleApiDb: IDisposable
    {
        public static string ConnectionString { get; set; }
        public static string DatabaseName { get; set; }
        public IMongoDatabase MongoDb { get; set; }
        public MongoClient Client { get; set; }

        public IMongoCollection<MProduct> Products { get; private set; }
        
        public SimpleApiDb() {
            Client = new MongoClient(ConnectionString);
            MongoDb = Client.GetDatabase(DatabaseName);

            Products = MongoDb.GetCollection<MProduct>("Product");
        }

        public void Dispose()
        {
        }
    }
}