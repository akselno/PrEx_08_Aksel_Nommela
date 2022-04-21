using System;
namespace University_Grading
{
    public class Bachelor : Students
    {
        public Bachelor(string name)
        {
            _studentName = name;
            _totalCredits = 0;
            _minPosGrade = 51;
            _creditsForGraduating = 180;
        }
    }
}
