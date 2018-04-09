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
    public partial class ClientManager : UserControl
    {
        //database connection string
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;initial Catalog='gestionstock';username='root';password=");
        public ClientManager()
        {
            InitializeComponent();
        }
        //open connection
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
                MySqlCommand command = new MySqlCommand(query,connection);
                if (command.ExecuteNonQuery()==1)
                {
                    Console.WriteLine("query executed succesfully!!");
                }
                else
                {
                    Console.WriteLine("query Failed!!");
                    MessageBox.Show("not !!");
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
        private void ClientDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            TClienID.Text = ClientDataGrid.CurrentRow.Cells[0].Value.ToString();
            TNom.Text = ClientDataGrid.CurrentRow.Cells[1].Value.ToString();
            TPrenom.Text = ClientDataGrid.CurrentRow.Cells[2].Value.ToString();
            TTEL.Text = ClientDataGrid.CurrentRow.Cells[3].Value.ToString();
            TEmail.Text = ClientDataGrid.CurrentRow.Cells[4].Value.ToString();
            TCity.Text = ClientDataGrid.CurrentRow.Cells[5].Value.ToString();
        }
        private void BAdd_Click(object sender, EventArgs e)
        {
            string InsertSqlQuery = "INSERT INTO Client(Name_Client,prenom_Client,Tel_Client,Email_Client,City_Client) VALUES('" + TNom.Text + "','" + TPrenom.Text + "','" + TTEL.Text + "','" + TEmail.Text + "','" + TCity.Text + "')";
            ExecuteQuery(InsertSqlQuery);
            GridLoad();
        }
        private void BEdit_Click(object sender, EventArgs e)
        {
            string UpdateSqlQuery = "UPDATE Client SET Name_Client='" + TNom.Text + "',prenom_Client='" + TPrenom.Text + "',Tel_Client='" + TTEL.Text + "',Email_Client='" + TEmail.Text + "',City_Client='" + TCity.Text + "' WHERE id_Client =" + TClienID.Text;
            ExecuteQuery(UpdateSqlQuery);
            GridLoad();
        }
        private void BDelete_Click(object sender, EventArgs e)
        {
            string DeleteSqlQuery = "DELETE FROM Client WHERE Id_Client =" +TClienID.Text;
            ExecuteQuery(DeleteSqlQuery);
            GridLoad();
        }
        //datagrid load data when the usercontrols load
        private void ClientManager_Load(object sender, EventArgs e)
        {
            //clearing the forms
            //to refresh the datagrid
            searchData("");
            GridLoad();
        }
        //function refresh datagrid
        public void GridLoad()
        {
            //the query to load data from the database
            string query = "SELECT * FROM Client";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            //filling the datagrid with data from the database
            adapter.Fill(table);
            ClientDataGrid.DataSource = table;
        }
        public void searchData(string valueToSearch)
        {
            string dataReaderQuery = "SELECT * FROM Client WHERE Name_Client LIKE '%" + TSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(dataReaderQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ClientDataGrid.DataSource = table;
        }
        private void BSearch_Click(object sender, EventArgs e)
        {
            string valueToSearch = TSearch.Text.ToString();
            searchData(valueToSearch);
           
        }
    }
}
