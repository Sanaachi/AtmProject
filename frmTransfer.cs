using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankFormProject
{
    public partial class frmTransfer : Form
    {

        clsClient _Client;
        public frmTransfer(clsClient Client)
        {
            InitializeComponent();

            _Client = Client;
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {

            if (clsClient.IsExist(txtReceiverAccNum.Text))
            {

                if (MessageBox.Show($"Are You Sure You Want To Transer {txtTransferAmount.Text} to {txtReceiverAccNum.Text}",
                    "Click ok To Proceed", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (_Client.Transfer(txtReceiverAccNum.Text, Convert.ToInt32(txtTransferAmount.Text)))
                    {

                        MessageBox.Show("Transfer Successfull");
                    }

                    Form frm = new frmTransactions(_Client);

                    frm.ShowDialog();
                }


            }
            else
            {
                MessageBox.Show("No Account With This Account Number Exists");
            }

        }
    }
}
