using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name, bool isWeighted):base(name, isWeighted)
        {
           Type = GradeBookType.Ranked;
        }
  

        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStatistics();
            }
        }

        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
            }
            else
            {
                base.CalculateStudentStatistics(name);
            }
        }
        public void GetLetterGrade(BaseGradeBook Student)
        {
           
            var twentyPercent = Students.Count*0.2;
            foreach(GradeBook.Student student in Students)
            {
                //grade = Grades(student);
            }
        }
    }
}
