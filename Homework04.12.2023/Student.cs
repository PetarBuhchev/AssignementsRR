using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04._12._2023
{
    public class Student
    {
        public string StudentName { get; set; }
        public string EGN { get; set; }
        private int gradeBel;
        private int gradeMath;
        public int GradeBel
        {
            get { return this.gradeBel; }
            set
            {
                if (value >= 2 && value <= 6)
                {
                    this.gradeBel = value;
                }
                else
                {
                    Console.WriteLine("Error gradeBel");
                }
                ;
            }
        }
        public int GradeMath
        {
            get { return this.gradeMath; }
            set
            {
                if (value >= 2 && value <= 6)
                {
                    this.gradeMath = value;
                }
                else
                {
                    Console.WriteLine("Error gradeMath");
                }
                ;
            }
        }
        public bool ReceiveIncome()
        {
            if ((this.GradeBel + this.GradeMath) / 2 >= 5.5)
            {
                return true;
            }
            return false;
        }
        public void SetExcellentGrades()
        {
            this.gradeBel = 6;
            this.gradeMath = 6;
        }
    }
}
