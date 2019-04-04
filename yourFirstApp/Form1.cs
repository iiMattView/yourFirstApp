using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yourFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lbl_helloUser.Text = "\nHallo " + Environment.UserName + ",\n gratulation zu deiner ersten selbstkompilierten C# App";
        }
    }
}
