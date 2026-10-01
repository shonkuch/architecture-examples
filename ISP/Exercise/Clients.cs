namespace ISP.Exercise;

public class CourseAnnouncements : ICourseAnnouncements
{
    public void SendTo(ICourseAttender attender, string courseCode, string subject, string body)
    {
        Console.WriteLine($"To: {attender.FullName} <{attender.Email}> | {courseCode}: {subject} | {body}");
    }
}

public class AttendanceTracker : IAttendanceTracker
{
    public void MarkPresent(ICourseAttender attender, string courseCode, DateOnly date)
    {
        Console.WriteLine($"{date:yyyy-MM-dd} | {courseCode} | {attender.Id} {attender.FullName}: present");
    }
}

public class Gradebook : IGradebook
{
    public void RecordGrade(ICourseLearner learner, string courseCode, decimal points)
    {
        learner.RecordGrade(courseCode, points);
    }

    public decimal? GetFinal(ICourseLearner learner, string courseCode)
    {
        return learner.GetFinalGrade(courseCode);
    }
}

public class ContractsBilling : IContractsBilling
{
    // Або залишити студента напряму, якщо на 100% впевнені
    public void AddCharge(ICourseContractPayer payer, decimal amount, string reason)
    {
        payer.AddCharge(amount, reason);
    }

    public decimal GetBalance(ICourseContractPayer payer)
    {
        return payer.OutstandingBalance;
    }
}
