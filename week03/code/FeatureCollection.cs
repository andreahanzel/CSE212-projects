using System.Text.Json.Serialization;
public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
[JsonPropertyName("features")]
    public Feature[] Features { get; set; }
}

public class Feature
{
    [JsonPropertyName("properties")]
    public Properties Properties { get; set; }
}

public class Properties
{
    [JsonPropertyName("place")]
    public string Place { get; set; }
    
    [JsonPropertyName("mag")]
    public float Magnitude { get; set; }
}