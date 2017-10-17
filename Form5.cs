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
    public partial class Form5 : Form
    {
        string a;
        string current = "0";
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet1.movieproject' table. You can move, or remove it, as needed.
            this.movieprojectTableAdapter.Fill(this.masterDataSet1.movieproject);
            // TODO: This line of code loads data into the 'masterDataSet.movieshemal' table. You can move, or remove it, as needed.
            this.movieshemalTableAdapter.Fill(this.masterDataSet.movieshemal);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (txt2.Text == "1")
            {
              //  MessageBox.Show("Kis kisko pyaar karoon");
                current = "0";
                SqlConnection conn = new SqlConnection("Data Source=ADMIN-PC;Initial Catalog=master;Integrated Security=True");
                
                SqlCommand com = new SqlCommand("Select * from movieproject where  movieid='" + txt2.Text + "'", conn);
                try
                {
                    conn.Open();
                    SqlDataReader sr = com.ExecuteReader();

                    while (sr.Read())
                    {
                        MessageBox.Show(sr["moviename"].ToString()+" "+sr["actor"].ToString()+" "+sr["noofticketsavailable"].ToString());
                        current =sr["noofticketsavailable"].ToString();
                        a = current;
                        //MessageBox.Show(current);
                    }
                    sr.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    conn.Close();
                }
            

                }
            if (txt2.Text == "2")
            {
                current = "0";
                //  MessageBox.Show("Kis kisko pyaar karoon");
                SqlConnection conn = new SqlConnection("Data Source=ADMIN-PC;Initial Catalog=master;Integrated Security=True");

                SqlCommand com = new SqlCommand("Select * from movieproject where  movieid='" + txt2.Text + "'", conn);
                try
                {
                    conn.Open();
                    SqlDataReader sr = com.ExecuteReader();

                    while (sr.Read())
                    {
                        MessageBox.Show(sr["moviename"].ToString() + " " + sr["actor"].ToString() + " " + sr["noofticketsavailable"].ToString());
                        current = sr["noofticketsavailable"].ToString();
                        a = current;
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
            if (txt2.Text == "3")
            {
                current = "0";
                //  MessageBox.Show("Kis kisko pyaar karoon");
                SqlConnection conn = new SqlConnection("Data Source=ADMIN-PC;Initial Catalog=master;Integrated Security=True");

                SqlCommand com = new SqlCommand("Select * from movieproject where  movieid='" + txt2.Text + "'", conn);
                try
                {
                    conn.Open();
                    SqlDataReader sr = com.ExecuteReader();

                    while (sr.Read())
                    {
                        MessageBox.Show(sr["moviename"].ToString() + " " + sr["actor"].ToString() + " " + sr["noofticketsavailable"].ToString());
                        current = sr["noofticketsavailable"].ToString();
                        a = current;
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
            if (txt2.Text == "4")
            {
                current = "0";
                //  MessageBox.Show("Kis kisko pyaar karoon");
                SqlConnection conn = new SqlConnection("Data Source=ADMIN-PC;Initial Catalog=master;Integrated Security=True");

                SqlCommand com = new SqlCommand("Select * from movieproject where  movieid='" + txt2.Text + "'", conn);
                try
                {
                    conn.Open();
                    SqlDataReader sr = com.ExecuteReader();

                    while (sr.Read())
                    {
                        MessageBox.Show(sr["moviename"].ToString() + " " + sr["actor"].ToString() + " " + sr["noofticketsavailable"].ToString());
                        current = sr["noofticketsavailable"].ToString();
                        a = current;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(a);
            int n2 = Convert.ToInt32(textBox1.Text);
            int n3 = n1 - n2;
           // MessageBox.Show(""+n3);
            if(n3>0)
            {
                MessageBox.Show("tickets can be allocated:");
                a = Convert.ToString(n3);
                MessageBox.Show("tickets remaining are:"+a);
            }
            else
            {
                MessageBox.Show("Show is housefull  Search for another movie:");
            }
        }
            }
        }
    
