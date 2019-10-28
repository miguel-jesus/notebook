using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Dapper;

namespace W01_Biblioteca
{
    public partial class BibliotecaMainForm : Form
    {
        //connection string to the DB
        private static string connectionString = "Server=localhost;Database=biblioteca;Uid=lector;Pwd=seCret_16;";
        public BibliotecaMainForm()
        {
            InitializeComponent();
        }


        private void bSearchBook_Click(object sender, EventArgs e)
        {
            //IMPORTANT when we do the book object must be the same that the database
            //its a list,then we do a book list
            List<Book> books = new List<Book>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = "select * from LLIBRES" +
                $" WHERE TITOL LIKE '%{iBookSearch.Text}%'";
            books = connection.Query<Book>(sql).ToList();
            //other ways to do the exercise

            //Console.WriteLine(books[5].TITOL);
            /* for(int i = 0; i < books.Count; i++)
             {
                listBox1.Items.Add(books[i].TITOL);
             }
             foreach(var book in books)
             {
                 listBox1.Items.Add(book.ID_LLIB+ "."+ book.TITOL);
             }*/

            booksList.DataSource = books;
            booksList.DisplayMember = "FullInfo";

            connection.Close();
        }
         private void bAuthorsForm_Click(object sender, EventArgs e)
         {
            // hide this form
            this.Hide();

           
            //we will create a variable for open all the forms
            var forms = Application.OpenForms;
            AuthorsFinder auth = new AuthorsFinder();
            auth.Show();
            
        }
        private void BibliotecaMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

       
    }
}
