namespace CompositionLab
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author;
        public Book(string isbn, string title, Author author)
        {
            this.isbn = isbn;
            this.title = title;
            this.author = author;
        }
        public string GetISBN()
        {
            return isbn;
        }
        public void SetISBN(string isbn)
        {
            this.isbn = isbn;
        }
        public string GetTitle()
        {
            return title;
        }
        public void SetTitle(string title)
        {
            this.title = title;
        }
        public Author GetAuthor()
        {
            return author;
        }
        public void SetAuthor(Author author)
        {
            this.author = author;
        }
        public override string ToString()
        {
            return "ISBN = " + this.isbn + "\tTitle = " + this.title + "\t" + author.ToString();
        }
    }
}
