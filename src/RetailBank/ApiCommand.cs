using Newtonsoft.Json;

namespace CloudBank.RetailBank
{
    public class ApiCommand
    {
        //"commandname": "Get Balance"
        [JsonProperty("commandname")]
        public string CommandName { get; set; }

        //"route": "GetBalance/{accountnumber}",
        [JsonProperty("route")]
        public string Route { get; set; }

        //"method": "GET",
        [JsonProperty("route")]
        public string Method { get; set; }

        //"apikey": "l4MSAy7I9fA=="
        [JsonProperty("apikey")]
        public string ApiKey { get; set; }

    }
}
