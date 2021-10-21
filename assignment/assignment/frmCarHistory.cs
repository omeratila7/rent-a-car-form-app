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
    public partial class frmCarHistory : Form
    {
        string str = "";
        public frmCarHistory()
        {
            InitializeComponent();
        }
        void updateDataGrid()
        {
            DBoperations.fillDataGrid(str, dataGridView1);
        }

        private void ok_Click(object sender, EventArgs e)
        {
            str = "SELECT [CarId],[Year],[Make] ,[Model],[Color],[InLot] FROM CarInventory FOR SYSTEM_TIME BETWEEN ";
            str += "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00' AND ";
            str += "'" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + " 23:59:59' order by CarId , SysStartTime";
            updateDataGrid();
        }
    }
}
