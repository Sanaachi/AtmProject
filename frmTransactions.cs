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
    public partial class frmTransactions : Form
    {
        private clsClient _Client;
        clsPerson _person;

        

        public frmTransactions(clsClient Client)
        {
            InitializeComponent();

            

            _Client = Client;

            _person = clsPerson.Find(_Client.PersonId);

        }

        private  void _LoadInfo()
        {
            _Client = clsClient.Find(_Client.ID);

            lblClientName.Text = (_person.FirstName + "!");

            lblClientBalance.Text = (_Client.Balance.ToString() + "$");


        }

        private void frmTransactions_Load(object sender, EventArgs e)
        {
            

            _LoadInfo();


        }

     

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Form frm = new frmWithdrawDeposit(_Client, frmWithdrawDeposit.enMode.Deposit);

            frm.ShowDialog();

            _LoadInfo();

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            Form frm = new frmTransfer(_Client);

            frm.ShowDialog();

            _LoadInfo();

        }

        private void btnChangePinCode_Click(object sender, EventArgs e)
        {

            Form frm = new frmChangePin(_Client);

            frm.ShowDialog();

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Form frm = new frmWithdrawDeposit(_Client, frmWithdrawDeposit.enMode.Withdraw);

            frm.ShowDialog();

            _LoadInfo();
        }
    }
}
