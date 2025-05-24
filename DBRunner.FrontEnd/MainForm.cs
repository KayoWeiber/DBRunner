using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBRunner.Core;
namespace DBRunner.Front
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var controleMySQL = new UserControlService();
            controleMySQL.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(controleMySQL);
            tabPage1.Text = "MySQL";
        }
    }
}
