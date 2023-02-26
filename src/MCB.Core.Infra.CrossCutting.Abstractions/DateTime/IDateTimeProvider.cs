namespace MCB.Core.Infra.CrossCutting.Abstractions.DateTime;

public interface IDateTimeProvider
{
    DateTimeOffset GetDate();
}
