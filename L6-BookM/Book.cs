namespace L6_Ex3
{
    public class Book
    {
        private string isbn;
        private string name;
        private bool onLoan;

        public Book(string isbn, string name)
        {
            this.isbn = isbn;
            this.name = name;
            onLoan = false;
        }

        public string Isbn
        {
            get => isbn;
            set => isbn = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public bool OnLoan
        {
            get => onLoan;
            set => onLoan = value;
        }

        public override string ToString()
        {
            return this.name +  " " + this.isbn;
        }
    }
}