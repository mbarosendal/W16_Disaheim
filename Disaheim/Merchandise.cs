using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public abstract class Merchandise
    {
        private string _itemId;

        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    }
}
