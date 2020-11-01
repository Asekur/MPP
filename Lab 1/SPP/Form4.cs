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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void StartEditRows_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                //check for right row
                int parse = -1;
                Int32.TryParse(string.Join("", rowEdit.Text.Where(c => char.IsDigit(c))), out parse);
                if (parse < 1 || parse > main.dataGrid.Rows.Count)
                {
                    notRight.Visible = true;
                }
                else
                {
                    main.allBooks.Change(parse, boxOfColumns.SelectedIndex, newValue.Text);
                    notRight.Visible = false;
                    this.Close();
                    main.ShowListBooks();
                }
            }
        }

        private void BoxOfColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxOfColumns.SelectedIndex == -1)
            {
                startEditRows.Enabled = false;
            }
            else
            {
                startEditRows.Enabled = true;
            }
        }
    }
}
