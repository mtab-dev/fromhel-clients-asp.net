using MongoDB.Driver;

namespace FromhelClients.API.Infra
{
    public class MongoDbService
    {
        private readonly IMongoDatabase mongoDatabase;

        public MongoDbService(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DbConnection");
            var databaseName = configuration["ConnectionStrings:DbName"]; 

            var mongoClient = new MongoClient(connectionString);
            mongoDatabase = mongoClient.GetDatabase(databaseName);
        }

        public IMongoDatabase Database => mongoDatabase;
    }
}
