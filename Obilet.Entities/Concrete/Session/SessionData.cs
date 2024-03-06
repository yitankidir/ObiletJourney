using Newtonsoft.Json;

namespace Obilet.Entities.Concrete.Session
{
    public class SessionData
    {
        [JsonProperty("session-id")]
        public string SessionId { get; set; }

        [JsonProperty("device-id")]
        public string DeviceId { get; set; }

        [JsonProperty("affiliate")]
        public string Affiliate { get; set; }

        [JsonProperty("device-type")]
        public int DeviceType { get; set; }
    }
}
