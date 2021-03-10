namespace api.Models
{
    public class ProtocolDetail
    {
        public string id { get; set; }
        public int display_order { get; set; }
        public int wait_days { get; set; }

        public Action action { get; set; }
    }
}