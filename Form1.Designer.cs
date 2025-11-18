namespace OrderPipeline
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnProcessOrder = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkExpress = new System.Windows.Forms.CheckBox();
            this.btnShipOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(150, 30);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(250, 27);
            this.txtCustomerName.TabIndex = 0;
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "Laptop",
            "Mouse",
            "Keyboard"});
            this.cmbProduct.Location = new System.Drawing.Point(150, 80);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(250, 28);
            this.cmbProduct.TabIndex = 1;
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(150, 130);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(250, 27);
            this.numQuantity.TabIndex = 2;
            // 
            // btnProcessOrder
            // 
            this.btnProcessOrder.Location = new System.Drawing.Point(150, 220);
            this.btnProcessOrder.Name = "btnProcessOrder";
            this.btnProcessOrder.Size = new System.Drawing.Size(250, 40);
            this.btnProcessOrder.TabIndex = 3;
            this.btnProcessOrder.Text = "Process Order";
            this.btnProcessOrder.UseVisualStyleBackColor = true;
            this.btnProcessOrder.Click += new System.EventHandler(this.btnProcessOrder_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(30, 330);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 23);
            this.lblStatus.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantity:";
            // 
            // chkExpress
            // 
            this.chkExpress.AutoSize = true;
            this.chkExpress.Location = new System.Drawing.Point(150, 180);
            this.chkExpress.Name = "chkExpress";
            this.chkExpress.Size = new System.Drawing.Size(143, 24);
            this.chkExpress.TabIndex = 8;
            this.chkExpress.Text = "Express Shipping";
            this.chkExpress.UseVisualStyleBackColor = true;
            this.chkExpress.CheckedChanged += new System.EventHandler(this.chkExpress_CheckedChanged);
            // 
            // btnShipOrder
            // 
            this.btnShipOrder.Location = new System.Drawing.Point(150, 275);
            this.btnShipOrder.Name = "btnShipOrder";
            this.btnShipOrder.Size = new System.Drawing.Size(250, 40);
            this.btnShipOrder.TabIndex = 9;
            this.btnShipOrder.Text = "Ship Order";
            this.btnShipOrder.UseVisualStyleBackColor = true;
            this.btnShipOrder.Click += new System.EventHandler(this.btnShipOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 380);
            this.Controls.Add(this.btnShipOrder);
            this.Controls.Add(this.chkExpress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnProcessOrder);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.txtCustomerName);
            this.Name = "Form1";
            this.Text = "Order Pipeline";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Button btnProcessOrder;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkExpress;
        private System.Windows.Forms.Button btnShipOrder;
    }
}
