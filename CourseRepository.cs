using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_15___Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course> ();
        
        public void AddCourse(Course course)
        {
            courses.Add (course);
        }
        
        public Course GetCourse (string name)
        {
            foreach (Course course in courses)
            {
                if (course.Name == name)
                {
                    return course;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            Utility utilityCourse = new Utility();

            foreach (Course course in courses)
            {
                totalValue += utilityCourse.GetValueOfCourse(course);
            }
            return totalValue;
        }
    }
}
