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
    public partial class frmCustomerHistory : Form
    {
        string str="";
        public frmCustomerHistory()
        {
            InitializeComponent();
            DBoperations.fillComboBox("select *, name+' '+surname as n from Customers", comboBox1, "n");
        }
        void updateDataGrid()
        {
            DBoperations.fillDataGrid(str, dataGridView1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            str = "Select * from Contracts WHERE CustemerId = "+ ((System.Data.DataRowView)(comboBox1.SelectedItem))["CustomerId"].ToString()+" ORDER BY RentDate DESC";

            updateDataGrid();
        }
    }
}
