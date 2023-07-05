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
    public partial class Arhiva : Form
    {
        public Arhiva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Hide();
            dataGridView1.Show();
        

            SqlConnection conn = new SqlConnection("Data Source=antonio\\azelic;Initial Catalog=Registracija;Integrated Security=True;Encrypt=False");
            SqlDataAdapter adapter = new SqlDataAdapter("Select povjesniBroj,datum from History", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            foreach (DataRow item in dt.Rows)
            {

                 int n = dataGridView1.Rows.Add();
                 dataGridView1.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value= item[1].ToString();   
                
              



            }
            conn.Close();   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Show();
            dataGridView2.Rows.Clear();

            SqlConnection conn = new SqlConnection("Data Source=antonio\\azelic;Initial Catalog=Registracija;Integrated Security=True;Encrypt=False");
            SqlDataAdapter adapter = new SqlDataAdapter("Select dodaniBroj,datum from Updates", conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

         
            foreach (DataRow item in dt.Rows)
            {

                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item[0].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item[1].ToString();





            }
            conn.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
