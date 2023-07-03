using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registar
{
    public partial class Brisanje : Form
    {
        public Brisanje()
        {
            InitializeComponent();
        }

        private void Brisi_Click(object sender, EventArgs e)
        {
            if (Brisanje_txt.Text == "" || Brisanje_txt.Text.Length < 15 || Brisanje_txt.Text.Length > 15)
            {
                MessageBox.Show("pogledajte ispravnost broja: " + Brisanje_txt.Text + " ima znakova : " + Brisanje_txt.Text.Length);
            }
            else if (Brisanje_txt.Text.Length == 15)
            {

                bool rez = Brisanje_txt.Text.All(Char.IsDigit);
                if (rez == false)
                {
                    MessageBox.Show("greska unosa: TEKST MORA SADRZAVATI SAMO BROJEVE");
                }
                else
                {
                    List<string> list = new List<string>();
                    SqlConnection conn = new SqlConnection("Data Source=antonio\\azelic;Initial Catalog=Registracija;Integrated Security=True;Encrypt=False");
                    SqlDataAdapter adapter = new SqlDataAdapter("Select regBroj from Reg", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    foreach (DataRow item in dt.Rows)
                    {

                        /* int n = dataGridView1.Rows.Add();
                         dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();
                         //umetanje u listu*/
                        list.Add(item[0].ToString());



                    }
                    if (list.Contains(Brisanje_txt.Text))
                    {
                        MessageBox.Show("Uspjesno");
                        SqlConnection con = new SqlConnection("Data Source=antonio\\azelic;Initial Catalog=Registracija;Integrated Security=True;Encrypt=False");



                        string cmdString = "";
                        con.Open();

                        cmdString = "delete from Reg where regBroj=" + Brisanje_txt.Text + ";";

                        SqlCommand cmd = new SqlCommand(cmdString, con);
                        cmd.ExecuteNonQuery();

                        con.Close();

                        MessageBox.Show("Data Stored Successfully");

                    }
                    else
                    {

          

                        MessageBox.Show("POGRESKA BROJ KOJI JE UNESEN NE POSTOJI U BAZI PODATAKA");
                    }
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Start s=new Start();
            s.Show();
            this.Close();
        }
    }
}
