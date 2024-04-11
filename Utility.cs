using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_15___Disaheim
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            switch (amulet.Quality)
            {
                case Level.low:
                    return 12.5;
                case Level.medium:
                    return 20.0;
                case Level.high:
                    return 27.5;
                default:
                    return 0;
            }
        }

        public double GetValueOfCourse(Course course)
        {
            double startedHour = course.DurationInMinutes / 60;
            double remainderMinutes = course.DurationInMinutes % 60;
            if (remainderMinutes > 0 )
            {
                startedHour += 1;
            }
            
            return startedHour * 875;
        }
    }
}
