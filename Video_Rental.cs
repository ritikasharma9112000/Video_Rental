using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental
{
    public partial class Video_Rental : Form
    {
        classDB obj_Data = new classDB();
        public Video_Rental()
        {
            InitializeComponent();
            Customer_Load();
            Movies_Load();
            Rental_Load();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Customer_Load()
        {
            customer_grid.DataSource = null;
            try
            {
                customer_grid.DataSource = obj_Data.FillCustomer_Data();
                customer_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void movie_Click(object sender, EventArgs e)
        {
        }

        public void Movies_Load()
        {
            movie_grid.DataSource = null;
            try
            {
                movie_grid.DataSource = obj_Data.FillMovies_Data();
                movie_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Rental_Load()
        {
            rental_grid.DataSource = null;
            try
            {
                rental_grid.DataSource = obj_Data.FillRental_Data();
                rental_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void movie_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_customer_btn_Click(object sender, EventArgs e)
        {
            if (First_name_text.Text != "" && Last_name_text.Text != "" && Address_text.Text != "" && Phone_text.Text != "")
            {
                string message = obj_Data.CustomerInsert(First_name_text.Text, Last_name_text.Text, Address_text.Text, Phone_text.Text);
                MessageBox.Show(message);
                First_name_text.Text = "";
                Last_name_text.Text = "";
                Address_text.Text = "";
                Phone_text.Text = "";
                Customer_Load();
            }
            else
            {
                MessageBox.Show("Please complete all the text boxes and then press Add button");

            }
        }
    }
}
