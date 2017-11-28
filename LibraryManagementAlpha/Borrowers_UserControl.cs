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
    public partial class Borrowers_UserControl : UserControl
    {
        private static Borrowers_UserControl _instance;

        public static Borrowers_UserControl instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Borrowers_UserControl();
                }
                return _instance;
            }
        }
        public Borrowers_UserControl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf; Integrated Security = True");

        private void Borrowers_UserControl_Load(object sender, EventArgs e)
        {
            refresh_data();
        }
        public void refresh_data()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowBorrowersData_SP", con);
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
        private void button1_Click(object sender, EventArgs e)
        {
         
            try
            {
                SqlCommand cmd = new SqlCommand("ShowBorrowersData_SP", con);
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
            SqlCommand cmd = new SqlCommand("BorrowersAdd_SP ", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@brid", textBox1.Text);
            cmd.Parameters.AddWithValue("@name", textBox2.Text);
            cmd.Parameters.AddWithValue("@address", textBox3.Text);
            cmd.Parameters.AddWithValue("@phone", textBox4.Text);

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

            refresh_data();
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("BorrowersDelete_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@brid", textBox1.Text);


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
                refresh_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
