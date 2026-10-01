namespace OCP.Quiz.Questions;

public class MultipleChoiceQuestion : Question
{
    public MultipleChoiceQuestion(string prompt, string correctAnswer, string[] options) : base(prompt, correctAnswer)
    {
        Options = options;
    }

    private string[] Options;

    public override void Print()
    {
        for (int i = 0; i < Options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {Options[i]}");
        }
        Console.WriteLine("Enter the option number:");
    }

    public override bool IsCorrect(string answer)
    {
        return answer == CorrectAnswer;
    }
}