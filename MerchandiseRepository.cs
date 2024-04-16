using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_15___Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise GetMerchandise(string itemID)
        {
            foreach (Merchandise merchandise in merchandises)
            {
                if (merchandise.ItemId == itemID)
                {
                    return merchandise;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            Utility utilityMerchandise = new Utility();

            foreach (Merchandise merchandise in merchandises)
            {
                totalValue += utilityMerchandise.GetValueOfMerchandise(merchandise);
            }
            return totalValue;
        }
    }
}
