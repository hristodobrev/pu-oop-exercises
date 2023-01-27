namespace _4.Library
{
    public class Book
    {
        private string? title;
        private string? author;
        private int pages;
        private decimal price;

        public string? Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Title must not be empty.", "Title");
                }

                this.title = value;
            }
        }
        public string? Author
        {
            get { return this.author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Author must not be empty.", "Author");
                }

                this.author = value;
            }
        }
        public int Pages
        {
            get
            {
                return this.pages;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Pages must be a positive number", "Pages");
                }

                this.pages = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be a positive number", "Price");
                }

                this.price = value;
            }
        }

        public Book(string title, string author, int pages, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Pages = pages;
            this.Price = price;
        }

        public Book() { }

        public override string ToString()
        {
            return $"Title: {this.Title}{Environment.NewLine}Author: {this.Author}{Environment.NewLine}Price: ${this.Price}{Environment.NewLine}Pages: {this.Pages}";
        }
    }
}
