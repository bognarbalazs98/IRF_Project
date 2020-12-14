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
    public partial class Jatek : Form
    {
        QuizDatabaseEntities context = new QuizDatabaseEntities();
        int helyesvalasz;
        int kerdesid;
        int pontok;
        int szazalek;
        

        public Jatek()
        {
            InitializeComponent();
        }

        private void valaszellenorzes(object sender, EventArgs e)
        {
            var v = (Button)sender;
            int tag = Convert.ToByte(v.Tag);

            if (tag == helyesvalasz)
            {

            }


        }
        private void kerdezes(int kerdesid)
        {


        }
        private void kerdesgeneralas()
        {
            int maxid = context.Kerdes.Max(x => x.Kerdes_Id);

        }
    }
}
