namespace api.Models
{
    public class Action
    {
        public string id { get; set; }
        public int action_type_id { get; set; }
        public string template { get; set; }
        public string description { get; set; }
    }
}