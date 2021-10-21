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
    public partial class frmRentCar : Form
    {
        bool selected = false;
        string str = "SELECT [CarId],[Year],[Make] ,[Model],[Color],[InLot]FROM CarInventory ";
        public frmRentCar()
        {
            InitializeComponent();
            updateDataGrid();
        }

       void updateDataGrid()
        {
            DBoperations.fillDataGrid(str, dataGridView1);
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            selected =!selected;
            if (selected)
                str += "WHERE InLot=1";
            else
                str= str.Remove(str.Length - 13, 13);
            updateDataGrid();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "INSERT INTO [dbo].[CarInventory]([Year],[Make],[Model],[Color],[InLot]) VALUES"
                                                        +"("+year.Text+" , '"+brand.Text+ "'  , '" + model.Text + "' , '" + color.Text + "' , 1)";
            DBoperations.executeQuery(str);
            updateDataGrid();

        }

        private void update_Click(object sender, EventArgs e)
        {
            new frmContrats().Show();
        }
    }
}
