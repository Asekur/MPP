using System;

namespace SPP
{
    public class Book : IComparable<Book>, IEquatable<Book>
    {
        public int year;
        public double price;
        public string isbn, author, book, publisher;

        public Book (string isbn, string author, string book, string publisher, int year, double price)
        {
            this.isbn = isbn;
            this.author = author;
            this.book = book;
            this.publisher = publisher;
            this.year = year;
            this.price = price;
        }

        //methods using interface

        public int CompareTo(Book other)
        {
            //if other is not a valid object reference, this instance is greater.
            if (other == null) return 1;
            //the comparison depends on the comparison of the year values.
            return this.year.CompareTo(other.year);
        }

        public bool Equals (Book other)
        {
            //check for null and compare
            if (other == null)
                return false;
            if (this.isbn == other.isbn && this.author == other.author && this.book == other.book
                    && this.publisher == other.publisher && this.price == other.price)
                return true;
            else
                return false;
        }

        //methodes of object
        public override int GetHashCode()
        {
            return isbn.GetHashCode();
        }

        public override string ToString()
        {
            string[] values = new string[] { this.isbn,
                this.author,
                this.book,
                this.publisher,
                this.year.ToString(),
                this.price.ToString()};
            return String.Join("", values);
        }

        public override bool Equals(object obj)
        {
            //check for null and compare run-time types.
            if (obj == null)
                return false;
            Book bookObj = obj as Book;
            if (bookObj == null)
                return false;
            else
                return Equals(bookObj);
        }
    }
}
