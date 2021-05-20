namespace assignment1
{
    class Book : BookStoreItem
    {
        // book, the title, author and price
        public string Author { get;}

        public Book(string title, string author, double price, int count) : base(title, price)
        {
            this.Author = author;
            this.Count = count;
        }

        public override string ToString()
        {
            return $"[Book] '{this.Title}' by {this.Author}, {this.Price:##.00} ({this.Count}x)";
        }
    }
}