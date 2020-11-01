namespace SPP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFile = new System.Windows.Forms.Button();
            this.saveFile = new System.Windows.Forms.Button();
            this.newRow = new System.Windows.Forms.Button();
            this.listForSort = new System.Windows.Forms.ComboBox();
            this.startSort = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.subRow = new System.Windows.Forms.Button();
            this.editRow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.author,
            this.book,
            this.publisher,
            this.year,
            this.price});
            this.dataGrid.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGrid.Location = new System.Drawing.Point(12, 81);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGrid.Size = new System.Drawing.Size(1070, 263);
            this.dataGrid.TabIndex = 0;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.DataGrid_SelectionChanged);
            // 
            // isbn
            // 
            this.isbn.HeaderText = "ISBN";
            this.isbn.MinimumWidth = 6;
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.isbn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.isbn.Width = 125;
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.author.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.author.Width = 160;
            // 
            // book
            // 
            this.book.HeaderText = "Book";
            this.book.MinimumWidth = 6;
            this.book.Name = "book";
            this.book.ReadOnly = true;
            this.book.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.book.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.book.Width = 160;
            // 
            // publisher
            // 
            this.publisher.HeaderText = "Publisher";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            this.publisher.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.publisher.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.publisher.Width = 160;
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.MinimumWidth = 6;
            this.year.Name = "year";
            this.year.ReadOnly = true;
            this.year.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.year.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.year.Width = 70;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.price.Width = 125;
            // 
            // openFile
            // 
            this.openFile.BackColor = System.Drawing.Color.White;
            this.openFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.openFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.openFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFile.Location = new System.Drawing.Point(411, 12);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(138, 31);
            this.openFile.TabIndex = 1;
            this.openFile.Text = "Open File";
            this.openFile.UseVisualStyleBackColor = false;
            this.openFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.BackColor = System.Drawing.Color.White;
            this.saveFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.saveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveFile.Location = new System.Drawing.Point(555, 12);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(138, 31);
            this.saveFile.TabIndex = 2;
            this.saveFile.Text = "Save File";
            this.saveFile.UseVisualStyleBackColor = false;
            this.saveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // newRow
            // 
            this.newRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newRow.BackColor = System.Drawing.Color.Transparent;
            this.newRow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("newRow.BackgroundImage")));
            this.newRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.newRow.FlatAppearance.BorderSize = 0;
            this.newRow.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.newRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.newRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newRow.ForeColor = System.Drawing.Color.Transparent;
            this.newRow.Location = new System.Drawing.Point(920, 350);
            this.newRow.Name = "newRow";
            this.newRow.Size = new System.Drawing.Size(50, 50);
            this.newRow.TabIndex = 3;
            this.newRow.UseVisualStyleBackColor = false;
            this.newRow.Click += new System.EventHandler(this.NewRow_Click);
            // 
            // listForSort
            // 
            this.listForSort.BackColor = System.Drawing.Color.White;
            this.listForSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listForSort.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.listForSort.ForeColor = System.Drawing.Color.Black;
            this.listForSort.FormattingEnabled = true;
            this.listForSort.Items.AddRange(new object[] {
            "ISBN",
            "Author",
            "Book",
            "Publisher",
            "Year",
            "Price"});
            this.listForSort.Location = new System.Drawing.Point(12, 364);
            this.listForSort.Name = "listForSort";
            this.listForSort.Size = new System.Drawing.Size(214, 24);
            this.listForSort.TabIndex = 4;
            this.listForSort.SelectedIndexChanged += new System.EventHandler(this.ListForSort_SelectedIndexChanged);
            // 
            // startSort
            // 
            this.startSort.BackColor = System.Drawing.Color.White;
            this.startSort.Enabled = false;
            this.startSort.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startSort.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSort.Location = new System.Drawing.Point(243, 364);
            this.startSort.Name = "startSort";
            this.startSort.Size = new System.Drawing.Size(138, 31);
            this.startSort.TabIndex = 5;
            this.startSort.Text = "Sort";
            this.startSort.UseVisualStyleBackColor = false;
            this.startSort.Click += new System.EventHandler(this.StartSort_Click);
            // 
            // subRow
            // 
            this.subRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subRow.BackColor = System.Drawing.Color.Transparent;
            this.subRow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("subRow.BackgroundImage")));
            this.subRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.subRow.FlatAppearance.BorderSize = 0;
            this.subRow.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.subRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.subRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subRow.ForeColor = System.Drawing.Color.Transparent;
            this.subRow.Location = new System.Drawing.Point(976, 350);
            this.subRow.Name = "subRow";
            this.subRow.Size = new System.Drawing.Size(50, 50);
            this.subRow.TabIndex = 6;
            this.subRow.UseVisualStyleBackColor = false;
            this.subRow.Click += new System.EventHandler(this.SubRow_Click);
            // 
            // editRow
            // 
            this.editRow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editRow.BackColor = System.Drawing.Color.Transparent;
            this.editRow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editRow.BackgroundImage")));
            this.editRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.editRow.FlatAppearance.BorderSize = 0;
            this.editRow.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.editRow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.editRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editRow.ForeColor = System.Drawing.Color.Transparent;
            this.editRow.Location = new System.Drawing.Point(1032, 350);
            this.editRow.Name = "editRow";
            this.editRow.Size = new System.Drawing.Size(50, 50);
            this.editRow.TabIndex = 7;
            this.editRow.UseVisualStyleBackColor = false;
            this.editRow.Click += new System.EventHandler(this.EditRow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 454);
            this.Controls.Add(this.editRow);
            this.Controls.Add(this.subRow);
            this.Controls.Add(this.startSort);
            this.Controls.Add(this.listForSort);
            this.Controls.Add(this.newRow);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.dataGrid);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сборище книг";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.Button saveFile;
        public System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        public System.Windows.Forms.DataGridViewTextBoxColumn author;
        public System.Windows.Forms.DataGridViewTextBoxColumn book;
        public System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        public System.Windows.Forms.DataGridViewTextBoxColumn year;
        public System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button newRow;
        private System.Windows.Forms.ComboBox listForSort;
        private System.Windows.Forms.Button startSort;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button subRow;
        private System.Windows.Forms.Button editRow;
    }
}

