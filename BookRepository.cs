//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Uge_15___Disaheim
//{
//    public class BookRepository
//    {
//        private List<Book> books = new List<Book>();

//        public void AddBook(Book book)
//        {
//            books.Add(book);
//        }

//        public Book GetBook(string itemID)
//        {
//            foreach (Book book in books)
//            {
//                if (book.ItemId == itemID)
//                {
//                    return book;
//                }
//            }
//            return null;
//        }

//        public double GetTotalValue()
//        {
//            double totalValue = 0;
//            Utility utilityBook = new Utility();

//            foreach (Book book in books)
//            {
//                totalValue += utilityBook.GetValueOfBook(book);
//            }
//            return totalValue;
//        }
//    }
//}
