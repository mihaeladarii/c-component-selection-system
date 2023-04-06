namespace Program
{
    partial class InvoiceForm
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
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.UnitNo = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.DepositLabel = new System.Windows.Forms.Label();
            this.FinalPriceLabel = new System.Windows.Forms.Label();
            this.unitNoText = new System.Windows.Forms.TextBox();
            this.remLabel = new System.Windows.Forms.Label();
            this.changeBuildBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitPriceLabel.Location = new System.Drawing.Point(69, 90);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(205, 37);
            this.unitPriceLabel.TabIndex = 0;
            this.unitPriceLabel.Text = "Price per Unit: £";
            // 
            // UnitNo
            // 
            this.UnitNo.AutoSize = true;
            this.UnitNo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitNo.Location = new System.Drawing.Point(69, 9);
            this.UnitNo.Name = "UnitNo";
            this.UnitNo.Size = new System.Drawing.Size(172, 37);
            this.UnitNo.TabIndex = 1;
            this.UnitNo.Text = "Unit number:";
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vatLabel.Location = new System.Drawing.Point(84, 153);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(157, 37);
            this.vatLabel.TabIndex = 2;
            this.vatLabel.Text = "VAT(20%): £";
            // 
            // DepositLabel
            // 
            this.DepositLabel.AutoSize = true;
            this.DepositLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepositLabel.Location = new System.Drawing.Point(69, 216);
            this.DepositLabel.Name = "DepositLabel";
            this.DepositLabel.Size = new System.Drawing.Size(196, 37);
            this.DepositLabel.TabIndex = 3;
            this.DepositLabel.Text = "Deposit 10%: £";
            // 
            // FinalPriceLabel
            // 
            this.FinalPriceLabel.AutoSize = true;
            this.FinalPriceLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FinalPriceLabel.Location = new System.Drawing.Point(84, 287);
            this.FinalPriceLabel.Name = "FinalPriceLabel";
            this.FinalPriceLabel.Size = new System.Drawing.Size(165, 37);
            this.FinalPriceLabel.TabIndex = 4;
            this.FinalPriceLabel.Text = "Final Price: £";
            // 
            // unitNoText
            // 
            this.unitNoText.Location = new System.Drawing.Point(99, 49);
            this.unitNoText.Name = "unitNoText";
            this.unitNoText.Size = new System.Drawing.Size(100, 23);
            this.unitNoText.TabIndex = 5;
            this.unitNoText.TextChanged += new System.EventHandler(this.unitNoText_TextChanged);
            // 
            // remLabel
            // 
            this.remLabel.AutoSize = true;
            this.remLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.remLabel.Location = new System.Drawing.Point(84, 359);
            this.remLabel.Name = "remLabel";
            this.remLabel.Size = new System.Drawing.Size(171, 37);
            this.remLabel.TabIndex = 6;
            this.remLabel.Text = "Remaining: £";
            // 
            // changeBuildBtn
            // 
            this.changeBuildBtn.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changeBuildBtn.Location = new System.Drawing.Point(428, 153);
            this.changeBuildBtn.Name = "changeBuildBtn";
            this.changeBuildBtn.Size = new System.Drawing.Size(272, 171);
            this.changeBuildBtn.TabIndex = 7;
            this.changeBuildBtn.Text = "Change components";
            this.changeBuildBtn.UseVisualStyleBackColor = true;
            this.changeBuildBtn.Click += new System.EventHandler(this.changeBuildBtn_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(781, 518);
            this.Controls.Add(this.changeBuildBtn);
            this.Controls.Add(this.remLabel);
            this.Controls.Add(this.unitNoText);
            this.Controls.Add(this.FinalPriceLabel);
            this.Controls.Add(this.DepositLabel);
            this.Controls.Add(this.vatLabel);
            this.Controls.Add(this.UnitNo);
            this.Controls.Add(this.unitPriceLabel);
            this.Name = "InvoiceForm";
            this.Text = "Invoice Form";
            this.Load += new System.EventHandler(this.InvoiceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label unitPriceLabel;
        private Label UnitNo;
        private Label vatLabel;
        private Label DepositLabel;
        private Label FinalPriceLabel;
        private TextBox unitNoText;
        private Label remLabel;
        private Button changeBuildBtn;
    }
}