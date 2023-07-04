namespace BankFormProject
{
    partial class frmTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWithdraw = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnDeposit = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnTransfer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnChangePin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblClientName = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.lblClientBalance = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(12, 228);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(310, 90);
            this.btnWithdraw.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnWithdraw.StateCommon.Border.Rounding = 25;
            this.btnWithdraw.StateCommon.Border.Width = 1;
            this.btnWithdraw.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnWithdraw.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnWithdraw.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.TabIndex = 9;
            this.btnWithdraw.Values.Text = "Withdraw";
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(478, 228);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(310, 90);
            this.btnDeposit.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDeposit.StateCommon.Border.Rounding = 25;
            this.btnDeposit.StateCommon.Border.Width = 1;
            this.btnDeposit.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnDeposit.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnDeposit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeposit.TabIndex = 10;
            this.btnDeposit.Values.Text = "Deposit";
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(19, 370);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(310, 90);
            this.btnTransfer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnTransfer.StateCommon.Border.Rounding = 25;
            this.btnTransfer.StateCommon.Border.Width = 1;
            this.btnTransfer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnTransfer.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnTransfer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.TabIndex = 11;
            this.btnTransfer.Values.Text = "Transfer";
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnChangePin
            // 
            this.btnChangePin.Location = new System.Drawing.Point(478, 370);
            this.btnChangePin.Name = "btnChangePin";
            this.btnChangePin.Size = new System.Drawing.Size(310, 90);
            this.btnChangePin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnChangePin.StateCommon.Border.Rounding = 25;
            this.btnChangePin.StateCommon.Border.Width = 1;
            this.btnChangePin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnChangePin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnChangePin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePin.TabIndex = 12;
            this.btnChangePin.Values.Text = "Change Pin";
            this.btnChangePin.Click += new System.EventHandler(this.btnChangePinCode_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(18, 147);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.kryptonLabel1.Size = new System.Drawing.Size(153, 52);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 13;
            this.kryptonLabel1.Values.Text = "Balance:";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(289, 23);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.kryptonLabel2.Size = new System.Drawing.Size(169, 52);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 14;
            this.kryptonLabel2.Values.Text = "Welcome";
            // 
            // lblClientName
            // 
            this.lblClientName.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblClientName.Location = new System.Drawing.Point(453, 27);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.lblClientName.Size = new System.Drawing.Size(90, 44);
            this.lblClientName.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.lblClientName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.TabIndex = 15;
            this.lblClientName.Values.Text = "------";
            // 
            // lblClientBalance
            // 
            this.lblClientBalance.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.lblClientBalance.Location = new System.Drawing.Point(177, 147);
            this.lblClientBalance.Name = "lblClientBalance";
            this.lblClientBalance.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.lblClientBalance.Size = new System.Drawing.Size(90, 44);
            this.lblClientBalance.StateCommon.ShortText.Color1 = System.Drawing.Color.LawnGreen;
            this.lblClientBalance.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientBalance.TabIndex = 16;
            this.lblClientBalance.Values.Text = "------";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BankFormProject.Properties.Resources.kisspng_world_bank_finance_financial_services_internationa_cognitive_5b4acb5cc40606_3199867015316283808029;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblClientBalance);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnChangePin);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnWithdraw);
            this.Name = "frmTransactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnWithdraw;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnDeposit;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnTransfer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnChangePin;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblClientName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel lblClientBalance;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}