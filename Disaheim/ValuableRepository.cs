namespace Disaheim
{
    public class ValuableRepository : IPersistable
    {
        public List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            foreach (var valuable in valuables)
            {
                // Condition syntax? immediately gives you a variable for the object,
                // which is used in the same line to access the amulet.ItemId property.
                if (valuable is Amulet amulet && amulet.ItemId == id)
                    return amulet;
                else if (valuable is Book book && book.ItemId == id)
                    return book;
                else if (valuable is Course course && course.Name == id)
                    return course;
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach (var valuable in valuables)
            {
                if (valuable is Amulet amulet)
                    totalValue += amulet.GetValue();
                else if (valuable is Book book)
                    totalValue = book.GetValue();
                else if (valuable is Course course)
                    totalValue += course.GetValue();
            }
            return totalValue;
        }

        public int Count()
        {
            return valuables.Count;
        }

        public void Save()
        {
            string fileName = "ValuableRepository.txt";
            // Save the file in the Current Working directory, since the unit tests using File.Exists() expects this.
            string currentDirectory = Directory.GetCurrentDirectory();
            string fullPath = Path.Combine(currentDirectory, fileName);

            using (StreamWriter sw = new StreamWriter(fullPath, false))
            {
                foreach (IValuable valuable in valuables)
                {
                    if (valuable is Amulet amulet)
                        sw.WriteLine($"Amulet;{amulet.ItemId};{amulet.Quality};{amulet.Design}");
                    else if (valuable is Book book)
                        sw.WriteLine($"Book;{book.ItemId};{book.Title};{book.Price}");
                    else if (valuable is Course course)
                        sw.WriteLine($"Course;{course.Name};{course.DurationInMinutes};{course.GetValue()}");
                }
            }
        }

        public void Save(string fileName /*= "ValuableRepostory.txt"*/)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fullPath = Path.Combine(currentDirectory, fileName);

            using (StreamWriter sw = new StreamWriter(fullPath, false))
            {
                foreach (IValuable valuable in valuables)
                {
                    if (valuable is Amulet amulet)
                        sw.WriteLine($"Amulet;{amulet.ItemId};{amulet.Quality};{amulet.Design}");
                    else if (valuable is Book book)
                        sw.WriteLine($"Book;{book.ItemId};{book.Title};{book.Price}");
                    else if (valuable is Course course)
                        sw.WriteLine($"Course;{course.Name};{course.DurationInMinutes};{course.GetValue()}");
                }
            }
        }

        public void Load()
        {
            string fileName = "ValuableRepository.txt";
            string currentDirectory = Directory.GetCurrentDirectory();
            string fullPath = Path.Combine(currentDirectory, fileName);

            string[] lines = File.ReadAllLines(fullPath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');

                if (parts[0] == "Amulet")
                {
                    string itemId = parts[1];
                    Level quality = (Level)Level.Parse(typeof(Level), parts[2]);
                    string design = parts[3];

                    AddValuable(new Amulet(itemId, quality, design));
                }
                else if (parts[0] == "Book")
                {
                    string itemId = parts[1];
                    string title = parts[2];
                    double price = Convert.ToDouble(parts[3]);

                    AddValuable(new Book(itemId, title, price));
                }
                else if (parts[0] == "Course")
                {
                    string name = parts[1];
                    int durationInMinutes = int.Parse(parts[2]);

                    AddValuable(new Course(name, durationInMinutes));
                }
            }
        }

        public void Load(string fileName /*= "ValuableRepostory.txt"*/)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string fullPath = Path.Combine(currentDirectory, fileName);

            string[] lines = File.ReadAllLines(fullPath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(';');

                if (parts[0] == "Amulet")
                {
                    string itemId = parts[1];
                    Level quality = (Level)Enum.Parse(typeof(Level), parts[2]);
                    string design = parts[3];

                    AddValuable(new Amulet(itemId, quality, design));
                }
                else if (parts[0] == "Book")
                {
                    string itemId = parts[1];
                    string title = parts[2];
                    double price = Convert.ToDouble(parts[3]);

                    AddValuable(new Book(itemId, title, price));
                }
                else if (parts[0] == "Course")
                {
                    string name = parts[1];
                    int durationInMinutes = int.Parse(parts[2]);

                    AddValuable(new Course(name, durationInMinutes));
                }
            }
        }
    }
}
