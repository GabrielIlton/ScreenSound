namespace ScreenSound.Models;

internal class Average
{
    public Average(int grade)
    {
        Grade = grade;
    }

    public int Grade { get; }

    public static Average Parse(string text)
    {
        int grade = int.Parse(text!);
        return new Average(grade);
    }
}