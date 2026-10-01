namespace OCP.Quiz.Questions;

public class TextQuestion : Question
{
    public TextQuestion(string prompt, string correctAnswer) : base(prompt, correctAnswer)
    {
    }

    public override void Print()
    {
        Console.WriteLine("Type your answer:");
    }

    public override bool IsCorrect(string answer)
    {
        return answer.Equals(
            CorrectAnswer,
            StringComparison.OrdinalIgnoreCase
        );
    }
}