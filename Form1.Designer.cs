namespace BankFormProject
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAccountNumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtPinCode = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnLogIn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtAccountNumber.Location = new System.Drawing.Point(285, 208);
            this.txtAccountNumber.MaxLength = 10;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(246, 50);
            this.txtAccountNumber.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAccountNumber.StateActive.Border.Rounding = 20;
            this.txtAccountNumber.StateActive.Border.Width = 1;
            this.txtAccountNumber.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNumber.TabIndex = 6;
            this.txtAccountNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPinCode
            // 
            this.txtPinCode.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtPinCode.Location = new System.Drawing.Point(285, 348);
            this.txtPinCode.MaxLength = 4;
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.PasswordChar = '●';
            this.txtPinCode.Size = new System.Drawing.Size(246, 50);
            this.txtPinCode.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPinCode.StateActive.Border.Rounding = 20;
            this.txtPinCode.StateActive.Border.Width = 1;
            this.txtPinCode.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.TabIndex = 7;
            this.txtPinCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPinCode.UseSystemPasswordChar = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(309, 465);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(208, 68);
            this.btnLogIn.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnLogIn.StateCommon.Border.Rounding = 25;
            this.btnLogIn.StateCommon.Border.Width = 1;
            this.btnLogIn.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnLogIn.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnLogIn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.Values.Text = "Log in";
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click_1);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(278, 137);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel1.Size = new System.Drawing.Size(279, 44);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "Account Number";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(323, 285);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue;
            this.kryptonLabel2.Size = new System.Drawing.Size(162, 44);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Pin Code";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BankFormProject.Properties.Resources.kisspng_world_bank_finance_financial_services_internationa_cognitive_5b4acb5cc40606_3199867015316283808029;
            this.pictureBox1.Location = new System.Drawing.Point(-14, -37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnLogIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(801, 649);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.txtAccountNumber);
            this.Name = "Form1";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtAccountNumber;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPinCode;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogIn;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

