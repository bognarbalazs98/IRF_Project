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
    public partial class Quiz : Form
    {
        QuizDatabaseEntities context = new QuizDatabaseEntities();
        List<Eredmeny> Eredmeny;
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        int maxpoint;


        public Quiz()
        {
            
            InitializeComponent();
            context.Eredmeny.Load();
            eredmenyBindingSource.DataSource = context.Eredmeny.Local;
            Adatbetoltes();
            eredmenyDataGridView.Refresh();
            this.Validate();



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

        private void button1_Click(object sender, EventArgs e)
        {
            eredmenyDataGridView.Refresh();
            this.Validate();
        }
        private void Adatbetoltes()
        {
            Eredmeny = context.Eredmeny.ToList();
        }
        private void CreateExcel()
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
              "Eredmény id",
              "Játékos neve",
              "Összpontszám",
              "Dátum",
              
            };

            for (int i = 0; i < 4; i++)
            {
                xlSheet.Cells[1, i + 1] = headers[i];
            }
            object[,] values = new object[Eredmeny.Count, headers.Length];
            int counter = 0;
            foreach (Eredmeny e in Eredmeny)
            {
                values[counter, 0] = e.Eredmeny_Id;
                values[counter, 1] = e.Jatekos_nev;
                values[counter, 2] = e.Eredmeny1;
                values[counter, 3] = e.Datum;
                //Convert.ToDateTime(values[counter, 3]) = e.Datum;
                // Sajnos nem tudom dátummá formálni, az excel számként kezeli a dátum mezőt :(

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

        private void btnjatekszabaly_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Játékszabályok: " + Environment.NewLine +
                "A játék során 1 peced van minél több kérdésre jól válazolni." + Environment.NewLine +
                "Minden jó válasz esetén 2 pontot kapsz, míg rossz válasz esetén 1 pont kerül levonásra."
                );
        }

        private void btnRanglista_Click(object sender, EventArgs e)
        {
            maxpoint = context.Eredmeny.Max(x => (int)x.Eredmeny1);
            //var champ = from y in context.Eredmeny
            //            where y.Eredmeny1 == maxpoint
            //            select y.Jatekos_nev.ToString();
           

            MessageBox.Show("A jelenlegi rekord " + maxpoint + " pont. Próbáld meg megdönteni!"  );
           
            
        }
    }
}
