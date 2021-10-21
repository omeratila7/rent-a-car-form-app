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
    public partial class formCar : Form
    {
        public formCar()
        {
            InitializeComponent();
        }

        private void sendForm(Form form)
        {
            panel1.Controls.Clear();
            form.MdiParent = this.ParentForm;
            form.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void carsLayer_Click(object sender, EventArgs e)
        {
            sendForm(new frmRentCar());
        }

        private void searchCarHistory_Click(object sender, EventArgs e)
        {
            sendForm(new frmCarHistory());
        }

        private void takesnapshot_Click(object sender, EventArgs e)
        {
            sendForm(new frmSnapShot());
        }
    }
}
