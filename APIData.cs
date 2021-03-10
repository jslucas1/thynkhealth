using api.Models;
namespace api
{
    public class APIData
    {
        private static ProtocolContainer inboundObject;

        public static void SetInboundObject(ProtocolContainer value)
        {
            inboundObject = value;
        }

        public static ProtocolContainer GetInboundObject()
        {
            return inboundObject;
        }
    }
}