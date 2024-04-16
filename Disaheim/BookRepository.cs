using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class BookRepository
    {
        private List<Book> Books = new List<Book>();
        UtilityTwo uc = new UtilityTwo();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public Book GetBook(string itemId) 
        {
            foreach (Book book in Books)
            {
                if (book.ItemId == itemId)
                {
                    return book;
                }
            }
            return null;
        }

        public double GetTotalValue() 
        {
            double totalValue = 0;
            foreach (Book book in Books)
            {
                totalValue += uc.GetValueOfBook(book);
            }
            return totalValue;
        }

    }
}
