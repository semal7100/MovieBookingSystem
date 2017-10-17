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

namespace WindowsFormsApplication3
{
    public partial class Form4 : Form
    {

        int flag = 0;
        int obtain = 0;
        string available = "0";
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet1.movieproject' table. You can move, or remove it, as needed.
            this.movieprojectTableAdapter.Fill(this.masterDataSet1.movieproject);

        }
      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int price;
            int refund;
            int singlerefund;
            int no;
            no = Convert.ToInt32(txt11.Text);
            obtain = no;
            price = int.Parse(txtsh.Text);
            if (flag == 1)
            {
                if (price > 350)
                {
                    singlerefund = 250;
                    refund = no*250;
                }
                else if (price >= 200 && price <= 350)
                {
                    singlerefund = 150;
                    refund = no*150;
                }
                else
                {
                    singlerefund = 0;
                    refund = 0;
                    MessageBox.Show("No Refund");

                }
                MessageBox.Show("Refund for one ticket  is:" + singlerefund);
                MessageBox.Show("Refund returned is:" + refund);
            }
            else
            {
                MessageBox.Show("ticket has expired.You cannot be refunded");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            if (datetimepicker.Value < dt)
            {
                MessageBox.Show("Ticket Expired");
                flag = 0;
            }
            else
            {
                flag = 1;
                MessageBox.Show("You will get refund:");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string current;
            int currentsh;
            int available1 = Convert.ToInt32(available);
            SqlConnection conn = new SqlConnection("Data Source=ADMIN-PC;Initial Catalog=master;Integrated Security=True");

            SqlCommand com = new SqlCommand("Select * from movieproject where  movieid='" + txt10.Text + "'", conn);
            try
            {
                conn.Open();
                SqlDataReader sr = com.ExecuteReader();

                while (sr.Read())
                {
                    MessageBox.Show(sr["moviename"].ToString() + " " + sr["actor"].ToString() + " " + sr["noofticketsavailable"].ToString());
                    current = sr["noofticketsavailable"].ToString();
                    currentsh = Convert.ToInt32(current);
                   // MessageBox.Show(obtain + " A" + current);
                    available1 = currentsh+obtain;
                    MessageBox.Show("Tickets now available are:" + available1);
                }
                sr.Close();
            }
            catch (SqlException ex)
            {


            }
            finally
            {
                conn.Close();
            }
        }

        
        
    }
}
