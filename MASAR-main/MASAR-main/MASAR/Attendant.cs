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
namespace MASAR
{
    public partial class   Attendant :Form
    {
        public string per_id { get; set; }
        public Attendant()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Salma Mahmoud\Downloads\Airline-1.mdf;Integrated Security = True; Connect Timeout = 30");
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (salary.Text == "" || airport_id.Text=="")
            {
                MessageBox.Show("Missing Info");
            }
            else
            {
                try
                {
                    if (con.State != ConnectionState.Open)
                        con.Open();
                    string perID = AddPerson.perID;
                    string perName = AddPerson.perName;
                    string perPhone = AddPerson.perPhone;
                    string perNation = AddPerson.perNation;
                    string perGender = AddPerson.perGender;
                    string perAirID = AddPerson.perAirID;
                    string query1 = "insert into Person values (" + perID + ",'" + perName + "','" + perPhone + "','" + perNation + "','" + perGender + "','" + perAirID + "')";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.ExecuteNonQuery();
                    string query2 = "insert into Attendant values (" + salary.Text + ",'" + airport_id.Text + "','" + perID + "')";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("record added successfully");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Attendant_Load(object sender, EventArgs e)
        {
        }

        private void airline_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void salary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
