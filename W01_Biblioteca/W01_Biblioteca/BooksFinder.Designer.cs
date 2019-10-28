namespace W01_Biblioteca
{
    partial class BibliotecaMainForm
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
            this.title = new System.Windows.Forms.Label();
            this.lSearch = new System.Windows.Forms.Label();
            this.bSearchBook = new System.Windows.Forms.Button();
            this.booksList = new System.Windows.Forms.ListBox();
            this.iBookSearch = new System.Windows.Forms.TextBox();
            this.bAuthorsForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(90, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(400, 46);
            this.title.TabIndex = 0;
            this.title.Text = "CIFPPauCasesnoves";
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.Location = new System.Drawing.Point(98, 102);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(66, 13);
            this.lSearch.TabIndex = 1;
            this.lSearch.Text = "Search book";
            // 
            // bSearchBook
            // 
            this.bSearchBook.Location = new System.Drawing.Point(458, 140);
            this.bSearchBook.Name = "bSearchBook";
            this.bSearchBook.Size = new System.Drawing.Size(75, 25);
            this.bSearchBook.TabIndex = 2;
            this.bSearchBook.Text = "Find";
            this.bSearchBook.UseVisualStyleBackColor = true;
            this.bSearchBook.Click += new System.EventHandler(this.bSearchBook_Click);
            // 
            // booksList
            // 
            this.booksList.FormattingEnabled = true;
            this.booksList.ItemHeight = 14;
            this.booksList.Location = new System.Drawing.Point(98, 235);
            this.booksList.Name = "booksList";
            this.booksList.Size = new System.Drawing.Size(482, 200);
            this.booksList.TabIndex = 3;
            // 
            // iBookSearch
            // 
            this.iBookSearch.Location = new System.Drawing.Point(101, 142);
            this.iBookSearch.Name = "iBookSearch";
            this.iBookSearch.Size = new System.Drawing.Size(308, 21);
            this.iBookSearch.TabIndex = 4;
            // 
            // bAuthorsForm
            // 
            this.bAuthorsForm.Location = new System.Drawing.Point(635, 325);
            this.bAuthorsForm.Name = "bAuthorsForm";
            this.bAuthorsForm.Size = new System.Drawing.Size(116, 23);
            this.bAuthorsForm.TabIndex = 5;
            this.bAuthorsForm.Text = "go to Authors";
            this.bAuthorsForm.UseVisualStyleBackColor = true;
            this.bAuthorsForm.Click += new System.EventHandler(this.bAuthorsForm_Click);
            // 
            // BibliotecaMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.bAuthorsForm);
            this.Controls.Add(this.iBookSearch);
            this.Controls.Add(this.booksList);
            this.Controls.Add(this.bSearchBook);
            this.Controls.Add(this.lSearch);
            this.Controls.Add(this.title);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BibliotecaMainForm";
            this.Text = "BibliotecaMainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BibliotecaMainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.Button bSearchBook;
        private System.Windows.Forms.ListBox booksList;
        private System.Windows.Forms.TextBox iBookSearch;
        private System.Windows.Forms.Button bAuthorsForm;
    }
}

