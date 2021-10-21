
namespace assignment
{
    partial class formCustomer
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
            this.customers = new System.Windows.Forms.Button();
            this.contracts = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // customers
            // 
            this.customers.Location = new System.Drawing.Point(13, 13);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(75, 23);
            this.customers.TabIndex = 0;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // contracts
            // 
            this.contracts.Location = new System.Drawing.Point(94, 14);
            this.contracts.Name = "contracts";
            this.contracts.Size = new System.Drawing.Size(75, 23);
            this.contracts.TabIndex = 1;
            this.contracts.Text = "Contracts";
            this.contracts.UseVisualStyleBackColor = true;
            this.contracts.Click += new System.EventHandler(this.contracts_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(175, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Customer history";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 395);
            this.panel1.TabIndex = 3;
            // 
            // formCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.contracts);
            this.Controls.Add(this.customers);
            this.Name = "formCustomer";
            this.Text = "formCustomer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Button contracts;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}