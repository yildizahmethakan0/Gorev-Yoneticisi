using MongoDB.Driver;
using GorevYonetici.Models;

namespace GorevYonetici.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("GorevYoneticiDb");  
        }

        public IMongoCollection<Gorev> Gorevler => _database.GetCollection<Gorev>("Gorevler");
    }
}
