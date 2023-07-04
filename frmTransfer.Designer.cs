namespace BankFormProject
{
    partial class frmTransfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReceiverAccNum = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtTransferAmount = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnProceed = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(180, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receiver Account Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(243, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "Transfer Amount";
            // 
            // txtReceiverAccNum
            // 
            this.txtReceiverAccNum.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtReceiverAccNum.Location = new System.Drawing.Point(238, 207);
            this.txtReceiverAccNum.MaxLength = 10;
            this.txtReceiverAccNum.Name = "txtReceiverAccNum";
            this.txtReceiverAccNum.Size = new System.Drawing.Size(246, 50);
            this.txtReceiverAccNum.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtReceiverAccNum.StateActive.Border.Rounding = 20;
            this.txtReceiverAccNum.StateActive.Border.Width = 1;
            this.txtReceiverAccNum.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverAccNum.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiverAccNum.TabIndex = 14;
            this.txtReceiverAccNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.txtTransferAmount.Location = new System.Drawing.Point(238, 363);
            this.txtTransferAmount.MaxLength = 5;
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(246, 50);
            this.txtTransferAmount.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtTransferAmount.StateActive.Border.Rounding = 20;
            this.txtTransferAmount.StateActive.Border.Width = 1;
            this.txtTransferAmount.StateActive.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferAmount.StateNormal.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransferAmount.TabIndex = 15;
            this.txtTransferAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnProceed
            // 
            this.btnProceed.Location = new System.Drawing.Point(257, 472);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(208, 68);
            this.btnProceed.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnProceed.StateCommon.Border.Rounding = 25;
            this.btnProceed.StateCommon.Border.Width = 1;
            this.btnProceed.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnProceed.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnProceed.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceed.TabIndex = 16;
            this.btnProceed.Values.Text = "Proceed";
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::BankFormProject.Properties.Resources.kisspng_world_bank_finance_financial_services_internationa_cognitive_5b4acb5cc40606_3199867015316283808029;
            this.pictureBox1.Location = new System.Drawing.Point(3, -18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(731, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProceed);
            this.Controls.Add(this.txtTransferAmount);
            this.Controls.Add(this.txtReceiverAccNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTransfer";
            this.Text = "Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtReceiverAccNum;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtTransferAmount;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnProceed;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}