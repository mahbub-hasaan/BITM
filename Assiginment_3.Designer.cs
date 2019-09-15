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
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.coffeeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
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
            this.coffeeGroupBox.Controls.Add(this.quantityNumericUpDown);
            this.coffeeGroupBox.Controls.Add(this.saveButton);
            this.coffeeGroupBox.Controls.Add(this.orderComboBox);
            this.coffeeGroupBox.Controls.Add(this.addressTextBox);
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
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(239, 160);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(254, 20);
            this.addressTextBox.TabIndex = 3;
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Items.AddRange(new object[] {
            "Black",
            "Cold",
            "Hot",
            "Regular"});
            this.orderComboBox.Location = new System.Drawing.Point(239, 222);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(254, 21);
            this.orderComboBox.TabIndex = 4;
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
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(239, 256);
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(254, 20);
            this.quantityNumericUpDown.TabIndex = 7;
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
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox coffeeGroupBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox contaractTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label customerContractLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
    }
}