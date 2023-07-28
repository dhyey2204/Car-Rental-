using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public partial class addCustomer : Form
    {
        DataRow dt,customer;
        DataTable cust = new DataTable();
        DateTime fromDate, toDate;
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bablu\Downloads\Final_Project_Kirtan\WinFormsApp1\WinFormsApp1\Database1.mdf;Integrated Security=True");
        public addCustomer(DataRow dt, DateTime fromDate, DateTime toDate)
        {
            InitializeComponent();
            this.dt = dt;
            this.toDate = toDate;
            this.fromDate = fromDate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = String.Format("insert into customer(first_name, last_name, phone_number, credit_card_data) values('{0}','{1}','{2}','{3}');",
                this.firstNameTb.Text, this.lastNameTb.Text, this.phoneTb.Text, this.cardTb.Text);
            cmd.ExecuteNonQuery();

            book();
            conn.Close();
            
            recipt recipt = new recipt(dt, fromDate, toDate, customer);
            recipt.Show();
            this.Hide();

        }

        private bool validate()
        {
            string phoneNo = this.phoneTb.Text;
            string card = this.cardTb.Text;
            long num;

            if(this.firstNameTb.Text.Length == 0 || this.lastNameTb.Text.Length == 0)
            {
                MessageBox.Show("First or last name cannot be empty");
                return false;
            }
            if (phoneNo.Length != 10 || !long.TryParse(phoneNo, out num))
            {
                MessageBox.Show("Enter valid 10 digit phone number");
                return false;
            }

            if (card.Length != 16 || !long.TryParse(card, out num))
            {
                MessageBox.Show("Enter valid 16 digit card number");
                return false;
            }

            return true;

        }
        private void book()
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = String.Format("SELECT * FROM customer where id = (select max(id) from customer);");
            cmd.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(cust);
            customer = cust.Rows[0];
            
            //create booking
            double totalCost = toDate.Date.Subtract(fromDate.Date).TotalDays * (double)dt[4];
            cmd.CommandText = String.Format("INSERT INTO booking(car_id, customer_id, pick_up_date, drop_off_date,total_cost) values({0}, {1}, '{2}', '{3}', {4})",
                dt[0], customer[0], fromDate.Date, toDate.Date, totalCost);
            cmd.ExecuteNonQuery();

            //reduce from car stock
            cmd.CommandText = String.Format("UPDATE car SET quantity_on_stock = quantity_on_stock -1 where id = {0}", dt[0]); 
            cmd.ExecuteNonQuery();
            conn.Close();

        }
    }
}