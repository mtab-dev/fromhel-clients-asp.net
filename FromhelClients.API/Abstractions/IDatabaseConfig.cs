namespace FromhelClients.API.Abstractions
{
    public interface IDatabaseConfig
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
