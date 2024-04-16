using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class UtilityTwo
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            double value = 0.0;

            switch (amulet.Quality)
            {
                case Level.low:
                    value = 12.5;
                    break;
                case Level.medium:
                    value = 20.0;
                    break;
                case Level.high:
                    value = 27.5;
                    break;
                default:
                    Console.WriteLine("Invalid quality specified for the amulet.");
                    break;
            }

            return value;
        }

        public double GetValueOfCourse(Course course)
        {
            // Calculate the number of full hours (the decimal is ignored in int) and the remaining minutes.
            int fullHours = course.DurationInMinutes / 60;
            int remainingMinutes = course.DurationInMinutes % 60;

            // Add an hour if there is a minutes remainder (because if there are any remaining minutes after full hours, it still counts as a whole hour started).
            if (remainingMinutes > 0)
            {
                fullHours++;
            }
            double value = 875 * fullHours;
            return value;
        }

        // Alternative GetValueOfCourse() with Ceiling() for rounding up to get full hours.
        //public double GetValueOfCourse(Course course)
        //{       
        //    // Convert duration from minutes to hours and round up to the nearest whole number
        //    double hours = Math.Ceiling(course.DurationInMinutes / 60.0);

        //    // Calculate the value of the course
        //    return hours * 875.0;
        //}
    }
}
