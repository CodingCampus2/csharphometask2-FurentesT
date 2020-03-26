using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task2, string> TaskSolver = task =>
            {
                // Your solution goes here
                // You can get all needed inputs from task.[Property]
                // Good luck!
                System.Globalization.NumberFormatInfo info = new System.Globalization.NumberFormatInfo();

                info.CurrencySymbol = "$";

                string symbols = new string(task.DecorativeSign, Task2.Padding / 2);
                string spaces = new string(' ', Task2.Padding / 2);
                //string const 
                string answer = string.Format("{0}{1}{2}{1}{0}", symbols, spaces, task.Balance.ToString("c2", info));

                return answer;
            };

            Task2.CheckSolver(TaskSolver);
        }
    }
}
