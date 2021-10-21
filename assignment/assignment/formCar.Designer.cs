
namespace assignment
{
    partial class formCar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.carsLayer = new System.Windows.Forms.Button();
            this.searchCarHistory = new System.Windows.Forms.Button();
            this.takesnapshot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(13, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 395);
            this.panel1.TabIndex = 1;
            // 
            // carsLayer
            // 
            this.carsLayer.Location = new System.Drawing.Point(13, 13);
            this.carsLayer.Name = "carsLayer";
            this.carsLayer.Size = new System.Drawing.Size(75, 23);
            this.carsLayer.TabIndex = 2;
            this.carsLayer.Text = "List Cars";
            this.carsLayer.UseVisualStyleBackColor = true;
            this.carsLayer.Click += new System.EventHandler(this.carsLayer_Click);
            // 
            // searchCarHistory
            // 
            this.searchCarHistory.Location = new System.Drawing.Point(95, 14);
            this.searchCarHistory.Name = "searchCarHistory";
            this.searchCarHistory.Size = new System.Drawing.Size(110, 23);
            this.searchCarHistory.TabIndex = 3;
            this.searchCarHistory.Text = "Search car history";
            this.searchCarHistory.UseVisualStyleBackColor = true;
            this.searchCarHistory.Click += new System.EventHandler(this.searchCarHistory_Click);
            // 
            // takesnapshot
            // 
            this.takesnapshot.Location = new System.Drawing.Point(211, 14);
            this.takesnapshot.Name = "takesnapshot";
            this.takesnapshot.Size = new System.Drawing.Size(100, 23);
            this.takesnapshot.TabIndex = 4;
            this.takesnapshot.Text = "Take snapshot";
            this.takesnapshot.UseVisualStyleBackColor = true;
            this.takesnapshot.Click += new System.EventHandler(this.takesnapshot_Click);
            // 
            // formCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.takesnapshot);
            this.Controls.Add(this.searchCarHistory);
            this.Controls.Add(this.carsLayer);
            this.Controls.Add(this.panel1);
            this.Name = "formCar";
            this.Text = "formCar";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button carsLayer;
        private System.Windows.Forms.Button searchCarHistory;
        private System.Windows.Forms.Button takesnapshot;
    }
}