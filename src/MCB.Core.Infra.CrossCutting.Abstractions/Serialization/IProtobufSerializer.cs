namespace MCB.Core.Infra.CrossCutting.Abstractions.Serialization;

public interface IProtobufSerializer
{
    byte[] SerializeToProtobuf(object obj);
    T? DeserializeFromProtobuf<T>(byte[] byteArray);
}
