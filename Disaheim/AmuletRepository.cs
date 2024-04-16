using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> Amulets = new List<Amulet>();
        UtilityTwo uc = new UtilityTwo();

        public void AddAmulet(Amulet amulet)
        {
            Amulets.Add(amulet);
        }

        public Amulet GetAmulet(string itemId)
        {
            foreach (Amulet amulet in Amulets)
            {
                if (amulet.ItemId == itemId)
                {
                    return amulet;
                }  
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (Amulet amulet in Amulets)
            {
                totalValue += uc.GetValueOfAmulet(amulet);
            }
            return totalValue;
        }
    }
}
