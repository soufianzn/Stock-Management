using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FastFoodDemo
{
    public partial class CommandUserControl : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;initial Catalog='gestionstock';username='root';password=");
        public CommandUserControl()
        {
            InitializeComponent();
        }
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        //close connection
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        //execute query function
        public void ExecuteQuery(String query)
        {
            try
            {
                OpenConnection();
                MySqlCommand command = new MySqlCommand(query, connection);
                if (command.ExecuteNonQuery() == 1)
                {
                    Console.WriteLine("query executed succesfully!!");
                }
                else
                {
                    Console.WriteLine("query Failed!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public void GridLoad()
        {
            //the query to load data from the database
            string query = "SELECT * FROM Commande";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            //filling the datagrid with data from the database
            adapter.Fill(table);
            //ClientDataGrid.DataSource = table;
        }
        private void CommandeDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            id_Commande.Text = CommandeDataGrid.CurrentRow.Cells[0].Value.ToString();
            Date_Commande.Text = CommandeDataGrid.CurrentRow.Cells[1].Value.ToString();
            TCValidation.Text = CommandeDataGrid.CurrentRow.Cells[2].Value.ToString();
        }

        private void BAddCommande_Click(object sender, EventArgs e)
        {
            string InsertSqlQuery = "INSERT INTO Commande(date_Commande,validation_commande) VALUES('" + Date_Commande.Text + "','" + TCValidation.Text +"')";
            ExecuteQuery(InsertSqlQuery);
            GridLoad();
        }

        private void BEditCommande_Click(object sender, EventArgs e)
        {
            string UpdateSqlQuery = "UPDATE Commande SET date_Commande='" + Date_Commande.Text + "',validation_commande='" + TCValidation.Text + "' WHERE Num_Commande =" + id_Commande.Text;
            ExecuteQuery(UpdateSqlQuery);
            GridLoad();
        }

        private void BDeleteCommande_Click(object sender, EventArgs e)
        {
            string DeleteSqlQuery = "DELETE FROM Commande WHERE Num_Commande =" + id_Commande.Text;
            ExecuteQuery(DeleteSqlQuery);
            GridLoad();
        }

        private void BSearchCommande_Click(object sender, EventArgs e)
        {
            string valueToSearch = TCSearch.Text.ToString();
            searchData(valueToSearch);
        }
        public void searchData(string valueToSearch)
        {
            string dataReaderQuery = "SELECT * FROM Commande WHERE date_Commande LIKE '%" + TCSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(dataReaderQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            CommandeDataGrid.DataSource = table;
        }

        private void CommandUserControl_Load(object sender, EventArgs e)
        {
            searchData("");
            GridLoad();
        }
    }
}
