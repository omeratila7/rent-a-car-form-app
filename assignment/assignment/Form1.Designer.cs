
namespace assignment
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.carLayer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customers = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // carLayer
            // 
            this.carLayer.Location = new System.Drawing.Point(25, 19);
            this.carLayer.Name = "carLayer";
            this.carLayer.Size = new System.Drawing.Size(75, 23);
            this.carLayer.TabIndex = 0;
            this.carLayer.Text = "Cars";
            this.carLayer.UseVisualStyleBackColor = true;
            this.carLayer.Click += new System.EventHandler(this.carLayer_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(4, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 396);
            this.panel1.TabIndex = 2;
            // 
            // customers
            // 
            this.customers.Location = new System.Drawing.Point(126, 19);
            this.customers.Name = "customers";
            this.customers.Size = new System.Drawing.Size(75, 23);
            this.customers.TabIndex = 3;
            this.customers.Text = "Customers";
            this.customers.UseVisualStyleBackColor = true;
            this.customers.Click += new System.EventHandler(this.customers_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customers);
            this.panel2.Controls.Add(this.carLayer);
            this.panel2.Location = new System.Drawing.Point(-7, -8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 469);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Rent A Car Application";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button carLayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button customers;
        private System.Windows.Forms.Panel panel2;
    }
}

