using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     
        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Show();
            cmdmovies.Items.Add(new Movies("5.Singh is Bling"));
            cmdupcoming.Items.Add(new Movies("5.Dilwale"));
            // Form1.ForeColor= System.Drawing.Color.Red;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("69% Kis kisko pyaar karoon:\n70%Subramanyam For Sale (U/A):\n81%Maya (U/A):\n50%Calendar Girls (A):\n83%Bale Bale Magadivoy (U):\n72%Everest (3D) (U/A):\n");

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
        public void button1_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
      
    }
}
