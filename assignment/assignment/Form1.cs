using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void sendForm(Form form)
        {
            panel1.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void carLayer_Click(object sender, EventArgs e)
        {
            sendForm(new formCar());
        }

        private void customers_Click(object sender, EventArgs e)
        {
            sendForm(new formCustomer());
        }
    }
}
