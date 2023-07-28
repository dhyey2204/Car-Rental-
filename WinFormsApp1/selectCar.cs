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

namespace WinFormsApp1
{
    public partial class selectCar : Form
    {
        int idx = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\BABLU\DOWNLOADS\Final_Project_Kirtan\WINFORMSAPP1\WINFORMSAPP1\DATABASE1.MDF;Integrated Security=True");
        DataTable dt = new DataTable();
        public selectCar()
        {
            InitializeComponent();
        }

        private void selectCar_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from car;";
            cmd.ExecuteNonQuery();
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            showData();

        }

        private void previous_Click(object sender, EventArgs e)
        {
            idx--;
            showData();
        }

        private void select_Click(object sender, EventArgs e)
        {
            if (this.dt.Rows[idx][3].ToString() == "0")
            {
                MessageBox.Show("Car not available!!");
                return;
            }
            CarDetails carDetails = new CarDetails(this.dt.Rows[idx], this);
            this.Hide();
            carDetails.Show();
        }

        private void next_Click(object sender, EventArgs e)
        {
            idx++;
            showData();
        }

        public void showData()
        {   
            idx = (idx+ this.dt.Rows.Count) % (this.dt.Rows.Count);
            
            this.type.Text = this.dt.Rows[idx][1].ToString();
            this.model.Text = this.dt.Rows[idx][2].ToString();
            this.cost.Text = this.dt.Rows[idx][4].ToString();
            this.avail.Text = this.dt.Rows[idx][3].ToString() == "0" ? "Not available" : "Available";
        }

    }
}
