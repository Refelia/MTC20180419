using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdventureW2012
{
    public partial class Form1 : Form
    {
        const string connString = "server = DTPLAPTOP06; database = AdventureWorks2012;  trusted_connection = true;";
        SqlConnection sqlConn = new SqlConnection(connString);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDa = new SqlDataAdapter("dbo.ActiveCustList", sqlConn);
            DataTable dtCustomer = new DataTable();

            int CustomerID;
            string Customer;

            try
            {
                sqlDa.Fill(dtCustomer);

                foreach (DataRow drcust in dtCustomer.Rows)
                {
                    CustomerID = int.Parse(drcust.ItemArray[0].ToString());
                    Customer = drcust.ItemArray[1].ToString();
                    CustDropcomboBox.Items.Add(new cboObject(CustomerID, Customer));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }


        }

        private void CustDropcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                cboObject current = (cboObject)CustDropcomboBox.SelectedItem;
                int custID = current.customerID;
                DataTable dtcustomer = new DataTable();

            try
            {
                SqlCommand sqlconn = new SqlCommand("SalesDetails", sqlConn);
                sqlconn.CommandType = CommandType.StoredProcedure;

                SqlParameter prmCustID = new SqlParameter("@CustomerID", custID);
                sqlconn.Parameters.Add(prmCustID);

                SqlDataAdapter dataFeed = new SqlDataAdapter(sqlconn);

                dataFeed.Fill(dtcustomer);

                SalesdataGridView.DataSource = dtcustomer;
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void SalesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >=0)

            {
                DataGridViewRow row = this.SalesdataGridView.Rows[e.RowIndex];

                textBox1.Text = row.Cells[0].Value.ToString();
            }

        }
        public class cboObject
        {
            int custID;
            string custName;

            public cboObject ( int customerID, string customerName)
            {
                custID = customerID;
                custName = customerName;
            }

            public cboObject(string customerName)
            {
                custName = customerName;
            }

            public int customerID
            {
                get { return custID; }
                set { custID = value; }
            }

            public string customerName
            {
                get { return custName; }
                set { custName = value; }
            }

            public override string ToString()
            {
                return customerName;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
