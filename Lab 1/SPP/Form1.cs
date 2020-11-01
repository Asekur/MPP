using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace SPP
{
    public partial class Form1 : Form
    {
        public BooksStorage allBooks;

        public Form1()
        {
            InitializeComponent();
        }

        public void ShowListBooks()
        {
            dataGrid.Rows.Clear();
            foreach (Book book in allBooks)
            {
                dataGrid.Rows.Add(book.isbn, book.author, book.book, book.publisher, book.year, book.price);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allBooks = new BooksStorage();
            /*Book bookOne = new Book("978-5-17-067779-5", "Иджинио", "Клуб Винкс", "Rainbow", 2010, 11.500);
            Book bookTwo = new Book("978-5-17-049354-8", "Алчеева", "Почему и отчего", "Астрель", 2007, 20500.9);
            Book bookThree = new Book("978-0-48-627543-7", "LEWIS CARROLL", "Alice", "Macmillan", 1865, 150012.35);
            allBooks.AddNewBook(bookOne);
            allBooks.AddNewBook(bookTwo);
            allBooks.AddNewBook(bookThree);*/
            ShowListBooks();
        }

        private void DataGrid_SelectionChanged(object sender, EventArgs e)
        {
            //start without selection
            {
                try
                {
                    ((DataGridView)sender).SelectedCells[0].Selected = false;
                }
                catch { }
            }
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            //show data from file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) == ".ask")
                {
                    allBooks.OpenAllBooks(openFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("Choose right file");
                }
            }
            ShowListBooks();
        }

        private void SaveFile_Click(object sender, EventArgs e)
        {
            //write data to file
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                allBooks.SaveAllBooks(saveFileDialog.FileName);
            }
        }

        private void NewRow_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Owner = this;
            form2.ShowDialog();
        }

        private void SubRow_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Owner = this;
            form3.ShowDialog();
        }

        private void EditRow_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Owner = this;
            form4.ShowDialog();
        }

        private void ListForSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listForSort.SelectedIndex == -1)
            {
                startSort.Enabled = false;
            }
            else
            {
                startSort.Enabled = true;
            }
        }

        private void StartSort_Click(object sender, EventArgs e)
        {
            //choose sort way
            allBooks.Sort(listForSort.SelectedIndex);
            //rewrite datagridview
            ShowListBooks();
        }
    }
}
