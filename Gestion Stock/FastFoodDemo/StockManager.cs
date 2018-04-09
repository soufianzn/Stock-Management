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
    public partial class StockManager : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;initial Catalog='gestionstock';username='root';password=");
        public StockManager()
        {
            InitializeComponent();
        }
    }
}
