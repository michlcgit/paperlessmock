using System.Text.Json.Serialization;

namespace Paperless.sl.Models;

public partial class ListResponse<T>
{
    [JsonPropertyName("count")]
    public long Count { get; set; }

    [JsonPropertyName("next")]
    public Uri Next { get; set; }

    [JsonPropertyName("previous")]
    public Uri Previous { get; set; }

    [JsonPropertyName("results")]
    public IList<T> Results { get; set; }
}
