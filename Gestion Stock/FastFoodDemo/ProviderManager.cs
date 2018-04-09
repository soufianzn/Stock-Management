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
    public partial class ProviderManager : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;initial Catalog='gestionstock';username='root';password=");

        public ProviderManager()
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
            string query = "SELECT * FROM Provider";
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            //filling the datagrid with data from the database
            adapter.Fill(table);
            ProviderDataGrid.DataSource = table;
        }

        private void BPRAdd_Click(object sender, EventArgs e)
        {
            string InsertSqlQuery = "INSERT INTO Provider(Name_provider,Address_provider,City_provider,Tel_provider) VALUES('" + TPRName.Text + "','" + TPRAdresse.Text + "','" + TPRCity.Text + "','" + TPRPhone.Text + "')";
            ExecuteQuery(InsertSqlQuery);
            GridLoad();
        }
        private void BPREdit_Click(object sender, EventArgs e)
        {
            string UpdateSqlQuery = "UPDATE Provider SET Name_provider='" + TPRName.Text + "',Address_provider='" + TPRAdresse.Text + "',City_provider='" + TPRCity.Text + "',Tel_provider='" + TPRPhone.Text + "' WHERE id_provider =" + TPRID.Text;
            ExecuteQuery(UpdateSqlQuery);
            GridLoad();
        }

        private void BPRDelete_Click(object sender, EventArgs e)
        {
            string DeleteSqlQuery = "DELETE FROM Provider WHERE Id_Provider =" + TPRID.Text;
            ExecuteQuery(DeleteSqlQuery);
            GridLoad();
        }

        private void BPRSearch_Click(object sender, EventArgs e)
        {
            string valueToSearch = TPRSearch.Text.ToString();
            searchData(valueToSearch);
        }
        public void searchData(string valueToSearch)
        {
            string dataReaderQuery = "SELECT * FROM Provider WHERE Name_Provider LIKE '%" + TPRSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(dataReaderQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ProviderDataGrid.DataSource = table;
        }
        private void ProviderManager_Load(object sender, EventArgs e)
        {
            searchData("");
            GridLoad();
        }

        private void ProviderDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            TPRID.Text = ProviderDataGrid.CurrentRow.Cells[0].Value.ToString();
            TPRName.Text = ProviderDataGrid.CurrentRow.Cells[1].Value.ToString();
            TPRAdresse.Text = ProviderDataGrid.CurrentRow.Cells[2].Value.ToString();
            TPRCity.Text = ProviderDataGrid.CurrentRow.Cells[3].Value.ToString();
            TPRPhone.Text = ProviderDataGrid.CurrentRow.Cells[4].Value.ToString();
            
        }
    }
}
