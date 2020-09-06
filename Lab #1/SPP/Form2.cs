using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SPP
{
    public partial class Form2 : Form
    {
        const int lastRow = 0;
        const int amountColumn = 6;
        public Form2()
        {
            InitializeComponent();
            dataGrid.Rows.Add();
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

        private string CorrectDataString(object forCheck)
        {
            if (forCheck == null)
            {
                return "";
            }
            return forCheck.ToString();
        }

        private int CorrectDataInt(object forCheck)
        {
            int parse = 0;
            if (forCheck == null)
            {
                return parse;
            }
            Int32.TryParse(string.Join("", forCheck.ToString().Where(c => char.IsDigit(c))), out parse);
            return parse;
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

        private double CorrectDataDouble(object forCheck)
        {
            double parse = 0;
            if (forCheck == null)
            {
                return parse;
            }
            return ParseToDouble(forCheck.ToString());
        }

        private void NewRow_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                Book addBook = new Book(
                    CorrectDataString(this.dataGrid.Rows[lastRow].Cells[0].Value),
                    CorrectDataString(this.dataGrid.Rows[lastRow].Cells[1].Value),
                    CorrectDataString(this.dataGrid.Rows[lastRow].Cells[2].Value),
                    CorrectDataString(this.dataGrid.Rows[lastRow].Cells[3].Value),
                    CorrectDataInt(this.dataGrid.Rows[lastRow].Cells[4].Value),
                    CorrectDataDouble(this.dataGrid.Rows[lastRow].Cells[5].Value)
                    );
                main.allBooks.AddNewBook(addBook);
                this.Close();
                main.ShowListBooks();
            }
        }
    }
}
