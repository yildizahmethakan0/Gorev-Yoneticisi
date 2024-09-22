using MongoDB.Driver;
using GorevYonetici.Models;

namespace GorevYonetici.Data
{
    public class MongoDbContext
    {
        private readonly IMongoDatabase _database;

        public MongoDbContext()
        {
            var client = new MongoClient("mongodb://localhost:27017"); // MongoDB bağlantı dizesini güncelleyin
            _database = client.GetDatabase("GorevYoneticiDb"); // Veritabanı adını güncelleyin
        }

        public IMongoCollection<Gorev> Gorevler => _database.GetCollection<Gorev>("Gorevler");
    }
}
