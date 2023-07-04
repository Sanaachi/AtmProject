namespace BankFormProject
{
    partial class frmChangePin
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
            this.txtNewPin = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnSave = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNewPin
            // 
            this.txtNewPin.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtNewPin.Location = new System.Drawing.Point(184, 250);
            this.txtNewPin.MaxLength = 4;
            this.txtNewPin.Name = "txtNewPin";
            this.txtNewPin.PasswordChar = '●';
            this.txtNewPin.Size = new System.Drawing.Size(246, 50);
            this.txtNewPin.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtNewPin.StateActive.Border.Rounding = 20;
            this.txtNewPin.StateActive.Border.Width = 1;
            this.txtNewPin.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPin.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPin.TabIndex = 13;
            this.txtNewPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNewPin.UseSystemPasswordChar = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(206, 387);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 68);
            this.btnSave.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 25;
            this.btnSave.StateCommon.Border.Width = 1;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSave.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.TabIndex = 14;
            this.btnSave.Values.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitlePanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(184, 156);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.kryptonLabel2.Size = new System.Drawing.Size(244, 52);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 15;
            this.kryptonLabel2.Values.Text = "Enter New Pin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BankFormProject.Properties.Resources.kisspng_world_bank_finance_financial_services_internationa_cognitive_5b4acb5cc40606_3199867015316283808029;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmChangePin
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(605, 535);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPin);
            this.Name = "frmChangePin";
            this.Text = "Change Pin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtNewPin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSave;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}