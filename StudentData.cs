using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssignmentProject
{
    public class StudentData
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public int Duration { get; set; }
        public string Status { get; set; }

        public StudentData(int id, string name, string subject,int duration, string status)
        {
            Id = id;
            Name = name;
            Subject = subject;
            Duration = duration;
            Status = status;

        }
    }
    public class CourseCompleteTimeTaken
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
      
        public int NumberOfCourseCompleted { get; set; }
        public int Duration { get; set; }
        public int TimeTaken { get; set; }

        public override string ToString()
        {
            return Id + "," + Name + "," + NumberOfCourseCompleted + "," + Duration;
        }
    }
    public class CourseCompletedAndProgress
    {
        public string Subject { get; set; }
        public int NumOfStudentCompleted { get; set; }
        public int NumOfStudentProgress { get; set; }
        public string Status { get; set; }

        public override string ToString()
        {
            return Subject + "," + NumOfStudentCompleted + "," + NumOfStudentProgress;
        }
    }
    public class CourseCompositeCompletedAndProgress
    {
        public string Subject { get; set; }
        public string Status { get; set; }
    }
}
