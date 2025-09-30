using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach
{
    public partial class MainForm : Form
    {
        User user;
        Admin admin;
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(User user)
        {
            this.user = user;
        }
        public MainForm(Admin admin)
        {
            this.admin = admin;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
