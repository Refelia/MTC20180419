namespace AdventureW2012
{
    partial class Form1
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
            this.CustDropcomboBox = new System.Windows.Forms.ComboBox();
            this.SalesdataGridView = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.salesOrderIDlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SalesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustDropcomboBox
            // 
            this.CustDropcomboBox.FormattingEnabled = true;
            this.CustDropcomboBox.Location = new System.Drawing.Point(12, 35);
            this.CustDropcomboBox.Name = "CustDropcomboBox";
            this.CustDropcomboBox.Size = new System.Drawing.Size(153, 21);
            this.CustDropcomboBox.TabIndex = 0;
            this.CustDropcomboBox.SelectedIndexChanged += new System.EventHandler(this.CustDropcomboBox_SelectedIndexChanged);
            // 
            // SalesdataGridView
            // 
            this.SalesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SalesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesdataGridView.Location = new System.Drawing.Point(12, 75);
            this.SalesdataGridView.MultiSelect = false;
            this.SalesdataGridView.Name = "SalesdataGridView";
            this.SalesdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SalesdataGridView.Size = new System.Drawing.Size(784, 375);
            this.SalesdataGridView.TabIndex = 1;
            this.SalesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesdataGridView_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(508, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // salesOrderIDlabel
            // 
            this.salesOrderIDlabel.AutoSize = true;
            this.salesOrderIDlabel.Location = new System.Drawing.Point(505, 19);
            this.salesOrderIDlabel.Name = "salesOrderIDlabel";
            this.salesOrderIDlabel.Size = new System.Drawing.Size(50, 13);
            this.salesOrderIDlabel.TabIndex = 3;
            this.salesOrderIDlabel.Text = "Order ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Customer:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesOrderIDlabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SalesdataGridView);
            this.Controls.Add(this.CustDropcomboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CustDropcomboBox;
        private System.Windows.Forms.DataGridView SalesdataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label salesOrderIDlabel;
        private System.Windows.Forms.Label label1;
    }
}

