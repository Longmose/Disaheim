//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Uge_15___Disaheim
//{
//    public class AmuletRepository
//    {
//        private List<Amulet> amulets = new List<Amulet> ();
        
//        public void AddAmulet(Amulet amulet)
//        {
//            amulets.Add (amulet);
//        }
        
//        public Amulet GetAmulet (string itemID)
//        {
//            foreach (Amulet amulet in amulets)
//            {
//                if (amulet.ItemId == itemID)
//                {
//                    return amulet;
//                }
//            }
//            return null;
//        }

//        public double GetTotalValue()
//        {
//            double totalValue = 0;
//            Utility utilityAmulet = new Utility();

//            foreach (Amulet amulet in amulets)
//            {
//                totalValue += utilityAmulet.GetValueOfAmulet(amulet);
//            }
//            return totalValue;
//        }
//    }
//}