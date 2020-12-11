using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IrfProject_ko64zx
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            Jatek jatek = new Jatek();
            jatek.Show();
        }

        private void kerdesekbtn_Click(object sender, EventArgs e)
        {
            Kerdesek kerdesek = new Kerdesek();
            kerdesek.Show();
        }
    }
}
