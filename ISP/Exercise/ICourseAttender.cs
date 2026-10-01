namespace ISP.Exercise;

public interface ICourseAttender
{
    Guid Id { get; }
    string FullName { get; }
    string Email { get; }
}