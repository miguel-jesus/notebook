namespace W01_Biblioteca
{
    partial class AuthorsFinder
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
            this.bBooksForm = new System.Windows.Forms.Button();
            this.AuthorsList = new System.Windows.Forms.ListBox();
            this.iAuthorSearch = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.lSearch = new System.Windows.Forms.Label();
            this.bSearchAuthor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bBooksForm
            // 
            this.bBooksForm.Location = new System.Drawing.Point(634, 296);
            this.bBooksForm.Name = "bBooksForm";
            this.bBooksForm.Size = new System.Drawing.Size(108, 23);
            this.bBooksForm.TabIndex = 0;
            this.bBooksForm.Text = "go to Books";
            this.bBooksForm.UseVisualStyleBackColor = true;
            this.bBooksForm.Click += new System.EventHandler(this.bBooksForm_Click);
            // 
            // AuthorsList
            // 
            this.AuthorsList.FormattingEnabled = true;
            this.AuthorsList.Location = new System.Drawing.Point(162, 254);
            this.AuthorsList.Name = "AuthorsList";
            this.AuthorsList.Size = new System.Drawing.Size(413, 121);
            this.AuthorsList.TabIndex = 1;
            // 
            // iAuthorSearch
            // 
            this.iAuthorSearch.Location = new System.Drawing.Point(162, 126);
            this.iAuthorSearch.Name = "iAuthorSearch";
            this.iAuthorSearch.Size = new System.Drawing.Size(327, 20);
            this.iAuthorSearch.TabIndex = 2;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(154, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(400, 46);
            this.title.TabIndex = 3;
            this.title.Text = "CIFPPauCasesnoves";
            // 
            // lSearch
            // 
            this.lSearch.AutoSize = true;
            this.lSearch.Font = new System.Drawing.Font("Lato", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSearch.Location = new System.Drawing.Point(159, 89);
            this.lSearch.Name = "lSearch";
            this.lSearch.Size = new System.Drawing.Size(72, 13);
            this.lSearch.TabIndex = 4;
            this.lSearch.Text = "searchAuthor";
            // 
            // bSearchAuthor
            // 
            this.bSearchAuthor.Location = new System.Drawing.Point(539, 123);
            this.bSearchAuthor.Name = "bSearchAuthor";
            this.bSearchAuthor.Size = new System.Drawing.Size(75, 23);
            this.bSearchAuthor.TabIndex = 5;
            this.bSearchAuthor.Text = "Find";
            this.bSearchAuthor.UseVisualStyleBackColor = true;
            this.bSearchAuthor.Click += new System.EventHandler(this.bSearchAuthor_Click);
            // 
            // AuthorsFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSearchAuthor);
            this.Controls.Add(this.lSearch);
            this.Controls.Add(this.title);
            this.Controls.Add(this.iAuthorSearch);
            this.Controls.Add(this.AuthorsList);
            this.Controls.Add(this.bBooksForm);
            this.Name = "AuthorsFinder";
            this.Text = "AuthorsFinder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AuthorsFinder_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bBooksForm;
        private System.Windows.Forms.ListBox AuthorsList;
        private System.Windows.Forms.TextBox iAuthorSearch;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label lSearch;
        private System.Windows.Forms.Button bSearchAuthor;
    }
}