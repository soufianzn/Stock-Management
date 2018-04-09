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
namespace FastFoodDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            //firstCustomControl1.BringToFront();
            mySecondCustmControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            mySecondCustmControl1.BringToFront();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    //admin panel
        //    SidePanel.Height = button2.Height;
        //    SidePanel.Top = button2.Top;
                      
        //}
        
        private void button4_Click(object sender, EventArgs e)
        {
            //product
            SidePanel.Height = button4.Height;
            SidePanel.Top = button4.Top;
            productManager1.BringToFront();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    //Stock
        //    SidePanel.Height = button5.Height;
        //    SidePanel.Top = button5.Top;
        //    stockManager1.BringToFront();
        //}

        private void button6_Click(object sender, EventArgs e)
        {
            //client
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            clientManager1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //provider
            SidePanel.Height = button7.Height;
            SidePanel.Top = button7.Top;
            providerManager1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //commande
            SidePanel.Height = button3.Height;
            SidePanel.Top = button3.Top;
            commandUserControl1.BringToFront();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Youssef Oussellam");
        }
    }
}
