namespace MCB.Core.Infra.CrossCutting.Abstractions.Serialization;

public interface IJsonSerializer
{
    string SerializeToJson(object obj);
    T? DeserializeFromJson<T>(string json);
    string GenerateJsonSchema(Type type);
    string GenerateJsonSchema(object obj);
}
