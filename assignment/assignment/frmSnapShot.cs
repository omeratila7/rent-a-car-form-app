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
    public partial class frmSnapShot : Form
    {
        string str = "";
        public frmSnapShot()
        {
            InitializeComponent();
        }
        void updateDataGrid()
        {
            DBoperations.fillDataGrid(str, dataGridView1);
        }
        private void ok_Click(object sender, EventArgs e)
        {
            str = "SELECT [CarId],[Year],[Make] ,[Model],[Color],[InLot] FROM CarInventory FOR SYSTEM_TIME as of ";
            str += "'" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm") + ":59.9999999 ' order by CarId ";
            updateDataGrid();
        }
    }
}
