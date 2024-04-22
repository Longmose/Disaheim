using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Amulet : Merchandise
    {
        private string design;
        private Level quality = Level.medium;

        public static double LowQualityValue = 12.5;
        public static double MediumQualityValue = 20.0;
        public static double HighQualityValue = 27.5;

        public string Design
        {
            get { return design; }
            set { design = value; }
        }
        public Level Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public Amulet(string itemId)
        {
            this.ItemId = itemId;
        }

        public Amulet(string itemId, Level quality) : this(itemId)
        {
            this.quality = quality;
        }

        public Amulet(string itemId, Level quality, string design)
            : this(itemId, quality)
        {
            this.design = design;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {design}";
        }

        public override double GetValue()
        {
            switch (Quality)
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
    }
}
