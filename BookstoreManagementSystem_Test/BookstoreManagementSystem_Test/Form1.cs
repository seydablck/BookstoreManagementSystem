using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookstoreManagementSystem_Test
{


    public partial class Form1 : Form
    {
        public string connectionString = "YOUR CONNECTION STRING";

        public Form1()
        {
            InitializeComponent();
        }

        //In this part Insert Button which in Staff Page is activated with INSERT operation (Insert 1).
        private void btn_save_staff_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Staff(staff_id,first_name,last_name,job_title,bank_name,acc_num)
                                   VALUES (@staff_id,@first_name,@last_name,@job_title,@bank_name,@acc_num)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first_name", txt_staff_FirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txt_staff_LastName.Text);
                    cmd.Parameters.AddWithValue("@staff_id", txt_staff_id.Text);
                    cmd.Parameters.AddWithValue("@job_title", txt_staff_JobTitle.Text);
                    cmd.Parameters.AddWithValue("@bank_name", txt_staff_BankName.Text);
                    cmd.Parameters.AddWithValue("@acc_num", txt_staff_AccNum.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error inserting data into db!");
                    }
                    else
                    {
                        MessageBox.Show("Staff is added Successfully!");
                    }

                }
            }

        }

        //In this part Insert Button which in Customer Page is activated with INSERT operation (Insert 2).
        private void btn_save_customer_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Customer(customer_name,customer_id,contact_number,email,adress)
                                   VALUES (@customer_name,@customer_id,@contact_number,@email,@adress)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customer_name", txt_customer_Name.Text);
                    cmd.Parameters.AddWithValue("@customer_id", txt_customer_id.Text);
                    cmd.Parameters.AddWithValue("@contact_number", txt_customer_ConNum.Text);
                    cmd.Parameters.AddWithValue("@email", txt_customer_Mail.Text);
                    cmd.Parameters.AddWithValue("@adress", txt_customer_Address.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("Error inserting data into db!");
                    }
                    else
                    {
                        MessageBox.Show("Customer is added Successfully!");
                    }

                }
            }
        }

        //In this part Insert Button which in Payment Page is activated with INSERT operation (Insert 3).
        private void btn_save_pay_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Payment(payment_id,pay_date, pay_amt)
                                   VALUES (@payment_id,@pay_date,@pay_amt)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@payment_id", txt_pay_id.Text);
                    cmd.Parameters.AddWithValue("@pay_date", txt_pay_date.Text);
                    cmd.Parameters.AddWithValue("@pay_amt", txt_pay_amt.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("Error inserting data into db!");
                    }
                    else
                    {
                        MessageBox.Show("Payment informations are added Successfully!");
                    }

                }
            }
        }

        //In this part Delete Button which in Staff Page is activated with DELETE operation (Delete 1).
        private void btn_delete_staff_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM  Staff WHERE staff_id = @staff_id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first_name", txt_staff_FirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txt_staff_LastName.Text);
                    cmd.Parameters.AddWithValue("@staff_id", txt_staff_id.Text);
                    cmd.Parameters.AddWithValue("@job_title", txt_staff_JobTitle.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Staff is deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! Staff cannot be deleted. Please enter Staff ID correctly!");
                    }

                }
            }

        }

        //In this part Delete Button which in Customer Page is activated with DELETE operation (Delete 2).
        private void btn_delete_customer_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Customer WHERE customer_id = @customer_id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customer_name", txt_customer_Name.Text);
                    cmd.Parameters.AddWithValue("@customer_id", txt_customer_id.Text);
                    cmd.Parameters.AddWithValue("@contact_number", txt_customer_ConNum.Text);
                    cmd.Parameters.AddWithValue("@email", txt_customer_Mail.Text);
                    cmd.Parameters.AddWithValue("@adress", txt_customer_Address.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Customer is deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! Customer cannot be deleted. Please enter Customer ID correctly!");
                    }

                }
            }
        }

        //In this part Delete Button which in Payment Page is activated with DELETE operation (Delete 3).
        private void btn_delete_pay_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Payment WHERE payment_id = @payment_id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@payment_id", txt_pay_id.Text);
                    cmd.Parameters.AddWithValue("@pay_date", txt_pay_date.Text);
                    cmd.Parameters.AddWithValue("@pay_amt", txt_pay_amt.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    
                    if (result > 0)
                    {
                        MessageBox.Show("Payment informations are deleted Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Payment informations cannot be deleted. Please enter Payment ID correctly!");
                    }

                }
            }
        }

        //In this part Update Button which in Staff Page is activated with DELETE operation (Update 1).
        private void btn_update_staff_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Staff SET first_name = @first_name, last_name = @last_name, staff_id = @staff_id, job_title = @job_title, bank_name = @bank_name, acc_num = @acc_num
                                              WHERE staff_id = @staff_id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first_name", txt_staff_FirstName.Text);
                    cmd.Parameters.AddWithValue("@last_name", txt_staff_LastName.Text);
                    cmd.Parameters.AddWithValue("@staff_id", txt_staff_id.Text);
                    cmd.Parameters.AddWithValue("@job_title", txt_staff_JobTitle.Text);
                    cmd.Parameters.AddWithValue("@bank_name", txt_staff_BankName.Text);
                    cmd.Parameters.AddWithValue("@acc_num", txt_staff_AccNum.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Staff informations updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! Staff informations cannot be updateded. Please enter Staff ID correctly!");
                    }

                }
            }
        }

        //In this part Update Button which in Customer Page is activated with DELETE operation (Update 2).
        private void btn_update_customer_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Customer SET customer_name = @customer_name, customer_id = @customer_id,
                                                contact_number = @contact_number, email = @email, adress = @adress
                                                WHERE customer_id = @customer_id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customer_name", txt_customer_Name.Text);
                    cmd.Parameters.AddWithValue("@customer_id", txt_customer_id.Text);
                    cmd.Parameters.AddWithValue("@contact_number", txt_customer_ConNum.Text);
                    cmd.Parameters.AddWithValue("@email", txt_customer_Mail.Text);
                    cmd.Parameters.AddWithValue("@adress", txt_customer_Address.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    /*SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView_customer.DataSource = dt;*/

                    if (result > 0)
                    {
                        MessageBox.Show("Customer informations updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! Customer informations cannot be updateded. Please enter Customer ID correctly!");
                    }

                }
            }
        }

        //In this part Update Button which in Payment Page is activated with DELETE operation (Update 3).
        private void btn_update_pay_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Payment SET pay_date = @pay_date, pay_amt = @pay_amt, payment_id = @payment_id
                                              WHERE payment_id = @payment_id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@payment_id", txt_pay_id.Text);
                    cmd.Parameters.AddWithValue("@pay_date", txt_pay_date.Text);
                    cmd.Parameters.AddWithValue("@pay_amt", txt_pay_amt.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Payment informations updated Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error! Payment informations cannot be updateded. Please enter Staff ID correctly!");
                    }

                }
            }
        }

        //Whichever of the buttons on this part product page is pressed, it switches to its page.
        private void btn_Book_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btn_Movie_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }

        private void btn_Music_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'bookstoreDataSet6.StaffInfo' table. You can move, or remove it, as needed.
            this.staffInfoTableAdapter.Fill(this.bookstoreDataSet6.StaffInfo);
            // TODO: This line of code loads data into the 'bookstoreDataSet5.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.bookstoreDataSet5.Payment);
            // TODO: This line of code loads data into the 'bookstoreDataSet4.showMusicDetails' table. You can move, or remove it, as needed.
            this.showMusicDetailsTableAdapter.Fill(this.bookstoreDataSet4.showMusicDetails);
            // TODO: This line of code loads data into the 'bookstoreDataSet3.showBookDetails' table. You can move, or remove it, as needed.
            this.showBookDetailsTableAdapter.Fill(this.bookstoreDataSet3.showBookDetails);
            // TODO: This line of code loads data into the 'bookstoreDataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.bookstoreDataSet2.Customer);
            // TODO: This line of code loads data into the 'bookstoreDataSet1.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.bookstoreDataSet1.Staff);
            // TODO: This line of code loads data into the 'bookstoreDataSet.showMovieDetails' table. You can move, or remove it, as needed.
            this.showMovieDetailsTableAdapter.Fill(this.bookstoreDataSet.showMovieDetails);

        }

        
        private void dataGridView_staff_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_staff_id.Text = dataGridView_staff.SelectedRows[0].Cells[0].Value.ToString();
            txt_staff_FirstName.Text = dataGridView_staff.SelectedRows[0].Cells[1].Value.ToString();
            txt_staff_LastName.Text = dataGridView_staff.SelectedRows[0].Cells[2].Value.ToString();
            txt_staff_JobTitle.Text = dataGridView_staff.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void dataGridView_customer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_customer_id.Text = dataGridView_customer.SelectedRows[0].Cells[0].Value.ToString();
            txt_customer_Name.Text = dataGridView_customer.SelectedRows[0].Cells[1].Value.ToString();
            txt_customer_ConNum.Text = dataGridView_customer.SelectedRows[0].Cells[2].Value.ToString();
            txt_customer_Mail.Text = dataGridView_customer.SelectedRows[0].Cells[3].Value.ToString();
            txt_customer_Address.Text = dataGridView_customer.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void dataGridView_payment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_pay_date.Text = dataGridView_payment.SelectedRows[0].Cells[0].Value.ToString();
            txt_pay_amt.Text = dataGridView_payment.SelectedRows[0].Cells[1].Value.ToString();
            txt_pay_id.Text = dataGridView_payment.SelectedRows[0].Cells[2].Value.ToString();
        }

        //In this part Select Button which in Book Page is activated with Select operation (Select 1).
        private void btn_select_book_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM showBookDetails WHERE product_id = @product_id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_id", txt_book_info.Text);

                    conn.Open();
                    
                    int result = cmd.ExecuteNonQuery();

                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView_book.DataSource = dt;

                    if (result > 0)
                    {
                        MessageBox.Show("Producy Book cannot be selected. Please enter Product ID correctly!");
                    }
                    else
                    {
                        MessageBox.Show("Product Book selected Successfully!");
                    }

                }
            }
        }

        //In this part Select Button which in Movie Page is activated with Select operation (Select 2).
        private void btn_select_movie_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM showMovieDetails WHERE product_id = @product_id ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_id", txt_movie_info.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView_movie.DataSource = dt;

                    if (result > 0)
                    {
                        MessageBox.Show("Producy Movie cannot be selected. Please enter Product ID correctly!");
                    }
                    else
                    {
                        MessageBox.Show("Product Movie selected Successfully!");
                    }

                }
            }
        }

        //In this part Select Button which in Music Page is activated with Select operation (Select 3).
        private void btn_select_music_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM showMusicDetails WHERE product_id = @product_id ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@product_id", txt_music_info.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView_music.DataSource = dt;

                    if (result > 0)
                    {
                        MessageBox.Show("Producy Music cannot be selected. Please enter Product ID correctly!");
                    }
                    else
                    {
                        MessageBox.Show("Product Music selected Successfully!");
                    }

                }
            }
        }

        //In this part Select Button which in Customer Page is activated with Select operation (Select 4).
        private void btn_select_customer_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM Customer WHERE customer_id = @customer_id ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customer_id", txt_customer_id.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView_music.DataSource = dt;

                    if (result > 0)
                    {
                        MessageBox.Show("Customer cannot be selected. Please enter Customer ID correctly!");
                    }
                    else
                    {
                        MessageBox.Show("Customer selected Successfully!");
                    }

                }
            }
        }

        //In this part Select Button which in Payment Page is activated with Select operation (Select 5).
        private void btn_select_payment_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM Payment WHERE payment_id = @payment_id ";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@payment_id", txt_pay_id.Text);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    SqlDataAdapter ad = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    dataGridView_music.DataSource = dt;

                    if (result > 0)
                    {
                        MessageBox.Show("Payment cannot be selected. Please enter Product ID correctly!");
                    }
                    else
                    {
                        MessageBox.Show("Payment selected Successfully!");
                    }

                }
            }
        }
    }
}
