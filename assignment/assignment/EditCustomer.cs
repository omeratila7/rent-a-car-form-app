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
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
            DBoperations.fillComboBox("select *, name+' '+surname as n from Customers", comboBox1,"n");
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            name.Text = ((System.Data.DataRowView)(comboBox1.SelectedItem))[1].ToString();
            surname.Text = ((System.Data.DataRowView)(comboBox1.SelectedItem))[2].ToString();
            phone.Text = ((System.Data.DataRowView)(comboBox1.SelectedItem))[3].ToString();
            email.Text = ((System.Data.DataRowView)(comboBox1.SelectedItem))[4].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string _name,_surname,_phone,_email,_id;
            _name = name.Text;
            _surname = surname.Text;
            _phone = phone.Text;
            _email = email.Text;
            _id = ((System.Data.DataRowView)(comboBox1.SelectedItem))["CustomerId"].ToString();
            DBoperations.executeQuery("UPDATE Customers SET [Name] ='"+_name+"'  ,[Surname] ='"+_surname+
                "'  ,[PhoneNumber] ='"+_phone+"'  ,[Email] ='"+_email+"' WHERE CustomerId="+_id);
            this.Close();
        }
    }
}
