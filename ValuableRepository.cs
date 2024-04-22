using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Disaheim;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
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

        public void Save(string fileName = "ValuableRepository.txt")
        {
            using (StreamWriter writer = new StreamWriter(fileName, false))
            {
                foreach (IValuable valuable in valuables)
                {
                    writer.WriteLine(valuable.ToString());
                }
            }
        }

        // OBS!!! Kode fra ChatGPT  |
        //                          V
        public void Load(string fileName = "ValuableRepository.txt")
        {
            valuables.Clear();
            if (!File.Exists(fileName)) return;

            CultureInfo culture = CultureInfo.InvariantCulture; // Ensures consistent number formatting
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                try
                {
                    // Basic check for type based on expected `ToString` output
                    if (line.StartsWith("ItemId: "))
                    {
                        string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                        string itemId = parts[0].Split(':')[1].Trim();
                        if (parts[1].StartsWith("Title:"))
                        {
                            string title = parts[1].Split(':')[1].Trim();
                            string pricePart = parts[2].Split(':')[1].Trim();
                            double price = double.Parse(pricePart.Replace(',', '.'), culture); // Replace comma and parse
                            valuables.Add(new Book(itemId, title, price));
                        }
                        else
                        { // Handling Amulet
                            Level quality = (Level)Enum.Parse(typeof(Level), parts[1].Split(':')[1].Trim());
                            string design = parts.Length > 2 ? parts[2].Split(':')[1].Trim() : "";
                            valuables.Add(new Amulet(itemId, quality, design));
                        }
                    }
                    else if (line.StartsWith("Name: "))
                    { // Handling Course
                        string[] parts = line.Split(new string[] { ", " }, StringSplitOptions.None);
                        string name = parts[0].Split(':')[1].Trim();
                        int duration = int.Parse(parts[1].Split(':')[1].Trim(), culture);
                        valuables.Add(new Course(name, duration));
                    }
                }
                catch (Exception ex)
                {
                    // Optionally log or handle the error
                    continue; // Skip this entry if there's an error
                }
            }
        }
    }
}
