using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_15___Disaheim
{
    public abstract class Merchandise
    {
        public string ItemId { get; set; }

        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    }
}
