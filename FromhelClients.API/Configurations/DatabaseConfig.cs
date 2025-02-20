using FromhelClients.API.Abstractions;

namespace FromhelClients.API.Configurations
{
    public class DatabaseConfig : IDatabaseConfig
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    
    
    }
}
