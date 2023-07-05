using MySql.Data.MySqlClient;
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
    public partial class DodavanjeNovihZivotinja : Form
    {
        public DodavanjeNovihZivotinja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           this.Close();
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Unos.Text ==""|| Unos.Text.Length<15 || Unos.Text.Length > 15)
            {
                MessageBox.Show("pogledajte ispravnost broja: "+ Unos.Text +" ima znakova : " +Unos.Text.Length);
            }
            else if(Unos.Text.Length == 15) 
            {

                bool rez = Unos.Text.All(Char.IsDigit);
                if (rez== false)
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
                    if (list.Contains(Unos.Text))
                    {
                        MessageBox.Show("POGRESKA BROJ KOJI JE UNESEN VEC POSTOJI");

                    }
                    else
                    {

                        MessageBox.Show("Uspjesno");
                        SqlConnection con = new SqlConnection("Data Source=antonio\\azelic;Initial Catalog=Registracija;Integrated Security=True;Encrypt=False");

                        DateOnly vrijeme1 = DateOnly.FromDateTime(DateTime.Now);

                        string cmdString = "";
                        con.Open();

                        cmdString = "insert into Reg(regBroj)" + " values(" + Unos.Text + ")";

                     
                       

                        string cmdString1 = "insert into Updates(dodaniBroj,datum)" +
                            "Values(" + Unos.Text + ",'" + vrijeme1 + "') ";
                        MessageBox.Show(vrijeme1.ToString());

                        SqlCommand cmd = new SqlCommand(cmdString, con);
                        SqlCommand cmd2 = new SqlCommand(cmdString1, con);
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();

                        con.Close();

                        

                        MessageBox.Show("Data Stored Successfully");
                    }
                }

            }
            
        }

      
    }
}
