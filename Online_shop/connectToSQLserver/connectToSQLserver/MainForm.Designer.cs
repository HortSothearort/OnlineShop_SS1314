namespace connectToSQLserver
{
    partial class frmMainform
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
            this.btnviewpeople = new System.Windows.Forms.Button();
            this.btnproduct = new System.Windows.Forms.Button();
            this.btnluckydraw = new System.Windows.Forms.Button();
            this.tbnpro = new System.Windows.Forms.Button();
            this.btnOrderproducts = new System.Windows.Forms.Button();
            this.showproduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnviewpeople
            // 
            this.btnviewpeople.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnviewpeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewpeople.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnviewpeople.Location = new System.Drawing.Point(396, 3);
            this.btnviewpeople.Margin = new System.Windows.Forms.Padding(4);
            this.btnviewpeople.Name = "btnviewpeople";
            this.btnviewpeople.Size = new System.Drawing.Size(164, 47);
            this.btnviewpeople.TabIndex = 0;
            this.btnviewpeople.Text = "View People";
            this.btnviewpeople.UseVisualStyleBackColor = false;
            this.btnviewpeople.Click += new System.EventHandler(this.btnviewpeople_Click);
            // 
            // btnproduct
            // 
            this.btnproduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnproduct.Location = new System.Drawing.Point(29, 3);
            this.btnproduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnproduct.Name = "btnproduct";
            this.btnproduct.Size = new System.Drawing.Size(164, 47);
            this.btnproduct.TabIndex = 1;
            this.btnproduct.Text = "Product";
            this.btnproduct.UseVisualStyleBackColor = false;
            this.btnproduct.Click += new System.EventHandler(this.btnproduct_Click);
            // 
            // btnluckydraw
            // 
            this.btnluckydraw.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnluckydraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluckydraw.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnluckydraw.Location = new System.Drawing.Point(201, 3);
            this.btnluckydraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnluckydraw.Name = "btnluckydraw";
            this.btnluckydraw.Size = new System.Drawing.Size(187, 47);
            this.btnluckydraw.TabIndex = 2;
            this.btnluckydraw.Text = "LuckyDraw";
            this.btnluckydraw.UseVisualStyleBackColor = false;
            this.btnluckydraw.Click += new System.EventHandler(this.btnluckydraw_Click);
            // 
            // tbnpro
            // 
            this.tbnpro.BackColor = System.Drawing.Color.MediumOrchid;
            this.tbnpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnpro.ForeColor = System.Drawing.Color.GhostWhite;
            this.tbnpro.Location = new System.Drawing.Point(568, 3);
            this.tbnpro.Margin = new System.Windows.Forms.Padding(4);
            this.tbnpro.Name = "tbnpro";
            this.tbnpro.Size = new System.Drawing.Size(164, 47);
            this.tbnpro.TabIndex = 3;
            this.tbnpro.Text = "Insert Product";
            this.tbnpro.UseVisualStyleBackColor = false;
            this.tbnpro.Click += new System.EventHandler(this.tbnpro_Click);
            // 
            // btnOrderproducts
            // 
            this.btnOrderproducts.BackColor = System.Drawing.Color.MediumOrchid;
            this.btnOrderproducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderproducts.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnOrderproducts.Location = new System.Drawing.Point(740, 3);
            this.btnOrderproducts.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderproducts.Name = "btnOrderproducts";
            this.btnOrderproducts.Size = new System.Drawing.Size(216, 47);
            this.btnOrderproducts.TabIndex = 4;
            this.btnOrderproducts.Text = "Order Products";
            this.btnOrderproducts.UseVisualStyleBackColor = false;
            this.btnOrderproducts.Click += new System.EventHandler(this.btnOrderproducts_Click);
            // 
            // showproduct
            // 
            this.showproduct.BackColor = System.Drawing.Color.MediumOrchid;
            this.showproduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showproduct.ForeColor = System.Drawing.Color.White;
            this.showproduct.Location = new System.Drawing.Point(430, 69);
            this.showproduct.Margin = new System.Windows.Forms.Padding(4);
            this.showproduct.Name = "showproduct";
            this.showproduct.Size = new System.Drawing.Size(175, 47);
            this.showproduct.TabIndex = 5;
            this.showproduct.Text = "Show Product";
            this.showproduct.UseVisualStyleBackColor = false;
            this.showproduct.Click += new System.EventHandler(this.showproduct_Click);
            // 
            // frmMainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1118, 434);
            this.Controls.Add(this.showproduct);
            this.Controls.Add(this.btnOrderproducts);
            this.Controls.Add(this.tbnpro);
            this.Controls.Add(this.btnluckydraw);
            this.Controls.Add(this.btnproduct);
            this.Controls.Add(this.btnviewpeople);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainform";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainform_FormClosed);
            this.Load += new System.EventHandler(this.frmMainform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnviewpeople;
        private System.Windows.Forms.Button btnproduct;
        private System.Windows.Forms.Button btnluckydraw;
        private System.Windows.Forms.Button tbnpro;
        private System.Windows.Forms.Button btnOrderproducts;
        private System.Windows.Forms.Button showproduct;
    }
}