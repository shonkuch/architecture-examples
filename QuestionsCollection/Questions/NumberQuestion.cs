namespace OCP.Quiz.Questions;

public class NumberQuestion : Question
{
    public NumberQuestion(string prompt, string correctAnswer, float tolerance) : base(prompt, correctAnswer)
    {
        if (!float.TryParse(correctAnswer, out float result))
        {
            throw new ArgumentException("Correct answer must be a number for a number question");
        }
        
        this.tolerance = tolerance;
    }

    private float tolerance;
    
    // Then add numeric questions with a configurable expected answer and inclusive tolerance, treating invalid numeric input as incorrect.
    public override void Print()
    {
        Console.WriteLine($"Type your answer (tolerance: {tolerance}):");
    }

    public override bool IsCorrect(string answer)
    {
        if (!float.TryParse(answer, out float result))
        {
            return false;
        }

        float correctAnswer = float.Parse(CorrectAnswer);
        
        return correctAnswer - result <= tolerance;
    }
}