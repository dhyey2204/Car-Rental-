using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class CarDetails : Form
    {
        DataRow dt;
        selectCar car;

        public CarDetails(DataRow row, selectCar car)
        {
            InitializeComponent();
            dt = row;
            this.car = car;
            showData();
        }


        public void showData()
        {

            this.type.Text = this.dt[1].ToString();
            this.model.Text = this.dt[2].ToString();
            this.cost.Text = this.dt[4].ToString();
            this.avail.Text = this.dt[3].ToString() == "0" ? "Not available" : "Available";
            this.description.Text = this.dt[5].ToString();
            string p = getImagePath(this.dt[6].ToString());
            this.pictureBox1.ImageLocation = p;
        }

        private string getImagePath(string img)
        {
            string p = Environment.CurrentDirectory;
            p = p.Split("bin")[0];
            return String.Format("{0}{1}", p, img).Replace("\\", "\\");

        }

        private void back_Click(object sender, EventArgs e)
        {
            car.Show();
            this.Hide();
        }

        private void book_Click(object sender, EventArgs e)
        {

            if (this.toDate.Value.Date.Subtract(this.fromDate.Value.Date).TotalHours == 0)
            {
                MessageBox.Show("From Date and To Date must be different !");
                return;
            }
            addCustomer customer = new addCustomer(dt, this.fromDate.Value, this.toDate.Value);
            customer.Show();
            this.Hide();

        }

        private void CarDetails_Load(object sender, EventArgs e)
        {

        }

        private void toDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
