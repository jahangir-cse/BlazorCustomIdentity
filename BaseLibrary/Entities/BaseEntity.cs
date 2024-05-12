
using System.Text.Json.Serialization;

namespace BaseLibrary.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //Relation Ship : One to Many
        [JsonIgnore]
        public List<Employee>? Employees { get; set; }
    }
}
