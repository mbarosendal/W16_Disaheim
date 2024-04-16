using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        private string _design;
        private Level _quality;

        public string Design
        {
            get { return _design; }
            set { _design = value; }
        }

        public Level Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }

        // Constructor with itemId parameter
        public Amulet(string itemId)
        {
            ItemId = itemId; // Accessing ItemId property from Merchandise class
        }

        // Constructor with itemId and quality parameters
        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId; // Accessing ItemId property from Merchandise class
            Quality = quality;
        }

        // Constructor with itemId, quality, and design parameters
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId; // Accessing ItemId property from Merchandise class
            Quality = quality;
            Design = design;
        }

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
