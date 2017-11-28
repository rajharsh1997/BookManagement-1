using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementAlpha
{
    public partial class Transaction_UserControl : UserControl
    {
        private static Transaction_UserControl _instance;

        public static Transaction_UserControl instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Transaction_UserControl();
                }
                return _instance;
            }
        }
        public Transaction_UserControl()
        {
            InitializeComponent();
        }

        private void Transaction_UserControl_Load(object sender, EventArgs e)
        {

        }

        public string Book1, Book2, Borrower;

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf; Integrated Security = True");
        public SqlCommand cmd;
        public SqlDataReader dr;

        private void button2_Click(object sender, EventArgs e)
        {
            //SEARCH BOOKS
            //Borrowed By
            con.Open();
            String syntax = "SELECT borrower FROM book where accno='" + textBox2.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Borrowedby_label.Text = Borrower= dr[0].ToString();
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //BUTTON1 SEARCH BORROWERS
            //Search Borrowers
            //to get book 1
            con.Open();
            String syntax = "SELECT book1 FROM borrowers where brid='" + textBox1.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Book1_label.Text = Book1 = dr[0].ToString();
            con.Close();
            //Search Borrowers
            //to get book 2
            con.Open();
            syntax = "SELECT book2 FROM borrowers where brid='" + textBox1.Text + "'";
            cmd = new SqlCommand(syntax, con);
            dr = cmd.ExecuteReader();
            dr.Read();
            Book2_label.Text = Book2 = dr[0].ToString();
            con.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //ISSUE BOOK
            //see if book is borrowed by someone
            button2.PerformClick();
            if (Borrower != "")
            {
                //someone borrowed
                MessageBox.Show("Book is already borrowed by some other Borrrower with borrower id :\n" + Borrower);

                return;
            }
            //already taken 2 books
            button1.PerformClick();
            if ((Book1 != "") && (Book2 != ""))
            {
                //borrower has already borrowed
                MessageBox.Show("Borrower has already borrowed maximum no. of books");
                return;
            }

            try
            {
                if (Book1 == "")
                {
                    //accno must be updated in book1 slot
                    cmd = new SqlCommand("Transact_Update_Book1_SP", con);
                }
                else
                {
                    //accno must be updated in book2 slot
                    cmd = new SqlCommand("Transact_Update_Book2_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accno", textBox2.Text);
                cmd.Parameters.AddWithValue("@brid", textBox1.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("        <<<<INVALID SQL OPERATION>>>>: \n" + ex);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            //update the borrowers id in the book table
            cmd = new SqlCommand("Transact_Update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accno", textBox2.Text);
            cmd.Parameters.AddWithValue("@brid", textBox1.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("        <<<<INVALID SQL OPERATION>>>>: \n" + ex);

            }
            con.Close();

            //issue details in transaction update
            cmd = new SqlCommand("transactions_insert_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bkid", textBox2.Text);
            cmd.Parameters.AddWithValue("@brid", textBox1.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("        <<<<INVALID SQL OPERATION>>>>: \n" + ex);

            }
            con.Close();

            //this complete entire transaction 
            button1.PerformClick();
            button2.PerformClick();
            MessageBox.Show("Sucessfully issued");


        }

        private void button5_Click(object sender, EventArgs e)
        {
            //RETURN BOOOK

            //see if book is borrowed by someone
            button2.PerformClick();
            button1.PerformClick();
            if ((textBox2.Text != Book1)&&(textBox2.Text != Book2))
            {
                //someone borrowed
                MessageBox.Show("THE INPUTED BORROWER HAS NOT BORROWED THE BOOK INPUTED");

                return;
            }
            //Continue returning books
            

            try
            {
                if (Book1 == textBox2.Text)
                {
                    //accno must be updated in book1 slot
                    cmd = new SqlCommand("Transact_Update_Book1_SP", con);
                }
                else
                {
                    //accno must be updated in book2 slot
                    cmd = new SqlCommand("Transact_Update_Book2_SP", con);
                }
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@accno",(object)DBNull.Value);
                //cmd.Parameters.AddWithValue("@accno", "NULL");
                cmd.Parameters.AddWithValue("@brid", textBox1.Text);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("        <<<<INVALID SQL OPERATION>>>>: \n" + ex);

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            //update the borrowers id in the book table
            cmd = new SqlCommand("Transact_Update_Borrower_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@accno", textBox2.Text);
            cmd.Parameters.AddWithValue("@brid", (object)DBNull.Value);
           // cmd.Parameters.AddWithValue("@brid", "NULL");

            con.Open();
           try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("        <<<<INVALID SQL OPERATION>>>>: \n" + ex);

            }
            con.Close();

            //return details in transaction update
            /*cmd = new SqlCommand("transactions_delete_SP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bkid", textBox2.Text);
            cmd.Parameters.AddWithValue("@brid", textBox1.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("        <<<<INVALID SQL OPERATION>>>>: \n" + ex);

            }
            con.Close();*/

            //this complete entire transaction 
           button1.PerformClick();
           button2.PerformClick();
            MessageBox.Show("Sucessfully returned");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Transaction log
            try
            {
                SqlCommand cmd = new SqlCommand("ShowTransaction_log_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("         <<<INVALID SQL OPERATION>>>:\n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];
                this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CLEAR
            textBox1.Text = "";
            textBox2.Text = "";
            Book1_label.Text = "";
            Book2_label.Text = "";
            Borrowedby_label.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
