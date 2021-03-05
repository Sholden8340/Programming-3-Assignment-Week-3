namespace assignment1
{
    class Book : BookStoreItem
    {
        // book, the title, author and price
        public string Author { get;}

        public Book(string title, string author, double price, int count) : this(title, price)
        {
            this.Author = author;
            this.Count = count;
        }

        public Book(string title, double price)
        {
            this.Title = title;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"'{this.Title}' by {this.Author}, {this.Price:##.00} ({this.Count}x)";
        }
    }
}