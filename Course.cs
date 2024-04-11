using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_15___Disaheim
{
    public class Course
    {
        private string name;
        private int durationInMinutes;

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

        public override string ToString()
        {
            return $"Name: {name}, Duration in Minutes: {durationInMinutes}";
        }
    }
}
