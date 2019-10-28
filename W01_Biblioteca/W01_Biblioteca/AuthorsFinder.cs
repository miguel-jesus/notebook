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
    public partial class AuthorsFinder : Form
    {
        private static string connectionString = "Server=localhost;Database=biblioteca;Uid=lector;Pwd=seCret_16;";
        public AuthorsFinder()
        {
            InitializeComponent();
        }

        private void bSearchAuthor_Click(object sender, EventArgs e)
        {
            List<Author> authors = new List<Author>();
            MySqlConnection connection = new MySqlConnection(connectionString);
            string sql = "select * from AUTORS" +
                $" WHERE NOM_AUT LIKE '%{iAuthorSearch.Text}%'";
            authors = connection.Query<Author>(sql).ToList();
            

            AuthorsList.DataSource = authors;
            AuthorsList.DisplayMember = "FullInfo";

            connection.Close();
        }

        private void bBooksForm_Click(object sender, EventArgs e)
        {
            this.Hide();


            //we will create a variable for open all the forms
            var forms = Application.OpenForms;


            //we do laps since we obtaine our form 
            foreach (Form form in forms)
            {
                if (form.Name == "BibliotecaMainForm")
                {
                    form.Show();
                }
            }
        }

        private void AuthorsFinder_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
