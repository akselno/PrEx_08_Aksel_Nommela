using System;
namespace University_Grading
{
    public class Master : Students
    {

        public Master(string name, int studentNumber)
        {
            _studentNumber = studentNumber;
            _studentName = name;
            _totalCredits = 0;
            _minPosGrade = 40;
            _creditsForGraduating = 120;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{_studentName} (nr. {_studentNumber}) has {_totalCredits} credits.");
        }
    }
}
