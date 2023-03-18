
namespace connectToSQLserver
{
    partial class Payments
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
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.txtpayment = new System.Windows.Forms.TextBox();
            this.txtcashreseived = new System.Windows.Forms.TextBox();
            this.txtcashreturned = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.txtdiscountprice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbodiscount = new System.Windows.Forms.ComboBox();
            this.btnpay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txttotalamount
            // 
            this.txttotalamount.Location = new System.Drawing.Point(304, 99);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.ReadOnly = true;
            this.txttotalamount.Size = new System.Drawing.Size(209, 22);
            this.txttotalamount.TabIndex = 0;
            // 
            // txtpayment
            // 
            this.txtpayment.Location = new System.Drawing.Point(304, 225);
            this.txtpayment.Name = "txtpayment";
            this.txtpayment.ReadOnly = true;
            this.txtpayment.Size = new System.Drawing.Size(209, 22);
            this.txtpayment.TabIndex = 1;
            // 
            // txtcashreseived
            // 
            this.txtcashreseived.Location = new System.Drawing.Point(304, 263);
            this.txtcashreseived.Name = "txtcashreseived";
            this.txtcashreseived.Size = new System.Drawing.Size(209, 22);
            this.txtcashreseived.TabIndex = 2;
            this.txtcashreseived.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtcashreseived_KeyUp);
            // 
            // txtcashreturned
            // 
            this.txtcashreturned.Location = new System.Drawing.Point(304, 302);
            this.txtcashreturned.Name = "txtcashreturned";
            this.txtcashreturned.ReadOnly = true;
            this.txtcashreturned.Size = new System.Drawing.Size(209, 22);
            this.txtcashreturned.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(304, 184);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(209, 22);
            this.textBox6.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(136, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Amount";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Discount.Location = new System.Drawing.Point(136, 140);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(71, 17);
            this.Discount.TabIndex = 7;
            this.Discount.Text = "Discount";
            // 
            // txtdiscountprice
            // 
            this.txtdiscountprice.AutoSize = true;
            this.txtdiscountprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscountprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtdiscountprice.Location = new System.Drawing.Point(136, 184);
            this.txtdiscountprice.Name = "txtdiscountprice";
            this.txtdiscountprice.Size = new System.Drawing.Size(122, 17);
            this.txtdiscountprice.TabIndex = 8;
            this.txtdiscountprice.Text = "Discoount Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(136, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Payment";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(136, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cash Received";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(136, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cash Returned";
            // 
            // cbodiscount
            // 
            this.cbodiscount.FormattingEnabled = true;
            this.cbodiscount.Items.AddRange(new object[] {
            "0%",
            "5%",
            "10%",
            "15%",
            "20%",
            "30%",
            "35%",
            "50%",
            ""});
            this.cbodiscount.Location = new System.Drawing.Point(304, 140);
            this.cbodiscount.Name = "cbodiscount";
            this.cbodiscount.Size = new System.Drawing.Size(209, 24);
            this.cbodiscount.TabIndex = 12;
            this.cbodiscount.SelectedIndexChanged += new System.EventHandler(this.cbodiscount_SelectedIndexChanged);
            // 
            // btnpay
            // 
            this.btnpay.BackColor = System.Drawing.Color.Magenta;
            this.btnpay.Enabled = false;
            this.btnpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnpay.Location = new System.Drawing.Point(421, 355);
            this.btnpay.Name = "btnpay";
            this.btnpay.Size = new System.Drawing.Size(61, 33);
            this.btnpay.TabIndex = 13;
            this.btnpay.Text = "Pay";
            this.btnpay.UseVisualStyleBackColor = false;
            this.btnpay.Click += new System.EventHandler(this.btnpay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 44);
            this.label2.TabIndex = 14;
            this.label2.Text = "Payment";
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Location = new System.Drawing.Point(304, 367);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(79, 21);
            this.chkPreview.TabIndex = 15;
            this.chkPreview.Text = "Preview";
            this.chkPreview.UseVisualStyleBackColor = true;
         
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(752, 432);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnpay);
            this.Controls.Add(this.cbodiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdiscountprice);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtcashreturned);
            this.Controls.Add(this.txtcashreseived);
            this.Controls.Add(this.txtpayment);
            this.Controls.Add(this.txttotalamount);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Payments";
            this.Text = "Payments";
            this.Load += new System.EventHandler(this.Payments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.TextBox txtpayment;
        private System.Windows.Forms.TextBox txtcashreseived;
        private System.Windows.Forms.TextBox txtcashreturned;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label txtdiscountprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbodiscount;
        private System.Windows.Forms.Button btnpay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPreview;
    }
}