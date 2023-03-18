
namespace connectToSQLserver
{
    partial class ProductControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnorder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.PicPhoto = new System.Windows.Forms.PictureBox();
            this.lblinstock = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnorder
            // 
            this.btnorder.Location = new System.Drawing.Point(122, 290);
            this.btnorder.Name = "btnorder";
            this.btnorder.Size = new System.Drawing.Size(80, 31);
            this.btnorder.TabIndex = 12;
            this.btnorder.Text = "Order";
            this.btnorder.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Description";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(108, 262);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(104, 22);
            this.txtprice.TabIndex = 9;
            // 
            // txtdes
            // 
            this.txtdes.Location = new System.Drawing.Point(108, 224);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(104, 22);
            this.txtdes.TabIndex = 8;
            // 
            // PicPhoto
            // 
            this.PicPhoto.BackColor = System.Drawing.Color.Gainsboro;
            this.PicPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PicPhoto.Location = new System.Drawing.Point(20, 23);
            this.PicPhoto.Name = "PicPhoto";
            this.PicPhoto.Size = new System.Drawing.Size(211, 186);
            this.PicPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicPhoto.TabIndex = 7;
            this.PicPhoto.TabStop = false;
            // 
            // lblinstock
            // 
            this.lblinstock.AutoSize = true;
            this.lblinstock.Location = new System.Drawing.Point(220, 304);
            this.lblinstock.Name = "lblinstock";
            this.lblinstock.Size = new System.Drawing.Size(16, 17);
            this.lblinstock.TabIndex = 14;
            this.lblinstock.Text = "0";
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblinstock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnorder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtdes);
            this.Controls.Add(this.PicPhoto);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(280, 358);
            ((System.ComponentModel.ISupportInitialize)(this.PicPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnorder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtdes;
        private System.Windows.Forms.PictureBox PicPhoto;
        private System.Windows.Forms.Label lblinstock;
    }
}
