using MongoDB.Bson.Serialization.Attributes;

namespace CasgemMicroservice.Services.Catalog.Models
{
    public class Category
    {
        [BsonId]
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}