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
    public partial class ProductManager : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;Initial Catalog='gestionstock';username='root';password=");

        public ProductManager()
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
        public void GridLoadProduct()
        {
            //the query to load data from the database
            string query = "SELECT * FROM Product";
            DataTable tableProduct = new DataTable();
            MySqlDataAdapter adapterProduct = new MySqlDataAdapter(query, connection);
            //filling the datagrid with data from the database
            adapterProduct.Fill(tableProduct);
            ProductDataGrid.DataSource = tableProduct;
        }
        private void BInsert_Click(object sender, EventArgs e)
        {
            string InsertSqlQuery = "INSERT INTO Product(label_product,label_category,SellPrice_product,BuyPrice_product,Amount_StockP) VALUES('" + TPName.Text + "','" + TPCategory.Text + "','" + TPSell.Text + "','" + TPBuy.Text + "','" + TPStockAmount.Text + "')";
            ExecuteQuery(InsertSqlQuery);
            GridLoadProduct();
        }

        private void BDelete_Click(object sender, EventArgs e)
        {
            string DeleteSqlQuery = "DELETE FROM Product WHERE Id_product =" + TProductID.Text;
            ExecuteQuery(DeleteSqlQuery);
            GridLoadProduct();
        }
        private void BModify_Click(object sender, EventArgs e)
        {
            string UpdateSqlQuery = "UPDATE Product SET label_product='" + TPName.Text + "',label_category='" + TPCategory.Text + "',SellPrice_product='" + TPSell.Text + "',BuyPrice_product='" + TPBuy.Text + "',Amount_StockP='" + TPStockAmount.Text + "' WHERE id_product =" + TProductID.Text;
            ExecuteQuery(UpdateSqlQuery);
            GridLoadProduct();
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            string valueToSearch = TPSearch.Text.ToString();
            searchData(valueToSearch);
        }

        
        public void searchData(string valueToSearch)
        {
            string dataReaderQuery = "SELECT * FROM Product WHERE label_product LIKE '%" + TPSearch.Text + "%'";
            MySqlCommand command = new MySqlCommand(dataReaderQuery, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            ProductDataGrid.DataSource = table;
        }

        private void ProductDataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            TProductID.Text = ProductDataGrid.CurrentRow.Cells[0].Value.ToString();
            TPName.Text = ProductDataGrid.CurrentRow.Cells[1].Value.ToString();
            TPCategory.Text = ProductDataGrid.CurrentRow.Cells[2].Value.ToString();
            TPSell.Text = ProductDataGrid.CurrentRow.Cells[3].Value.ToString();
            TPBuy.Text = ProductDataGrid.CurrentRow.Cells[4].Value.ToString();
            TPStockAmount.Text = ProductDataGrid.CurrentRow.Cells[5].Value.ToString();
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            GridLoadProduct();
            searchData("");
        }
    }
}
