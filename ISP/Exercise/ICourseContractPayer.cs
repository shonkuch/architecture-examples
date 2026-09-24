namespace ISP.Exercise;

public interface ICourseContractPayer
{
    void AddCharge(decimal amount, string reason);
    decimal OutstandingBalance { get; }
}