using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodDemo
{
    public partial class Authentification_Form : Form
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;initial Catalog='gestionstock';username='root';password=");
        DataTable table = new DataTable();
        MySqlDataAdapter adapter;
        public Authentification_Form()
        {
            InitializeComponent();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            //adapter = new MySqlDataAdapter("SELECT UserName,Password FROM user WHERE UserName = '" + TUsername.Text + "'AND Password'" + TPassword.Text + "'", connection);
            adapter = new MySqlDataAdapter("SELECT `UserName`, `Password` FROM `user` WHERE `UserName` = '" + TUsername.Text + "' AND `password` = '" + TPassword.Text + "'", connection);
            adapter.Fill(table);
            if (table.Rows.Count <= 0)
            {
                MessageBox.Show("There is no user in the database, please add one!!");
                LError.Show();
                LError.Text = "Invalide Username or Password !!";
                LError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
            table.Clear();
        }

        private void Authentification_Form_Load(object sender, EventArgs e)
        {
            LError.Hide();
        }
    }
}
