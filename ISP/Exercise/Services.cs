namespace ISP.Exercise;

// Exercise: derive interfaces from actual usage in Clients.cs; preserve its behavior.
// An auditor receives announcements and attends classes, but has no grades or billing.
// Support auditors without adding auditor-specific methods or pretending they are students.
// Replace the duplicated student/teacher methods with operations on client roles.

public interface ICourseAnnouncements
{
    void SendTo(ICourseAttender attender, string courseCode, string subject, string body);
}

public interface IAttendanceTracker
{
    void MarkPresent(ICourseAttender attender, string courseCode, DateOnly date);
}

public interface IGradebook
{
    void RecordGrade(ICourseLearner learner, string courseCode, decimal points);
    decimal? GetFinal(ICourseLearner learner, string courseCode);
}

public interface IContractsBilling
{
    // Або залишити студента напряму, якщо на 100% впевнені
    void AddCharge(ICourseContractPayer payer, decimal amount, string reason);
    decimal GetBalance(ICourseContractPayer payer);
}
