namespace MCB.Core.Infra.CrossCutting.Abstractions.DateTime;

public interface IDateTimeProvider
{
    void ChangeGetDateCustomFunction(Func<DateTimeOffset>? getDateCustomFunction);
    DateTimeOffset GetDate();
}
