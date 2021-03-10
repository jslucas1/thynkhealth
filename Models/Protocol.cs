namespace api.Models
{
    public class Protocol
    {
        public string id { get; set; }
        public string description { get; set; }
        public int activity_type_id { get; set; }

        public DataObject data_object { get; set; }
    }
}