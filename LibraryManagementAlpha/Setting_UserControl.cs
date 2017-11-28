using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementAlpha
{
    public partial class Setting_UserControl : UserControl
    {
        private static Setting_UserControl _instance;

        public static Setting_UserControl instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Setting_UserControl();
                }
                return _instance;
            }
        }
        public Setting_UserControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
