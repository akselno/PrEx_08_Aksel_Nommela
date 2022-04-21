using System;
namespace University_Grading
{
    public interface IStudents
    {
        void AddCredits(int credits);
        void AddGrade(int grade);
        void ConvertGrade(int percentage);
        void PrintGrades();
        void PrintInfo();
        void PrintLastGrade();
        void Activate();
        void TurnInactive();
    }
}
