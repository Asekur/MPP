namespace SPP
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rowEdit = new System.Windows.Forms.TextBox();
            this.boxOfColumns = new System.Windows.Forms.ComboBox();
            this.newValue = new System.Windows.Forms.TextBox();
            this.startEditRows = new System.Windows.Forms.Button();
            this.notRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rowEdit
            // 
            this.rowEdit.Location = new System.Drawing.Point(123, 22);
            this.rowEdit.Name = "rowEdit";
            this.rowEdit.Size = new System.Drawing.Size(166, 22);
            this.rowEdit.TabIndex = 4;
            this.rowEdit.Text = "Enter number of row";
            this.rowEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boxOfColumns
            // 
            this.boxOfColumns.FormattingEnabled = true;
            this.boxOfColumns.Items.AddRange(new object[] {
            "ISBN",
            "Author",
            "Book",
            "Publisher",
            "Year",
            "Price"});
            this.boxOfColumns.Location = new System.Drawing.Point(67, 105);
            this.boxOfColumns.Name = "boxOfColumns";
            this.boxOfColumns.Size = new System.Drawing.Size(134, 24);
            this.boxOfColumns.TabIndex = 5;
            this.boxOfColumns.SelectedIndexChanged += new System.EventHandler(this.BoxOfColumns_SelectedIndexChanged);
            // 
            // newValue
            // 
            this.newValue.Location = new System.Drawing.Point(207, 105);
            this.newValue.Name = "newValue";
            this.newValue.Size = new System.Drawing.Size(144, 22);
            this.newValue.TabIndex = 6;
            this.newValue.Text = "Enter new";
            this.newValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // startEditRows
            // 
            this.startEditRows.BackColor = System.Drawing.Color.White;
            this.startEditRows.Enabled = false;
            this.startEditRows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startEditRows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.startEditRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startEditRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startEditRows.Location = new System.Drawing.Point(132, 135);
            this.startEditRows.Name = "startEditRows";
            this.startEditRows.Size = new System.Drawing.Size(138, 31);
            this.startEditRows.TabIndex = 7;
            this.startEditRows.Text = "Get It";
            this.startEditRows.UseVisualStyleBackColor = false;
            this.startEditRows.Click += new System.EventHandler(this.StartEditRows_Click);
            // 
            // notRight
            // 
            this.notRight.AutoSize = true;
            this.notRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notRight.ForeColor = System.Drawing.Color.Red;
            this.notRight.Location = new System.Drawing.Point(123, 48);
            this.notRight.Name = "notRight";
            this.notRight.Size = new System.Drawing.Size(159, 17);
            this.notRight.TabIndex = 8;
            this.notRight.Text = "Entered wrong ROW!";
            this.notRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.notRight.Visible = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 209);
            this.Controls.Add(this.notRight);
            this.Controls.Add(this.startEditRows);
            this.Controls.Add(this.newValue);
            this.Controls.Add(this.boxOfColumns);
            this.Controls.Add(this.rowEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование строки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rowEdit;
        private System.Windows.Forms.ComboBox boxOfColumns;
        private System.Windows.Forms.TextBox newValue;
        private System.Windows.Forms.Button startEditRows;
        private System.Windows.Forms.Label notRight;
    }
}