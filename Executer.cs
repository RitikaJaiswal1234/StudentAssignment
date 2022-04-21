using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssignmentProject
{
    public class Executer
    {
        public static void Main(String[] args)
        {
            List<StudentData> listOfStudent = new List<StudentData>();
            listOfStudent.Add(new StudentData(101, "Shubham", "wpf", 8, "Complete"));
            listOfStudent.Add(new StudentData(102, "Sanju", "java", 4, "Complete"));
            listOfStudent.Add(new StudentData(101, "Shubham", "java", 6, "Complete"));
            listOfStudent.Add(new StudentData(103, "Ravi", "web", 4, "Progress"));
            listOfStudent.Add(new StudentData(104, "Aakash", "Aws", 10, "Progress"));
            listOfStudent.Add(new StudentData(105, "Rama", "java", 4, "Progress"));
            listOfStudent.Add(new StudentData(102, "Sanju", "Ops", 8, "Complete"));
            listOfStudent.Add(new StudentData(106, "Aman", "wpf", 6, "Complete"));

            StudentOperationImpl studentOperationImpl = new StudentOperationImpl();
            List<CourseCompleteTimeTaken> finalResult1 = studentOperationImpl.getCourseCompleteTimeTakens(listOfStudent);
            foreach(CourseCompleteTimeTaken courseCompleteTimeTaken in finalResult1)
            {
                Console.WriteLine(courseCompleteTimeTaken);
            }
            Console.WriteLine("**********************************************************************************");

            List<CourseCompletedAndProgress> finalResult2 = studentOperationImpl.getCourseCompletedAndProgresses(listOfStudent);
            foreach (CourseCompletedAndProgress courseCompletedAndProgress in finalResult2)
            {
                Console.WriteLine(courseCompletedAndProgress);
            }
        }
    }
}