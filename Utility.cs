using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_15___Disaheim
{
    public class Utility
    {
        public double LowQualityValue = 12.5;
        public double MediumQualityValue = 20.0;
        public double HighQualityValue = 27.5;
        public double CourseHourValue = 875.0;

        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Book book)
            {
                return GetValueOfBook(book);
            }
            else if (merchandise is Amulet amulet)
            {
                return GetValueOfAmulet(amulet);
            }
            return 0;
        }

        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            switch (amulet.Quality)
            {
                case Level.low:
                    return LowQualityValue;
                case Level.medium:
                    return MediumQualityValue;
                case Level.high:
                    return HighQualityValue;
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
            
            return startedHour * CourseHourValue;
        }
    }
}
