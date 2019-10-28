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

namespace UsuariosWinformUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string connectionString = "Server=localhost;Database=biblioteca;Uid=usuari;Pwd=seCret_16";
        private void button1_Click(object sender, EventArgs e)
        {
           //   Console.WriteLine("HOLA FUNCIONO?"); 
            //Console.WriteLine(iPassword.Text)
            if (iPassword.Text == iCPassword.Text)
            {
                MySqlConnection con = new MySqlConnection(connectionString);
                string sql = "SELECT MAX(ID_USR) FROM USUARIS";
             
                int newId = 0;
                try
                {
                    newId = con.Query<int>(sql).FirstOrDefault();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                   

                }


                string sql2 = "Insert INTO USUARIS(ID_USR,DNI_USR,NOM_USR,LLINATGE1,POB_USR,EMAIL_USR,PASSWORD) VALUES(" +
                $"{ newId + 1 } ,' { tNif.Text} ' ,'{  tName.Text }' , '{iLlinatge.Text  }',  '{iPueblo.Text }'," +
                $"'{iEmail.Text } ',  '{iPassword.Text }' )";
                //Console.WriteLine(sql2);
                //con.Execute(sql2);
                //con.Close();
                try
                {

                    var rowsAffected = con.Execute(sql2);

                    if (rowsAffected == 1)
                    {
                        //una ventana de dialogo
                        MessageBox.Show("User registered correctly", "User Manager", MessageBoxButtons.OK);

                        // "" es menos seguro que poner string.Empty
                        tNif.Text = string.Empty;
                        tName.Text = string.Empty;
                        iLlinatge.Text = string.Empty;
                        iPueblo.Text = string.Empty;
                        iEmail.Text = string.Empty;
                        iPassword.Text = string.Empty;
                        iCPassword.Text = string.Empty;

                    }

                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {

                    Console.WriteLine("Warning: Exception thrown " + ex.Message);

                }


                con.Close();


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<User> users = new List<User>();
            MySqlConnection con = new MySqlConnection(connectionString);
            if (tbName.Text == "")
            {
                MessageBox.Show("The User can't be null or empty.", "User Manager", MessageBoxButtons.OK);
            }
            else
            {
                string sql = $"SELECT DNI_USR, NOM_USR FROM USUARIS" +
                $" WHERE NOM_USR LIKE '%{tbName.Text}%'" +
                $" OR LLINATGE1 LIKE '%{tbName.Text}%'" +
                $" OR POB_USR LIKE '%{tbName.Text}%'";
                users = con.Query<User>(sql).ToList();
            }

            foreach (var user in users)
            {
                listBox1.Items.Add(user.DNI_USR + " " + user.NOM_USR);
            }
            con.Close();
        }
    }
    }

