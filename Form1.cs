using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2Assignment
{
    public partial class frmL2Assignment : Form
    {
        public frmL2Assignment()
        {
            InitializeComponent();
        }

        private void btnShowMyContact_Click(object sender, EventArgs e)
        {
            lblName.Text = "Alan Chen";
            lblStreet.Text = "12823 Francine Ter.";
            lblCityState.Text = "Poway, CA 92064";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblName.Text = "Name";
            lblStreet.Text = "Street";
            lblCityState.Text = "City, State";
        }
    }
}
