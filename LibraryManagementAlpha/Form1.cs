using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementAlpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Uname = "Admin", Upass = "Admin", name, pass;
            name = textBox1.Text;
            pass = textBox2.Text;
            if(name.Equals(Uname)&&pass.Equals(Upass))
            {
                label4.Hide();
                
                App obj = new App();
                this.Hide();
                obj.Show();
            }
            else
            {
                label4.Show();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
