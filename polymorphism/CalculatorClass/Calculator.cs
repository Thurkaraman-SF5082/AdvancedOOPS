using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorClass
{
    public class Calculator
    {
        /*Create a class Calculator that will get semester marks of 6 subjects.

        Create four objects named Sem1, Sem 2, Sem 3, Sem 4 using calculate method that will calculate the total mark, percentage of 6 subject.
        Create a operator overloaded method that will calculate the total mark of 4 semesters and display the total marks and percentage. */
        public int Subject1 { get; set; }
        public int Subject2 { get; set; }
        public int Subject3 { get; set; }
        public int Subject4 { get; set; }
        public int Subject5 { get; set; }
        public int Subject6 { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }

        public Calculator(int subject1, int subject2, int subject3, int subject4, int subject5, int subject6)
        {
            Subject1 = subject1;
            Subject2 = subject2;
            Subject3 = subject3;
            Subject4 = subject4;
            Subject5 = subject5;
            Subject6 = subject6;
        }

        public static Calculator operator +(Calculator v1, Calculator v2)
        {
            Calculator cal = new Calculator(0, 0, 0, 0, 0, 0);
            cal.Subject1 = v1.Subject1 + v2.Subject1;
            cal.Subject2 = v1.Subject2 + v2.Subject2;
            cal.Subject3 = v1.Subject3 + v2.Subject3;
            cal.Subject4 = v1.Subject4 + v2.Subject4;
            cal.Subject5 = v1.Subject5 + v2.Subject5;
            cal.Subject6 = v1.Subject6 + v2.Subject6;
            return cal;
        }

    }
}