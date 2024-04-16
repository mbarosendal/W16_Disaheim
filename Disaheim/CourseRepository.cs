using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> Courses = new List<Course>();
        public UtilityTwo uc = new UtilityTwo();

        public void AddCourse(Course course)
        {
            Courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            foreach (Course course in Courses)
            {
                if (course.Name == name)
                {
                    return course;
                }
                else
                    Console.WriteLine("Course not found!");
                    Console.ReadLine();
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (Course course in Courses)
            {
                totalValue += uc.GetValueOfCourse(course);
            }
            return totalValue;
        }

    }
}
