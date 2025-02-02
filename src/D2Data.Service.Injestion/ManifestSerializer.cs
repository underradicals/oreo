using System.Text.Json;
using System.Text.Json.Serialization;
using D2Data.Service.Injestion.Models;
using D2Data.Service.Injestion.Models.ModelSourceGenerators;

namespace D2Data.Service.Injestion;

public class ManifestSerializer
{
    public Manifest Deserialize(string json)
    {
        var context = JsonSerializer.Deserialize(json, ManifestSerializerContext.Default.Manifest);
        return context switch
        {
            null => new Manifest(),
            _ => context
        };
    }
}