using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;

namespace SPP
{
    public class BooksStorage : IEnumerable
    {
        public List<Book> allBooks;
        public BooksStorage()
        {
            this.allBooks = new List<Book>();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return allBooks.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void AddNewBook(Book newBook)
        {
            this.allBooks.Add(newBook);
        }

        public void ClearList()
        {
            this.allBooks.Clear();
        }

        public void SaveAllBooks (string fileName)
        {
            FileStream flstream = new FileStream(fileName, FileMode.OpenOrCreate);
            BinaryWriter bw = new BinaryWriter(flstream);
            foreach (Book value in allBooks)
            {
                bw.Write(value.isbn);
                bw.Write(value.author);
                bw.Write(value.book);
                bw.Write(value.publisher);
                bw.Write(value.year);
                bw.Write(value.price);
            }
            flstream.Close();
        }

        public void OpenAllBooks (string fileName)
        {
            //add to list
            this.ClearList();
            FileStream flstream = new FileStream(fileName, FileMode.Open);
            BinaryReader br = new BinaryReader(flstream);
            while (br.PeekChar() > -1)
            {
                Book newBook = new Book(
                    br.ReadString(),
                    br.ReadString(),
                    br.ReadString(),
                    br.ReadString(),
                    br.ReadInt32(),
                    br.ReadDouble());
                this.AddNewBook(newBook);
            }
            flstream.Close();
        }

        public void DeleteBook (string isbn)
        {
            for (int i = 0; i < this.allBooks.Count; i++)
            {
                if (this.allBooks[i].isbn == isbn)
                {
                    this.allBooks.Remove(this.allBooks[i]);
                }
            }
        }

        public void Sort (int index)
        {
            switch (index)
            {
                case 0:
                    this.allBooks.Sort((a, b) => a.isbn.CompareTo(b.isbn));
                    break;
                case 1:
                    this.allBooks.Sort((a, b) => a.author.CompareTo(b.author));
                    break;
                case 2:
                    this.allBooks.Sort((a, b) => a.book.CompareTo(b.book));
                    break;
                case 3:
                    this.allBooks.Sort((a, b) => a.publisher.CompareTo(b.publisher));
                    break;
                case 4:
                    this.allBooks.Sort((a, b) => a.year.CompareTo(b.year));
                    break;
                case 5:
                    this.allBooks.Sort((a, b) => a.price.CompareTo(b.price));
                    break;
            }
        }

        public static double ParseToDouble(string value)
        {
            double result = 0;
            if (!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("ru-RU"), out result))
            {
                if (!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out result))
                {
                    return 0;
                }
            }
            return result;
        }

        public void Change (int row, int index, string value)
        {
            int parseYear;
            Int32.TryParse(string.Join("", value.Where(c => char.IsDigit(c))), out parseYear);
            switch (index)
            {
                case 0:
                    this.allBooks[row - 1].isbn = value;
                    break;
                case 1:
                    this.allBooks[row - 1].author = value;
                    break;
                case 2:
                    this.allBooks[row - 1].book = value;
                    break;
                case 3:
                    this.allBooks[row - 1].publisher = value;
                    break;
                case 4:
                    this.allBooks[row - 1].year = parseYear;
                    break;
                case 5:
                    this.allBooks[row - 1].price = ParseToDouble(value);
                    break;
            }
        }
    }
}
