using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        public string Name;
        public int DurationInMinutes;
        public static double CourseHourValue = 875.0;

        public Course(string name)
        {
            this.Name = name;
        }

        public Course(string name, int durationInMinutes) : this(name)
        {
            DurationInMinutes = durationInMinutes;
        }

        public override string ToString()
        {
            // Add "Value: " and make it return the result of GetValue(), not the CourseHourValue property.
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }
        public double GetValue()
        {
            // Calculate the number of full hours (the decimal is ignored in int) and the remaining minutes.
            int fullHours = this.DurationInMinutes / 60;
            int remainingMinutes = this.DurationInMinutes % 60;


            // Add an hour if there is a minutes remainder (because if there are any remaining minutes after full hours, it still counts as a whole hour started).
            if (remainingMinutes > 0)
            {
                fullHours++;
            }
            double value = CourseHourValue * fullHours;
            return value;
        }

    }
}
