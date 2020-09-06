using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int counter = 0;

        private void DeleteRows_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                for (int i = 0; i < main.dataGrid.Rows.Count; i++)
                {
                    if (isbnDelete.Text == main.dataGrid.Rows[i].Cells[0].Value.ToString())
                    {
                        main.allBooks.DeleteBook(main.dataGrid.Rows[i].Cells[0].Value.ToString());
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    this.notRight.Visible = true;
                }
                if (counter != 0)
                {
                    this.notRight.Visible = false;
                    this.Close();
                    main.ShowListBooks();
                }
            }
        }
    }
}
