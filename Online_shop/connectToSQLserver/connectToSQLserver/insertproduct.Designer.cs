
namespace connectToSQLserver
{
    partial class frminsertproduct
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
            this.txtbar = new System.Windows.Forms.TextBox();
            this.txtpro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpriceIn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpriceOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.picphoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bar Code";
            // 
            // txtbar
            // 
            this.txtbar.Location = new System.Drawing.Point(192, 45);
            this.txtbar.Name = "txtbar";
            this.txtbar.Size = new System.Drawing.Size(222, 22);
            this.txtbar.TabIndex = 1;
            // 
            // txtpro
            // 
            this.txtpro.Location = new System.Drawing.Point(192, 96);
            this.txtpro.Name = "txtpro";
            this.txtpro.Size = new System.Drawing.Size(222, 22);
            this.txtpro.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Name";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(192, 143);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(222, 22);
            this.txtqty.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // txtpriceIn
            // 
            this.txtpriceIn.Location = new System.Drawing.Point(192, 197);
            this.txtpriceIn.Name = "txtpriceIn";
            this.txtpriceIn.Size = new System.Drawing.Size(222, 22);
            this.txtpriceIn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price In";
            // 
            // txtpriceOut
            // 
            this.txtpriceOut.Location = new System.Drawing.Point(192, 251);
            this.txtpriceOut.Name = "txtpriceOut";
            this.txtpriceOut.Size = new System.Drawing.Size(222, 22);
            this.txtpriceOut.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price Out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Category Name";
            // 
            // txtcID
            // 
            this.txtcID.Location = new System.Drawing.Point(192, 372);
            this.txtcID.Name = "txtcID";
            this.txtcID.Size = new System.Drawing.Size(222, 22);
            this.txtcID.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 372);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Category ID";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(496, 432);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(111, 38);
            this.btnsubmit.TabIndex = 14;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(192, 312);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(222, 24);
            this.cboCategory.TabIndex = 15;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // picphoto
            // 
            this.picphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picphoto.Location = new System.Drawing.Point(452, 45);
            this.picphoto.Name = "picphoto";
            this.picphoto.Size = new System.Drawing.Size(257, 349);
            this.picphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picphoto.TabIndex = 16;
            this.picphoto.TabStop = false;
            this.picphoto.Click += new System.EventHandler(this.picphoto_Click);
            // 
            // frminsertproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 578);
            this.Controls.Add(this.picphoto);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtcID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpriceOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpriceIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtpro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbar);
            this.Controls.Add(this.label1);
            this.Name = "frminsertproduct";
            this.Text = "insertproduct";
            this.Load += new System.EventHandler(this.frminsertproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbar;
        private System.Windows.Forms.TextBox txtpro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpriceIn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpriceOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.PictureBox picphoto;
    }
}