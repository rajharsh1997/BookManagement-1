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
    public partial class Books_UserControl : UserControl
    {
        private static Books_UserControl _instance;
        
        public static Books_UserControl instance
        {
          get
          {
            if(_instance==null)
            {
                    _instance = new Books_UserControl();
            }
                return _instance;
          }
        }
        public Books_UserControl()
        {
            InitializeComponent();
        }

        SqlConnection con= new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf; Integrated Security = True");

        private void Books_UserControl_Load(object sender, EventArgs e)
        {
            refresh_Data();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        public void refresh_Data()
        {
          try 
          {
                SqlCommand cmd = new SqlCommand("ShowBookData_SP", con);
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
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BooksAdd_SP ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@accno",Acc_text.Text);
            cmd.Parameters.AddWithValue("@isbn", ISBN_text.Text);
            cmd.Parameters.AddWithValue("@name", Name_text.Text);
            cmd.Parameters.AddWithValue("@author", Author_text.Text);
            cmd.Parameters.AddWithValue("@publisher", Publisher_text.Text);
            cmd.Parameters.AddWithValue("@dept_id", Dept_id_Text.Text);

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

            refresh_Data();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BookDelete_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo", Acc_text.Text);


                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();
                refresh_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Search
            try
            {
                SqlCommand cmd = new SqlCommand("SearchBook_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@accNo", textBox1.Text);

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
                this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Dept_id_Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Clear
            textBox1.Text="";
            Acc_text.Text = "";
            Publisher_text.Text = "";
            Dept_id_Text.Text = "";
            Name_text.Text = "";
            ISBN_text.Text = "";
            Author_text.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
        
    

