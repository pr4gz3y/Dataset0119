using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dataset0119
{
    public partial class Form1 : Form
    {
        Random vel = new Random();
        string[] vezeteknev = { "Oláh", "Kovács", "Dombi", "Raffael", "Kolompár" };
        string[] noikeresztnev = { "Anna", "Klári", "Sára", "Anita", "Zsófi" };
        string[] ferfikeresztnev = { "BMW Individual M760Li xDrive Model V12", "Marci Csibész", "Samu King", "Bálint", "Milán" };
        public Form1()
        {
            InitializeComponent();

            //írj függvényt 'Data' névvel
            //paraméterei: 'DataRow[], amiben a DataRowban szereplő mezők'
            //visszatérési értéke: string, ami a html

            DataSet adatbazis = new DataSet();
            DataTable dt = new DataTable("Szemelyek");
            DataColumn column = dt.Columns.Add("Szemely_id", typeof(int));
            column.AutoIncrement = true;
            column.AutoIncrementSeed = 1;
            column.AutoIncrementStep = 1;

            dt.PrimaryKey = new DataColumn[] { column };

            dt.Columns.Add("Nev", typeof(string));
            dt.Columns.Add("Nem", typeof(int));
            dt.Columns.Add("Kor", typeof(int));
            dt.Columns.Add("Fizetes", typeof(decimal));
        }

        private void generatebutton_Click(object sender, EventArgs e)
        {
            DataTable dt = adatbazis.Tables["Szemelyek"];

            for (int i = 0; i < 5; i++)
            {
                DataRow dr = dt.NewRow();

                if (vel.Next(1, 3) == 2)
                {
                    dr["Nem"] = "Ferfi";
                    dr["Nev"] = $"{vezeteknev[vel.Next(vezeteknev.Length)]} {ferfikeresztnev[vel.Next(ferfikeresztnev.Length)]}";
                }
                else
                {
                    dr["Nem"] = "Nő";
                    dr["Nev"] = $"{vezeteknev[vel.Next(vezeteknev.Length)]} {noikeresztnev[vel.Next(noikeresztnev.Length)]}";
                }

                dr["Kor"] = vel.Next(18, 60);
                dr["Fizetes"] = vel.Next(350, 1200) * 1000;
                dt.Rows.Add(dr);
            }

            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Nev"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            decimal salary = 0;
            int db = 0;
            foreach (DataRow dr in dt.Rows) 
            {
                salary += (decimal)dr["Fizetes"];
                db++;
            }

            decimal avg = salary / db;
            Fizatlag.Text = $"Átlag fizetés: {avg}";



            int eletkor = 0;
            int dbkor = 0;
            foreach(DataRow dr in dt.Rows)
            {
                eletkor += (int)dr["Kor"];
                dbkor++;
            }

            decimal avgelet = eletkor / dbkor;
            Eletatlag.Text = $"Átlag életkor: {avgelet}";


            DataRow[] rows = dt.Select("Nem = 'Nő'");
            foreach (DataRow dr in rows)
            {
                nonevek.Items.Add(dr["Nev"]);
            }

            DataRow[] listb = dt.Select();
            string[] mezok = { "Nev", "Nem", "Kor" };

            DataToHTML(listb, mezok);

        }

        string DataToHTML(DataRow[] rows, string[] fields)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html>");

            sb.Append("<style>");
            sb.Append("<table, tr {border: 1px, solid, black}>");
            sb.Append("</style>");

            sb.Append("<body>");

            sb.Append("<talbe>");
            sb.Append("<tr>");
            foreach (string mezo in fields)
            {
                sb.Append($"<th> {mezo}");
            }

            return null;
        }
    }
}
