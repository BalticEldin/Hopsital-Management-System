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
using System.Security.Cryptography;

namespace Hospital_Management_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            labelIndecator1.ForeColor = System.Drawing.Color.Red;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
          
           
        }

        private void btnAddDiagnosis_Click(object sender, EventArgs e)
        {
            labelIndecator2.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;

            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;



        }

        private void btnFullHistory_Click(object sender, EventArgs e)
        {
            labelIndecator3.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator4.ForeColor = System.Drawing.Color.Black;

            panel3.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel4.Visible= false;

            SqlConnection con = new SqlConnection();
           //Copy your server name from SQL and paste it in the data source,leave everything else as it is,to make the connection with the Database from SQL Server Management
            con.ConnectionString = "data source = DESKTOP-IQVMEBF\\SQLEXPRESS; database = hospital; integrated security = True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from AddPatient inner join PatientMore on AddPatient.pid = PatientMore.pid";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView2.DataSource= DS.Tables[0];



        }

        private void btnHospital_Click(object sender, EventArgs e)
        {
            labelIndecator4.ForeColor = System.Drawing.Color.Red;
            labelIndecator1.ForeColor = System.Drawing.Color.Black;
            labelIndecator2.ForeColor = System.Drawing.Color.Black;
            labelIndecator3.ForeColor = System.Drawing.Color.Black;

            panel4.Visible = true;
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                String name = txtName.Text;
                String address = txtAddress.Text;
                Int64 contact = Convert.ToInt64(txtContact.Text);
                int age = Convert.ToInt32(txtAge.Text);
                String gender = comboGender.Text;
                String blood = txtBlood.Text;
                String any = txtAny.Text;
                int pid = Convert.ToInt32(txtPid.Text);

                SqlConnection con = new SqlConnection();
                //Copy your server name from SQL and paste it in the data source,leave everything else as it is,to make the connection with the Database from SQL Server Management
                con.ConnectionString = "data source = DESKTOP-IQVMEBF\\SQLEXPRESS; database = hospital; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "insert into AddPatient values  ('" + name + "','" + address + "','" + contact + "'," + age + ",'" + gender + "','" + blood + "','" + any + "','" + pid + "')";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data format");
            }

            MessageBox.Show("Data saved!");

            txtName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtAge.Clear();
            txtBlood.Clear();
            txtAny.Clear();
            txtPid.Clear();
            comboGender.ResetText();


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                int pid = Convert.ToInt32(textBox1.Text);

                SqlConnection con = new SqlConnection();
                //Copy your server name from SQL and paste it in the data source,leave everything else as it is,to make the connection with the Database from SQL Server Management
                con.ConnectionString = "data source = DESKTOP-IQVMEBF\\SQLEXPRESS; database = hospital; integrated security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select * from AddPatient where  pid = " + pid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int pid = Convert.ToInt32(textBox1.Text);
                String sympt = txtBxSymptoms.Text;
                String diag = txtBxDiagonosis.Text;
                String medicine = txtBxMedicines.Text;
                String ward = comboBxWard.Text;
                String wardType = comboBxWardType.Text;

                

                SqlConnection con = new SqlConnection();
                //Copy your server name from SQL and paste it in the data source,leave everything else as it is,to make the connection with the Database from SQL Server Management
                con.ConnectionString = "data source = DESKTOP-IQVMEBF\\SQLEXPRESS; database = hospital; integrated security = True";

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into PatientMore values (" + pid + ",'" + sympt + "','" + diag + "','" + medicine + "','" + ward + "','" + wardType + "')";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);


            }
            catch(Exception)
            {
                MessageBox.Show("Invalid data or Wrong Format");

            }
            MessageBox.Show("Data Saved");
            
            textBox1.Clear();
            txtBxDiagonosis.Clear();
            txtBxMedicines.Clear();
            txtBxSymptoms.Clear();  
            comboBxWard.ResetText();
            comboBxWardType.ResetText();
        }
    }
}
