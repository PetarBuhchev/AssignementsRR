using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework04._12._2023
{
    public class Class
    {
        public string className;
        public Student student1;
        public Student student2;
        public Student student3;

        public Class()
        {
            this.className = string.Empty;
            this.student1 = null;
            this.student2 = null;
            this.student3 = null;
        }
        public Class(string className, Student student1, Student student2, Student student3)
        {
            this.className = className;
            this.student1 = student1;
            this.student2 = student2;
            this.student3 = student3;
        }
        public double CalculateAverageGrade()
        {
            return (this.student1.GradeBel + this.student1.GradeMath + this.student2.GradeBel + this.student2.GradeMath + this.student3.GradeMath + this.student3.GradeBel) / 6;
        }
        public void GetMinMaxGrade(ref double minValue, ref double maxValue)
        {
            double averageSt1 = (this.student1.GradeBel + this.student1.GradeMath) / 2;
            double averageSt2 = (this.student2.GradeBel + this.student2.GradeMath) / 2;
            double averageSt3 = (this.student3.GradeBel + this.student3.GradeMath) / 2;

            //намиране на минимална стойност
            if (averageSt1 < averageSt2)
            {
                if (averageSt1 < averageSt3)
                {
                    minValue = averageSt1;
                }
                else
                {
                    minValue = averageSt3;
                }
            }
            else
            {
                minValue = averageSt2;
            }
            //намиране на макс. стойност
            if (averageSt1 > averageSt2)
            {
                if (averageSt1 > averageSt3)
                {
                    maxValue = averageSt1;
                }
                else
                {
                    maxValue = averageSt3;
                }
            }
            else
            {
                maxValue = averageSt2;
            }
        }
        public void ChangeStudent(ref Class clas, Student newStudent)
        {
            clas.student1 = newStudent;
        }
        public
    }
}
