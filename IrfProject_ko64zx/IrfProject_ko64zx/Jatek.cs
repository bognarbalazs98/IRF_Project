using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        int jovalasz = 0;
        int pont = 0;
        
        int q_id;
        Random rnd = new Random();
        int maxid;

        public Jatek()
        {
            InitializeComponent();
            context.Eredmeny.Load();
            eredmenyBindingSource.DataSource = context.Eredmeny.Local;
        }

        private void valaszellenorzes(object sender, EventArgs e)
        {
            var v = (Button)sender;
            int tag = Convert.ToByte(v.Tag);

            
            if (tag == helyesvalasz)
            {
                pont = pont + 2;
                jovalasz++;
            }
            else
            {
                pont = pont - 1;
            }
            kerdesgeneralas();
            
        }
        private void kerdezes(int kerdesid)
        {
            

        }
        private void kerdesgeneralas()
        {

            GetQuestionId();
            var q = context.Kerdes.Where(a => a.Kerdes_Id == q_id).SingleOrDefault();
            if (q != null)
            {
                
                label1.Text = q.Kerdes1;
                valasz1.Text = q.Valasz_1;
                valasz2.Text = q.Valasz_2;
                valasz3.Text = q.Valasz_3;
                valasz4.Text = q.Valasz_4;
                helyesvalasz = q.Helyes_valasz;
            }
            else
            {
                kerdesgeneralas();
                
            }
            

        }

       private void GetQuestionId()
        {

            maxid = context.Kerdes.Max(x => x.Kerdes_Id);

            q_id = rnd.Next(1, maxid);
            

        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kérlek add meg a neved");
            }
            else
            {
                kerdesgeneralas();
                label1.Visible = true;
                textBox1.Visible = false;
                label2.Visible = false;
                valasz1.Enabled = true;
                valasz2.Enabled = true;
                valasz3.Enabled = true;
                valasz4.Enabled = true;
                timer1.Enabled = true;
                startbtn.Visible = false;
            }

           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            DateTime dt = DateTime.Now;
            MessageBox.Show("Kedves " + textBox1.Text + "!"  +Environment.NewLine +
                "A játékidő lejárt!" + Environment.NewLine +
                "A játék során összesen " + jovalasz + " kérdésre válaszoltál jól és" + pont + " pontot szereztél" + Environment.NewLine +
                "Ha van kedved próbálkozz újra."
                );
            Eredmeny ujeredmeny = new Eredmeny();
            ujeredmeny.Jatekos_nev = textBox1.Text;
            ujeredmeny.Eredmeny1 = pont;
            ujeredmeny.Datum = dt;
            eredmenyBindingSource.Add(ujeredmeny);
            eredmenyBindingSource.EndEdit();
            context.SaveChanges();
            this.Close();
            
        }
    }
}
