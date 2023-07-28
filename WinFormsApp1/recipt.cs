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
    public partial class recipt : Form
    {
        DataRow dt, customer;
        DateTime fromDate, toDate;
        int days;
        public recipt(DataRow dt, DateTime fromDate, DateTime toDate, DataRow customer)
        {
            InitializeComponent();
            this.dt = dt;
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.customer = customer;
            days = toDate.Date.Subtract(fromDate.Date).Days;
        }

        private void recipt_Load(object sender, EventArgs e)
        {
            this.name_recipt.Text = customer[1].ToString() + " " + customer[2].ToString();
            this.from_recipt.Text = fromDate.Date.GetDateTimeFormats()[6];
            this.to_recipt.Text = toDate.Date.GetDateTimeFormats()[6];
            this.per_day_cost_recipt.Text = dt[4].ToString();
            this.total_cost_recipt.Text = ((double)dt[4] * days).ToString();
            this.car_recipt.Text = dt[2].ToString() + " " + dt[1].ToString();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
