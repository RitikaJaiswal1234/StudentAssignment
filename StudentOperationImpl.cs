using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssignmentProject
{
    public class StudentOperationImpl : IStudentOperation
    {

        public List<CourseCompleteTimeTaken> getCourseCompleteTimeTakens(List<StudentData> list)
        {
            Dictionary<int, CourseCompleteTimeTaken> dic = new Dictionary<int, CourseCompleteTimeTaken>();
            foreach (StudentData studentData in list)
            {
                if (dic.ContainsKey(studentData.Id))
                {
                    CourseCompleteTimeTaken courseCompleteTimeTaken = dic[studentData.Id];


                    courseCompleteTimeTaken.NumberOfCourseCompleted++;
                    courseCompleteTimeTaken.Duration += studentData.Duration;
                    //  Console.WriteLine(courseCompleteTimeTaken);
                }
                else
                {
                    CourseCompleteTimeTaken courseCompleteTimeTaken = new CourseCompleteTimeTaken();

                    courseCompleteTimeTaken.Id = studentData.Id;
                    courseCompleteTimeTaken.Name = studentData.Name;
                    courseCompleteTimeTaken.Status = studentData.Status;

                    if (studentData.Status == "Complete")
                        courseCompleteTimeTaken.NumberOfCourseCompleted++;
                    courseCompleteTimeTaken.Duration = studentData.Duration;
                    dic.Add(studentData.Id, courseCompleteTimeTaken);
                }
            }
            List<CourseCompleteTimeTaken> finalResult = new List<CourseCompleteTimeTaken>();
            foreach (var element in dic)
            {
                finalResult.Add(element.Value);
            }
            return finalResult;
        }


        public List<CourseCompletedAndProgress> getCourseCompletedAndProgresses(List<StudentData> list)
        {
            Dictionary<Tuple<string, string>, CourseCompletedAndProgress> dictionary = new Dictionary<Tuple<string, string>, CourseCompletedAndProgress>();
            foreach (StudentData detail in list)
            {
                if (dictionary.ContainsKey(new Tuple<string, string>(detail.Subject, detail.Status)))
                {
                    CourseCompletedAndProgress courseCompletedAndProgress = dictionary[new Tuple<string, string>(detail.Subject, detail.Status)];
                    courseCompletedAndProgress.Subject = detail.Subject;
                    if (detail.Status == "Complete")
                        courseCompletedAndProgress.NumOfStudentCompleted++;
                    else
                        courseCompletedAndProgress.NumOfStudentProgress++;
                }
                else
                {
                    CourseCompletedAndProgress courseCompletedAndProgress = new CourseCompletedAndProgress();
                    courseCompletedAndProgress.Subject = detail.Subject;
                    courseCompletedAndProgress.Status = detail.Status;
                    if (detail.Status == "Complete")
                        courseCompletedAndProgress.NumOfStudentCompleted++;
                    else
                        courseCompletedAndProgress.NumOfStudentProgress++;
                    dictionary.Add(new Tuple<string, string>(detail.Subject, detail.Status), courseCompletedAndProgress);
                }
            }
            List<CourseCompletedAndProgress> finalResult = new List<CourseCompletedAndProgress>();
            foreach (var element in dictionary)
            {
                finalResult.Add(element.Value);
            }
            return finalResult;
        }



    }
}

