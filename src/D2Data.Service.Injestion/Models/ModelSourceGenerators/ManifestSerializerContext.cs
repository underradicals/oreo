using System.Text.Json;
using System.Text.Json.Serialization;

namespace D2Data.Service.Injestion.Models.ModelSourceGenerators;

[JsonSourceGenerationOptions(
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    )]
[JsonSerializable(typeof(Manifest))]
public partial class ManifestSerializerContext : JsonSerializerContext
{
}