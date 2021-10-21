using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace assignment
{
    static class DBoperations
    {
        static SqlConnection con = new SqlConnection("Data Source=DESKTOP-QVTOPON;Initial Catalog=rentAcar;Integrated Security=True");
        static public void fillDataGrid(string command, DataGridView dataGridView)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(command, con);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            dataGridView.DataSource = dataSet.Tables[0];
            con.Close();
        }

        static public void executeQuery(string command)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(command, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        static public void fillComboBox(string command, ComboBox comboBox,string displayMember)
        {
            DataRow dr;


            con.Open();
            SqlCommand cmd = new SqlCommand(command, con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            dr = dt.NewRow();

            comboBox.ValueMember = "CustomerId";

            comboBox.DisplayMember = displayMember;
            comboBox.DataSource = dt;

            con.Close();

        }
    }
}
