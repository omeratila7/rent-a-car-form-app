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
    public partial class frmcustomers : Form
    {
        bool selected = false;
        string str = "SELECT [CustomerId],[Name],[Surname] ,[PhoneNumber],[Email],[haveActiveRent]FROM Customers ";
        public frmcustomers()
        {
            InitializeComponent();
            updateDataGrid();
        }
        void updateDataGrid()
        {
            DBoperations.fillDataGrid(str, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ss = "INSERT INTO [dbo].[Customers]([Name],[Surname] ,[PhoneNumber],[Email],[haveActiveRent]) VALUES"
                                                        + "('" + name.Text + "' , '" + surname.Text + "'  , '" + phone.Text + "' , '" + email.Text + "' , 0)";
            DBoperations.executeQuery(ss);
            updateDataGrid();
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            selected = !selected;
            if (selected)
                str += "WHERE haveActiveRent=1";
            else
                str = str.Remove(str.Length - "WHERE haveActiveRent=1".Length, "WHERE haveActiveRent=1".Length);
            updateDataGrid();

        }

        private void update_Click(object sender, EventArgs e)
        {
            EditCustomer et = new EditCustomer();
            et.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updateDataGrid();
        }
    }
}
