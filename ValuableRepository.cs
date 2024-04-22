using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            foreach (var valuable in valuables) 
            {
                if (valuable is Merchandise merchandise && merchandise.ItemId == id)
                {
                    return merchandise;
                }
                else if (valuable is Course course && course.Name == id)
                {
                    return course;
                }
            }
            return null;
        }
        

        public double GetTotalValue()
        {
            double totalValue = 0.0;
            foreach (var valuable in valuables)
            {
                totalValue += valuable.GetValue();
            }
            return totalValue;
        }

        public int Count() 
        { 
            return valuables.Count; 
        }
    }
}
