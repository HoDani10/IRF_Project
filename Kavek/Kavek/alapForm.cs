using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kavek
{
    public partial class alapForm : Form
    {
        public alapForm()
        {
            InitializeComponent();
        }

        private void szuroformbtn_Click(object sender, EventArgs e)
        {
            szuroForm szf = new szuroForm();
            szf.Show();
            Hide();
        }
    }
}
