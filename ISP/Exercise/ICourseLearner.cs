namespace ISP.Exercise;

public interface ICourseLearner : ICourseAttender
{
    void RecordGrade(string courseCode, decimal points);
    decimal? GetFinalGrade(string courseCode);
}