using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;

namespace BankFormProject
{
    public partial class Form1 : Form
    {
        private int ClientID = 0;
        public Form1()
        {
            InitializeComponent();
        }

      
    

       

        private void Form1_Load(object sender, EventArgs e)
        {
          //  kryptonDataGridView1.DataSource = clsClient.GetAllClients();
        }

        private void btnLogIn_Click_1(object sender, EventArgs e)
        {
            if (!clsClient.IsExist(txtAccountNumber.Text))
            {
                MessageBox.Show("Client Not Found");
            }

            else if (!clsClient.LogIn(Convert.ToString(txtAccountNumber.Text), Convert.ToString(txtPinCode.Text)))
            {

                MessageBox.Show("User Name or password Are incorrect");


            }
            else
            {
                Form frm = new frmTransactions(clsClient.Find(txtAccountNumber.Text));

                frm.ShowDialog();
            }

        }

     

    
    }
}
