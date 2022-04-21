using System;
using System.Collections.Generic;

namespace University_Grading
{
    abstract public class Students : IStudents
    {
        protected int _minPosGrade;
        protected bool _activeStatus;
        protected int _totalCredits;
        protected int _grade;
        protected int _creditsForGraduating;
        protected string _studentName;
        protected int _studentNumber;
        
        List<int> _gradesList = new List<int>();

        public Students()
        {
        }

        public void AddCredits(int credits)
        {
            if (_activeStatus)
            {
                if (credits > 0)
                {
                    _totalCredits += credits;
                    if (_totalCredits >= _creditsForGraduating)
                    {
                        Console.WriteLine("Congratulations! You have graduated!");
                        TurnInactive();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid value. You must only add positive numbers for credits.");
                }
            }
            else
            {
                Console.WriteLine("Can't add credits, student inactive.");
            }
        }

        public void AddGrade(int grade)
        {
            if (_activeStatus)
            {
                if (grade >= 1 && grade <= 5)
                {
                    _gradesList.Add(grade);
                    if (grade ==  5)
                    {
                        Console.WriteLine("Good job!");
                    }
                }
                else
                {
                    Console.WriteLine("Can't add grade. Grade must be between 1-5.");
                }
            }
            else
            {
                Console.WriteLine("Can't add grades, student inactive.");
            }
        }

        public void ConvertGrade(int percentage)
        {
            if (_activeStatus)
            {
                if (percentage >= 0 && percentage < _minPosGrade)
                {
                    _grade = 0;
                }
                else if (percentage >= _minPosGrade && percentage <= 60)
                {
                    _grade = 1;
                }
                else if (percentage >= 61 && percentage <= 70)
                {
                    _grade = 2;
                }
                else if (percentage >= 71 && percentage <= 80)
                {
                    _grade = 3;
                }
                else if (percentage >= 81 && percentage <= 90)
                {
                    _grade = 4;
                }
                else if (percentage >= 91 && percentage <= 100)
                {
                    _grade = 5;
                }
                else
                {
                    Console.WriteLine("Can't add grade. Grade percentage must be between 0-100.");
                }
                AddGrade(_grade);
            }
            else
            {
                Console.WriteLine("Can't add grades, student inactive.");
            }
        }

        public void PrintGrades()
        {
            if (_gradesList.Count >= 1)
            {
                Console.WriteLine("Grades are: ");
                foreach(int grade in _gradesList)
                {
                    Console.WriteLine(grade);
                }
            }
            else
            {
                Console.WriteLine("Student has no grades yet.");
            }
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{_studentName} has {_totalCredits} credits.");
        }

        public void PrintLastGrade()
        {
            if (_gradesList.Count >= 1)
            {
                int last = _gradesList[_gradesList.Count - 1];
                Console.WriteLine($"{_studentName}'s last grade was {last}.");
            }
            else
            {
                Console.WriteLine("Student has no grades yet.");
            }
        }
        public void Activate()
        {
            if (!_activeStatus)
            {
                _activeStatus = true;
                Console.WriteLine("Student status: activated.");
            }
            else
            {
                Console.WriteLine("Student status already activated.");
            }
        }
        public void TurnInactive()
        {
            if (_activeStatus)
            {
                _activeStatus = false;
                Console.WriteLine("Student status: inactivated.");
            }
            else
            {
                Console.WriteLine("Student status already inactivated.");
            }
        }
    }
}
