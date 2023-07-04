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
    public partial class frmChangePin : Form
    {
        clsClient _Client;
        public frmChangePin(clsClient Client)
        {
            InitializeComponent();

            _Client = Client;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (_Client.UpdatePinCode(txtNewPin.Text))
            {
                if(MessageBox.Show("Pin Code Updated Successfully","",MessageBoxButtons.OK)==DialogResult.OK)
                {
                    this.Close();
                }
            }


        }

      
    }
}
