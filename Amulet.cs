using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_15___Disaheim
{
    public class Amulet
    {
        private string itemId;
        private string design;
        private Level quality = Level.medium;
        public string ItemId
        { 
            get { return itemId; } set { itemId = value; }
        }
        public string Design
        {
            get { return design; } set { design = value; }
        }
        public Level Quality
        {
            get { return quality; } set { quality = value; }
        }

        public Amulet (string itemId)
        {
            this.itemId = itemId;
        }

        public Amulet (string itemId, Level quality)
            : this(itemId)
        {
            this.quality = quality;
        }

        public Amulet (string itemId, Level quality, string design)
            :this(itemId, quality)
        {
            this.design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
}
