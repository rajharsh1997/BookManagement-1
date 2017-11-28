using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace LibraryManagementAlpha
{
    public partial class App : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1; 
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();








        public App()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;      
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            this.Hide();
            obj.Show();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            { 
              ReleaseCapture(); 
              SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          if(! ContentPanel.Controls.Contains(Books_UserControl.instance))
             {
                ContentPanel.Controls.Add(Books_UserControl.instance);
                Books_UserControl.instance.Dock = DockStyle.Fill;
                Books_UserControl.instance.BringToFront();
             }
         else
         {
                Books_UserControl.instance.BringToFront();

         }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Borrowers_UserControl.instance))
            {
                ContentPanel.Controls.Add(Borrowers_UserControl.instance);
                Borrowers_UserControl.instance.Dock = DockStyle.Fill;
                Borrowers_UserControl.instance.BringToFront();
            }
            else
            {
                Borrowers_UserControl.instance.BringToFront();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Transaction_UserControl.instance))
            {
                ContentPanel.Controls.Add(Transaction_UserControl.instance);
                Transaction_UserControl.instance.Dock = DockStyle.Fill;
                Transaction_UserControl.instance.BringToFront();
            }
            else
            {
                Transaction_UserControl.instance.BringToFront();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(Setting_UserControl.instance))
            {
                ContentPanel.Controls.Add(Setting_UserControl.instance);
                Setting_UserControl.instance.Dock = DockStyle.Fill;
                Setting_UserControl.instance.BringToFront();
            }
            else
            {
                Setting_UserControl.instance.BringToFront();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(About_UserControl.instance))
            {
                ContentPanel.Controls.Add(About_UserControl.instance);
                About_UserControl.instance.Dock = DockStyle.Fill;
                About_UserControl.instance.BringToFront();
            }
            else
            {
                About_UserControl.instance.BringToFront();

            }
        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ContentPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
