namespace ScreenSound.Models;

internal interface IRateable
{
    void AddGrade(Average grade);

    double Average { get; }
}