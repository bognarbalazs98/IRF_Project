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
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace IrfProject_ko64zx
{
    public partial class Kerdesek : Form
    {
        QuizDatabaseEntities context = new QuizDatabaseEntities();
        List<Kerdes> Kerdes;
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public Kerdesek()
        {

            InitializeComponent();
            context.Kerdes.Load();
            kerdesBindingSource.DataSource = context.Kerdes.Local;
            Adatbetoltes();

            //KerdesListazas();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kerdestxt.Text == "" || valasz1txt.Text == "" || valasz2txt.Text == "" || valasz3txt.Text == "" || valasz4txt.Text == "")
            {
                MessageBox.Show("Kérlek add meg a kérdést és az összes válaszlehetőséget is!");
            }

            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
            {
                MessageBox.Show("Kérlek add meg a helyes választ!");
            }
            else
            {
                int hv;
                if (checkBox1.Checked == true)
                {
                    hv = 1;
                }
                else if (checkBox2.Checked == true)
                {
                    hv = 2;
                }
                else if (checkBox3.Checked == true)
                {
                    hv = 3;
                }
                else
                {
                    hv = 4;
                }

                Kerdes ujkerdes = new Kerdes();
                
                ujkerdes.Kerdes1 = kerdestxt.Text;
                ujkerdes.Valasz_1 = valasz1txt.Text;
                ujkerdes.Valasz_2 = valasz2txt.Text;
                ujkerdes.Valasz_3 = valasz3txt.Text;
                ujkerdes.Valasz_4 = valasz4txt.Text;
                ujkerdes.Helyes_valasz = hv;

                


                Mentes mentes = new Mentes();
                if (mentes.ShowDialog() == DialogResult.OK)
                {
                    kerdesBindingSource.Add(ujkerdes);
                    kerdesBindingSource.EndEdit();
                    try
                    {
                        this.Validate();
                        context.SaveChanges();
                        MessageBox.Show("Az új kérdést sikeresen hozzáadtad a játékhoz.");
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }
                    kerdesDataGridView.Refresh();
                    kerdestxt.Clear();
                    valasz1txt.Clear();
                    valasz2txt.Clear();
                    valasz3txt.Clear();
                    valasz4txt.Clear();
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                }

                else
                {
                    MessageBox.Show("Az új kérdés nem került rögzítésre.");
                    return;
                }

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Torles del = new Torles();
            if (del.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    int index;
                    index = kerdesDataGridView.CurrentCell.RowIndex;
                    kerdesDataGridView.Rows.RemoveAt(index);
                    kerdesDataGridView.Refresh();
                    context.SaveChanges();
                    MessageBox.Show("A kérdés törölve lett");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                return;
            }
        }

        private void Adatbetoltes()
        {
            Kerdes = context.Kerdes.ToList();
        }
        private void  CreateExcel()
        {
            try
            {
                xlApp = new Excel.Application();
                xlWB = xlApp.Workbooks.Add(Missing.Value);
                xlSheet = xlWB.ActiveSheet;
                CreateTable(); 
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
                
            }

        }

        private void CreateTable()
        {
            string[] headers = new string[]
            {
              "Kérdés Id",
              "Kérdés", 
              "Válasz 1",
              "Válasz 2",
              "Válasz 3",
              "Válasz 4",
              "Helyes válasz",
            };

            for (int i = 0; i < 7; i++)
            {
                xlSheet.Cells[1, i+1] = headers[i];
            }
            object[,] values = new object[Kerdes.Count, headers.Length];
            int counter = 0;
            foreach (Kerdes k in Kerdes)
            {
                values[counter, 0] = k.Kerdes_Id;
                values[counter, 1] = k.Kerdes1;
                values[counter, 2] = k.Valasz_1;
                values[counter, 3] = k.Valasz_2;
                values[counter, 4] = k.Valasz_3;
                values[counter, 5] = k.Valasz_4;
                values[counter, 6] = k.Helyes_valasz;
                
                counter++;
            }
                xlSheet.get_Range(
                 GetCell(2, 1),
                 GetCell(1 + values.GetLength(0), values.GetLength(1))).Value2 = values;

            Excel.Range headerRange = xlSheet.get_Range(GetCell(1, 1), GetCell(1, headers.Length));
            headerRange.Font.Bold = true;
            headerRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.EntireColumn.AutoFit();
            headerRange.RowHeight = 40;
            headerRange.Interior.Color = Color.LawnGreen;
            headerRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);

        }

       
        private string GetCell(int x, int y)
        {
            string ExcelCoordinate = "";
            int dividend = y;
            int modulo;

            while (dividend > 0)
            {
                modulo = (dividend - 1) % 26;
                ExcelCoordinate = Convert.ToChar(65 + modulo).ToString() + ExcelCoordinate;
                dividend = (int)((dividend - modulo) / 26);
            }
            ExcelCoordinate += x.ToString();

            return ExcelCoordinate;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateExcel();
        }

     
    }
}
