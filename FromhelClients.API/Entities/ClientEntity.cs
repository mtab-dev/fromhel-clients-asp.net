
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FromhelClients.API.Entities
{
    [BsonIgnoreExtraElements]
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
           
            Id = ObjectId.GenerateNewId().ToString();
        }

        [BsonId]
        [BsonRepresentationAttribute(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("clientId"), BsonRepresentationAttribute(BsonType.String)]
        public string ClientId { get; set; }

        [BsonElement("clientName"), BsonRepresentationAttribute(BsonType.String)]
        public string Name { get; private set; }

        [BsonElement("email"), BsonRepresentationAttribute(BsonType.String)]
        public string Email { get; private set; }

        [BsonElement("registeredAt"), BsonRepresentationAttribute(BsonType.DateTime)]
        public DateTime RegisteredAt { get; private set; }

    }
}
