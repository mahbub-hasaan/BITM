namespace BITM_Works
{
    partial class Assiginment_3
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.coffeeGroupBox = new System.Windows.Forms.GroupBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerContractLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.contaractTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.OrderComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.coffeeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(653, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(293, 445);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // coffeeGroupBox
            // 
            this.coffeeGroupBox.Controls.Add(this.saveButton);
            this.coffeeGroupBox.Controls.Add(this.quantityTextBox);
            this.coffeeGroupBox.Controls.Add(this.OrderComboBox);
            this.coffeeGroupBox.Controls.Add(this.AddressTextBox);
            this.coffeeGroupBox.Controls.Add(this.contaractTextBox);
            this.coffeeGroupBox.Controls.Add(this.nameTextBox);
            this.coffeeGroupBox.Controls.Add(this.quantityLabel);
            this.coffeeGroupBox.Controls.Add(this.orderLabel);
            this.coffeeGroupBox.Controls.Add(this.AddressLabel);
            this.coffeeGroupBox.Controls.Add(this.customerContractLabel);
            this.coffeeGroupBox.Controls.Add(this.customerNameLabel);
            this.coffeeGroupBox.Location = new System.Drawing.Point(13, 12);
            this.coffeeGroupBox.Name = "coffeeGroupBox";
            this.coffeeGroupBox.Size = new System.Drawing.Size(634, 445);
            this.coffeeGroupBox.TabIndex = 1;
            this.coffeeGroupBox.TabStop = false;
            this.coffeeGroupBox.Text = "Coffee Shop";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(86, 63);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // customerContractLabel
            // 
            this.customerContractLabel.AutoSize = true;
            this.customerContractLabel.Location = new System.Drawing.Point(86, 114);
            this.customerContractLabel.Name = "customerContractLabel";
            this.customerContractLabel.Size = new System.Drawing.Size(94, 13);
            this.customerContractLabel.TabIndex = 0;
            this.customerContractLabel.Text = "Customer Contract";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(86, 160);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(45, 13);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Address";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(86, 222);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(33, 17);
            this.orderLabel.TabIndex = 0;
            this.orderLabel.Text = "Order";
            this.orderLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.orderLabel.UseCompatibleTextRendering = true;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(86, 256);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 0;
            this.quantityLabel.Text = "Quantity";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(239, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(254, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // contaractTextBox
            // 
            this.contaractTextBox.Location = new System.Drawing.Point(239, 114);
            this.contaractTextBox.Name = "contaractTextBox";
            this.contaractTextBox.Size = new System.Drawing.Size(254, 20);
            this.contaractTextBox.TabIndex = 2;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(239, 160);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(254, 20);
            this.AddressTextBox.TabIndex = 3;
            // 
            // OrderComboBox
            // 
            this.OrderComboBox.FormattingEnabled = true;
            this.OrderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.OrderComboBox.Location = new System.Drawing.Point(239, 222);
            this.OrderComboBox.Name = "OrderComboBox";
            this.OrderComboBox.Size = new System.Drawing.Size(254, 21);
            this.OrderComboBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(239, 256);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(254, 20);
            this.quantityTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(417, 314);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Assiginment_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 469);
            this.Controls.Add(this.coffeeGroupBox);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Assiginment_3";
            this.Text = "Assiginment_3";
            this.coffeeGroupBox.ResumeLayout(false);
            this.coffeeGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox coffeeGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox OrderComboBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox contaractTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label customerContractLabel;
        private System.Windows.Forms.Label customerNameLabel;
    }
}