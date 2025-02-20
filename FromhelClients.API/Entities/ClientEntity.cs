
namespace FromhelClients.API.Entities
{
    public class ClientEntity
    {
        public ClientEntity(string ClientName, string ClientEmail)
        {
            Random random = new Random();
            int randomNumber = random.Next(10000, 9999);
            ClientId = "FHS-" + randomNumber.ToString();
            Name = ClientName;
            Email = ClientEmail;
            RegisteredAt = DateTime.Now;
        }

        public string ClientId { get; set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public DateTime RegisteredAt { get; private set; }

    }
}
