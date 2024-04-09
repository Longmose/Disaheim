using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_15___Disaheim
{
    public class Book
    {
        private string itemId;
        private string title;
        private double price;

        public string ItemId
        { get { return itemId; } set { itemId = value; } }
        public string Title
        { get { return title; } set {  title = value; } }
        public double Price 
        { get { return price; } set {  price = value; } }

        public Book (string itemId)
        {
            this.itemId = itemId;
        }
        public Book (string itemId, string title) 
            : this(itemId)
        { 
            this.title = title;
        }
        public Book (string itemId, string title, double price)
            : this(itemId, title)
        {
            this.price = price;
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }
}
