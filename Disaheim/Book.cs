using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Book : Merchandise
    {
        private string _title;
        private double _price;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }

        public Book(string itemId)
        {
            ItemId = itemId; // Accessing ItemId property from Merchandise class 
        }

        // Constructor with itemId and title parameters
        public Book(string itemId, string title)
        {
            ItemId = itemId; // Accessing ItemId property from Merchandise class
            Title = title;
        }

        public Book(string itemId, string title, double price)
        {
            ItemId = itemId; // Accessing ItemId property from Merchandise class
            Title = title;
            Price = price;
        }
    }
}
