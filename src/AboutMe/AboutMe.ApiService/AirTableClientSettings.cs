namespace AboutMe.ApiService;

public class AirTableClientSettings
{
    [JsonPropertyName("baseId")]
    public string? BaseId { get; set; }

    [JsonPropertyName("appKey")]
    public string? AppKey { get; set; }
}
