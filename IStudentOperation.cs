using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssignmentProject
{
    public interface IStudentOperation
    {
        public List<CourseCompleteTimeTaken> getCourseCompleteTimeTakens(List<StudentData> list);
       public List<CourseCompletedAndProgress> getCourseCompletedAndProgresses(List<StudentData> list);
    }
}
