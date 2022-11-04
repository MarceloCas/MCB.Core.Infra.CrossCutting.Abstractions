 namespace MCB.Core.Infra.CrossCutting.Abstractions.Utils;

public interface IUtils
{
    TEnum GetRandomEnumValue<TEnum>() where TEnum : struct, Enum, IConvertible;
}
