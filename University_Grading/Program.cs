using System;

namespace University_Grading
{
    class Program
    {
        static void Main(string[] args)
        {

            Bachelor bachelor = new Bachelor("Aksel");
            Bachelor bachelor2 = new Bachelor("Jüri");
            Master master = new Master("Therese", 12345);
            Master master2 = new Master("Mari", 98765);

            bachelor.Activate();
            bachelor.AddCredits(-30);
            bachelor.AddGrade(-4);
            bachelor.AddGrade(4);
            bachelor.ConvertGrade(67);
            bachelor.AddGrade(5);
            bachelor.AddCredits(80);
            bachelor.PrintInfo();
            bachelor.PrintGrades();
            bachelor.PrintLastGrade();
            bachelor.AddCredits(120);
            bachelor.PrintInfo();

            Console.WriteLine("");

            bachelor2.Activate();
            bachelor2.ConvertGrade(20);
            bachelor2.AddGrade(7);
            bachelor2.AddGrade(4);
            bachelor2.ConvertGrade(70);
            bachelor2.AddGrade(1);
            bachelor2.PrintGrades();
            bachelor2.PrintLastGrade();
            bachelor2.AddCredits(70);
            bachelor2.AddCredits(110);
            bachelor2.PrintInfo();

            Console.WriteLine("");

            master.Activate();
            master.AddCredits(-30);
            master.AddGrade(-4);
            master.AddGrade(4);
            master.ConvertGrade(37);
            master.ConvertGrade(41);
            master.AddGrade(5);
            master.AddCredits(90);
            master.PrintInfo();
            master.PrintLastGrade();
            master.AddCredits(30);
            master.TurnInactive();

            Console.WriteLine("");

            master2.Activate();
            master2.ConvertGrade(50);
            master2.AddGrade(1);
            master2.AddGrade(0);
            master2.AddGrade(5);
            master2.ConvertGrade(200);
            master2.PrintGrades();
            master2.PrintLastGrade();
            master2.AddCredits(80);
            master2.AddCredits(40);
            master2.PrintInfo();
        }
    }
}
