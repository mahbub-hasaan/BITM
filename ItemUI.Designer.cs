namespace BITM_Works
{
    partial class ItemUI
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
            this.components = new System.ComponentModel.Container();
            this.AddButton = new System.Windows.Forms.Button();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.ShowButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SerachButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.itemComboBox = new System.Windows.Forms.ComboBox();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(69, 115);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(64, 23);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add Item";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // showDataGridView
            // 
            this.showDataGridView.AllowUserToAddRows = false;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Location = new System.Drawing.Point(438, 13);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.ReadOnly = true;
            this.showDataGridView.Size = new System.Drawing.Size(338, 425);
            this.showDataGridView.TabIndex = 6;
            // 
            // ShowButton
            // 
            this.ShowButton.BackColor = System.Drawing.Color.SeaGreen;
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.Location = new System.Drawing.Point(113, 344);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(156, 45);
            this.ShowButton.TabIndex = 7;
            this.ShowButton.Text = "Show Items";
            this.ShowButton.UseVisualStyleBackColor = false;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(216, 115);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SerachButton
            // 
            this.SerachButton.Location = new System.Drawing.Point(298, 115);
            this.SerachButton.Name = "SerachButton";
            this.SerachButton.Size = new System.Drawing.Size(75, 23);
            this.SerachButton.TabIndex = 3;
            this.SerachButton.Text = "Search";
            this.SerachButton.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.itemComboBox);
            this.groupBox4.Controls.Add(this.SerachButton);
            this.groupBox4.Controls.Add(this.UpdateButton);
            this.groupBox4.Controls.Add(this.DeleteButton);
            this.groupBox4.Controls.Add(this.AddButton);
            this.groupBox4.Controls.Add(this.nameTextBox);
            this.groupBox4.Controls.Add(this.priceTextBox);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(17, 74);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(415, 153);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ITEM";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(136, 115);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(74, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update Item";
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(125, 55);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(248, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(125, 78);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(248, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Select Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Price";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.OrdersButton);
            this.groupBox5.Controls.Add(this.CustomerButton);
            this.groupBox5.Controls.Add(this.HomeButton);
            this.groupBox5.Location = new System.Drawing.Point(17, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(415, 64);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "OPTIONS";
            // 
            // OrdersButton
            // 
            this.OrdersButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Location = new System.Drawing.Point(283, 19);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(126, 38);
            this.OrdersButton.TabIndex = 0;
            this.OrdersButton.Text = "Orders";
            this.OrdersButton.UseVisualStyleBackColor = false;
            // 
            // CustomerButton
            // 
            this.CustomerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerButton.Location = new System.Drawing.Point(139, 19);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(138, 38);
            this.CustomerButton.TabIndex = 0;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = false;
            // 
            // HomeButton
            // 
            this.HomeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Location = new System.Drawing.Point(7, 20);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(126, 38);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.Text = "Home";
            this.HomeButton.UseVisualStyleBackColor = false;
            // 
            // itemComboBox
            // 
            this.itemComboBox.DataSource = this.itemBindingSource;
            this.itemComboBox.DisplayMember = "Name";
            this.itemComboBox.FormattingEnabled = true;
            this.itemComboBox.Location = new System.Drawing.Point(125, 27);
            this.itemComboBox.Name = "itemComboBox";
            this.itemComboBox.Size = new System.Drawing.Size(248, 21);
            this.itemComboBox.TabIndex = 11;
            this.itemComboBox.ValueMember = "Id";
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(BITM_Works.Models.Item);
            // 
            // ItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.showDataGridView);
            this.Name = "ItemUI";
            this.Text = "Item";
            this.Load += new System.EventHandler(this.ItemUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button SerachButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.ComboBox itemComboBox;
        private System.Windows.Forms.BindingSource itemBindingSource;
    }
}