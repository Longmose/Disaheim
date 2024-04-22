using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course : IValuable
    {
        private string name;
        private int durationInMinutes;
        public static double CourseHourValue = 875.0;

        public string Name {  get { return name; } set {  name = value; } }
        public int DurationInMinutes { get { return durationInMinutes; } set { durationInMinutes = value; } }


        public Course(string name)
        {
            this.name = name;
        }

        public Course(string name, int durationInMinutes) : this(name)
        {
            this.durationInMinutes = durationInMinutes;
        }
        
        public double GetValue()
        {
            double startedHour = DurationInMinutes / 60;
            double remainderMinutes = DurationInMinutes % 60;
            if (remainderMinutes > 0)
            {
                startedHour += 1;
            }
            return startedHour * CourseHourValue;
        }

        public override string ToString()
        {
            return $"Name: {name}, Duration in Minutes: {durationInMinutes}, Value: {GetValue()}";
        }
    }
}
