using BankBusinessLayer;
using ComponentFactory.Krypton.Toolkit;
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
    public partial class frmWithdrawDeposit : Form
    {
      public  enum enMode { Deposit=1,Withdraw=2};

         public enMode _Mode;

        clsClient _Client;
      private   double amount;

        public frmWithdrawDeposit(clsClient Client,enMode Mode)
        {
            InitializeComponent();


            _Client = Client;

            _Mode = Mode;


            switch (_Mode)
            {

                case enMode.Withdraw:

                    this.Text = "Withdraw";

                    lblTitle.Text = "Select Withdrawal Amount";

                    lblCustomNote.Text = "Enter Custom Withdrawal Amount";


                    break;

                case enMode.Deposit:

                    this.Text = "Deposit";

                    lblTitle.Text = "Select Deposit Amount";

                    lblCustomNote.Text = "Enter Custom Deposit Amount";
                    break;


            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            KryptonButton btn = (KryptonButton) sender;


            switch (_Mode) {

                case enMode.Withdraw:



                    if (MessageBox.Show("Are You Sure You Want To Withdraw", "",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (_Client.Balance < Convert.ToInt32(btn.Tag))
                        {

                            MessageBox.Show("Balance Is not Enough", "insufficient Balance");
                        }


                       else if (_Client.Withdraw(Convert.ToInt32(btn.Tag)))
                        {

                            if (MessageBox.Show("Withdrawed Successfully", "Please Receive Your Money", MessageBoxButtons.OK) == DialogResult.OK)
                            {

                                this.Close();
                            }
                        }

                    }
                    break;


                case enMode.Deposit:



                    if (MessageBox.Show($"Are You Sure You Want To Deposit", "",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        if (_Client.Deposit(Convert.ToInt32(btn.Tag)))
                        {

                            if (MessageBox.Show("Deposited Successfully", " ", MessageBoxButtons.OK) == DialogResult.OK)
                            {

                                this.Close();
                            }
                        }

                    }

                    break;
            }

           




        }

        

        private void btnProceed_Click(object sender, EventArgs e)
        {
            


            switch (_Mode)
            {


                case enMode.Withdraw:


                    if(Convert.ToInt32(txtWithdrawalamount.Text) % 5 != 0)
                    {
                        MessageBox.Show("Withdraw Amount Has To Be From Number 5 Multiblications", "",
                        MessageBoxButtons.OK);
                        return;

                    }

                    if (MessageBox.Show("Are You Sure You Want To Withdraw", "",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                        if (_Client.Balance < Convert.ToInt32(txtWithdrawalamount.Text))
                        {
                            MessageBox.Show("Balance Is not Enough");
                        }



                        else if (_Client.Withdraw(Convert.ToInt32(txtWithdrawalamount.Text))) {


                            if (MessageBox.Show("Withdrawed Successfully", "Please Receive Your Money", MessageBoxButtons.OK) == DialogResult.OK)
                            {

                                this.Close();

                            }
                           
                           
                        }

                    }

                 
                    


                    break;




                case enMode.Deposit:



                    if (MessageBox.Show("Are You Sure You Want To Deposit", "",
                        MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {

                        if (_Client.Deposit(Convert.ToInt32(txtWithdrawalamount.Text)))
                        {

                            if (MessageBox.Show("Deposit Successfully", "Thank You", MessageBoxButtons.OK) == DialogResult.OK)
                            {

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Deposit Failed", "Please Try Again Later", MessageBoxButtons.OK) ;

                            }
                        }

                    }

                    break;




            }


                


        }

        private void kryptonCheckButton1_Click(object sender, EventArgs e)
        {

            if (btnCustomCheck.Checked)
            {

                lblTitle.Visible = false;
                btn20 .Visible=false;
                btn50 .Visible=false;
                btn100.Visible=false;
                btn200.Visible=false;
                btn400.Visible=false;
                btn600.Visible=false;

                lblCustomNote.Visible = true;

                txtWithdrawalamount.Visible = true;

                btnProceed.Visible = true;

            }
            else
            {
                lblTitle.Visible = true;
                btn20. Visible =  true;
                btn50. Visible =  true;
                btn100.Visible = true;
                btn200.Visible = true;
                btn400.Visible = true;
                btn600.Visible = true;

                lblCustomNote.Visible = false;

                txtWithdrawalamount.Visible = false;

                btnProceed.Visible = false;

            }






        }

        private void frmWithdrawDeposit_Load(object sender, EventArgs e)
        {



        }
    }
}
