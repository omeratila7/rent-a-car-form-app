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
    public partial class frmContrats : Form
    {
        string str = "";

        public frmContrats()
        {
            InitializeComponent();
            DBoperations.fillComboBox("select *, name+' '+surname as n from Customers WHERE haveActiveRent=0", comboBox1,"n");
            DBoperations.fillComboBox("select *, CONVERT(varchar(10), CarId)+' '+Make+' '+Model+' '+' '+Color as n from CarInventory Where InLot=1", comboBox2, "n");
            str = "Select * from Contracts";
            updateDataGrid();
        }
        void updateDataGrid()
        {
            
            str = "Select * from Contracts ";
            if (checkBox1.Checked)
                str += "WHERE IsActive = 1";
            DBoperations.fillDataGrid(str, dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string carId, customerId, price, rentDate, deliveryDate;
            carId = ((System.Data.DataRowView)(comboBox2.SelectedItem))["CarId"].ToString();
            customerId = ((System.Data.DataRowView)(comboBox1.SelectedItem))["CustomerId"].ToString();
            price = Price.Text;
            rentDate = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm") + ":00.0000000 ";
            deliveryDate = dateTimePicker2.Value.ToUniversalTime().ToString("yyyy-MM-dd HH:mm") + ":59.9999999 ";

            str = "INSERT INTO [dbo].[Contracts] ([CarId],[CustemerId] ,[Price]  ,[RentDate],[DeliveryDate])" +
            "  VALUES ("+carId+ "," + customerId + " ," + price + " ,'" + rentDate+ "' ,'" + deliveryDate+ "')";

            DBoperations.executeQuery(str);

            updateDataGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1 && (bool)dataGridView1.SelectedRows[0].Cells[6].Value == true)
            {
                str = "UPDATE Contracts set IsActive = 0 Where ContractsId = " + dataGridView1.SelectedRows[0].Cells[0].Value;
                DBoperations.executeQuery(str);
                updateDataGrid();
            }
            else
                MessageBox.Show("Plese select only one row and still active one");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateDataGrid();
        }
    }
}
