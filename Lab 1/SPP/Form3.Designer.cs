namespace SPP
{
    partial class Form3
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
            this.isbnDelete = new System.Windows.Forms.TextBox();
            this.deleteRows = new System.Windows.Forms.Button();
            this.notRight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // isbnDelete
            // 
            this.isbnDelete.Location = new System.Drawing.Point(94, 30);
            this.isbnDelete.Name = "isbnDelete";
            this.isbnDelete.Size = new System.Drawing.Size(138, 22);
            this.isbnDelete.TabIndex = 3;
            this.isbnDelete.Text = "Enter ISBN";
            this.isbnDelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // deleteRows
            // 
            this.deleteRows.BackColor = System.Drawing.Color.White;
            this.deleteRows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteRows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.deleteRows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteRows.Location = new System.Drawing.Point(94, 58);
            this.deleteRows.Name = "deleteRows";
            this.deleteRows.Size = new System.Drawing.Size(138, 31);
            this.deleteRows.TabIndex = 2;
            this.deleteRows.Text = "Delete All";
            this.deleteRows.UseVisualStyleBackColor = true;
            this.deleteRows.Click += new System.EventHandler(this.DeleteRows_Click);
            // 
            // notRight
            // 
            this.notRight.AutoSize = true;
            this.notRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.notRight.ForeColor = System.Drawing.Color.Red;
            this.notRight.Location = new System.Drawing.Point(80, 134);
            this.notRight.Name = "notRight";
            this.notRight.Size = new System.Drawing.Size(157, 17);
            this.notRight.TabIndex = 4;
            this.notRight.Text = "Entered wrong ISBN!";
            this.notRight.Visible = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 162);
            this.Controls.Add(this.notRight);
            this.Controls.Add(this.isbnDelete);
            this.Controls.Add(this.deleteRows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удалить строки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox isbnDelete;
        private System.Windows.Forms.Button deleteRows;
        private System.Windows.Forms.Label notRight;
    }
}