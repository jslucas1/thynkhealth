namespace api.Models
{
    public class DataObject
    {
        public string id { get; set; }
        public string query { get; set; }
        public Parameters[] parameters { get; set; }
    }
}