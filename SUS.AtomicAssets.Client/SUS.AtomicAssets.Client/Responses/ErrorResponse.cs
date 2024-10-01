using Newtonsoft.Json;
namespace SUS.AtomicAssets.Client.Responses
{
    public class ErrorResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}