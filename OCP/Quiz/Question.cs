namespace OCP.Quiz;

// The starting model stores both kinds of question in the same shape.
// For multiple choice, CorrectAnswer is the one-based option number as a string.
public abstract class Question
{
    protected Question(string prompt, string correctAnswer)
    {
        Prompt = prompt;
        CorrectAnswer = correctAnswer;
    }
    
    public string Prompt { protected set; get; }
    protected string CorrectAnswer;
    
    public abstract bool IsCorrect(string answer);

    public abstract void Print();
}
