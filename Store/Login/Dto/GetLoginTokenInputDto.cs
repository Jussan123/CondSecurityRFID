using Newtonsoft.Json;

namespace CondSecurityRFID.Store.Login.Dto
{
    public class GetLoginTokenInputDto
    {

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
