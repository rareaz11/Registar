using System.Data;
using System.Data.SqlClient;

namespace Registar
{
    public partial class Dodavanje : Form

    { 
      List<string> list = new List<string>();// zivotinje iz baze podatka koje moraju bit na farmi
        List<string> novo = new List<string>();//one koje su dosle a pripadaju bazi podatka
        List<string> notOnFarm=new List<string>(); //one koje su se upisala u listu a nema ih uopce u bazi podataka
        List<string> dontCome=new List<string>();   //one koje nisu dosle a na popisu su u bazi podataka
        Random random = new Random();
        public Dodavanje()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


            SqlConnection con = new SqlConnection("Data Source=antonio\\azelic;Initial Catalog=Registracija;Integrated Security=True;Encrypt=False");
            SqlDataAdapter adapter = new SqlDataAdapter("Select regBroj from Reg", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

           
            foreach (DataRow item in dt.Rows)
            {
                
               /* int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();
                //umetanje u listu*/
                list.Add(item[0].ToString());
                dontCome.Add(item[0].ToString());
              

            }


        }



        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=antonio\\azelic;Initial Catalog=Registracija;Integrated Security=True;Encrypt=False");
            SqlDataAdapter adapter = new SqlDataAdapter("Select regBroj from Reg", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            MessageBox.Show("BROJNO STANJE ZIVOTINJA: " + novo.Count);
            MessageBox.Show("BROJNO STANJE u bazi ZIVOTINJA: " + list.Count);

            

            for (int i = 0; i < novo.Count; i++)
                {
                for (int j = 0; j < dontCome.Count; j++)
                {
                    if (dontCome[j]==novo[i])
                    {
                        dontCome.Remove(dontCome[j]);

                       
                    }

                    
                }

                }
            MessageBox.Show("BROJNO STANJE ZIVOTINJA koje nisu dosle: " + dontCome.Count);


            /* for (int i = 0; i < dataGridView1.RowCount; i++)
             {

                 MessageBox.Show(dataGridView1.Rows[i].Cells[1].ToString());
                  if (dataGridView1.Rows[i].Cells[1].Value.ToString().Contains(Reg.Text.ToString()))
                  {
                      dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                      break;


                  }
                  else
                  {
                      //ako ne postoji u gridu ubaci ga u prvi column
                      int g = dataGridView1.Rows.Add();
                      dataGridView1.Rows[g].Cells[0].Value = Reg.Text.ToString();
                      dataGridView1.Rows[g].DefaultCellStyle.BackColor = Color.Red;
                  }



             }*/
            
        }






        private void button2_Click(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection("Data Source=antonio\\azelic;Initial Catalog=Registracija;Integrated Security=True;Encrypt=False");
            SqlDataAdapter adapter = new SqlDataAdapter("Select regBroj from Reg", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);


            foreach (DataRow item in dt.Rows)
            {

                 int n = dataGridView1.Rows.Add();
                 dataGridView1.Rows[n].Cells[1].Value = item[0].ToString();
                 
            

            }


            for(int i = 0; i < novo.Count; i++) 
            {

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = novo[i].ToString();



            }

            for(int i = 0; i < dontCome.Count; i++) 
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[2].Value = dontCome[i].ToString();
            }

            for (int i = 0; i < notOnFarm.Count; i++)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[3].Value = notOnFarm[i].ToString();
            }





            // sluzi za testiranje
            //novo.Add("127474747474747");
            //novo.Add("127474747475115");
            //novo.Add("127474747474888");
            //novo.Add("657483910987653");
            //novo.Add("372937492839384");

            //novo.Add("127474747474747");
            //novo.Add("127474747474747");
            //novo.Add("127474747474747");
            //novo.Add("127474747474747");
            //novo.Add("127474747474747");
            //novo.Add("127474747474747");
            //novo.Add("127474747474747");
            //novo.Add("127474747474747");


            //    for (int i = 0; i < list.Count; i++)
            //    {

            //        if (novo.Contains(list[i]))
            //        {


            //            int g = dataGridView1.Rows[i].Cells[0].RowIndex;
            //            dataGridView1.Rows[g].Cells[0].Value = list[i].ToString();
            //           dataGridView1.Columns[0].DefaultCellStyle.BackColor = Color.Green;
            //        }
            //        else
            //        {
            //            int g = dataGridView1.Rows[i].Cells[2].RowIndex;
            //            dataGridView1.Rows[g].Cells[2].Value = list[i];
            //            dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.Red;
            //        }
            //    }



        }










        private void Reg_TextChanged(object sender, EventArgs e)
        {
            
            if (Reg.Text.Length == 15) 
            {
                bool rez = Reg.Text.All(Char.IsDigit);
                if (rez == false)
                {
                    goto b;
                }
                else
                {

                    if (list.Contains(Reg.Text))
                    {

                        for (int i = 0; i < novo.Count; i++)
                        {
                            if (Reg.Text == novo[i])
                            {
                                goto b;
                              
                            }
                        }
                        novo.Add(Reg.Text);

                    }
                    else
                    {

                        notOnFarm.Add(Reg.Text);

                    }
                }



                b:
                Reg.Clear();
            }
            else if (Reg.Text.Length > 15) 
            {
               
                Reg.Clear();
            }
            
           



        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        }

    
    }
}

//uklonjeno ime baze podataka "" koja dode di su zvijezdice*****
/*  List<string> list = new List<string>();
  Console.WriteLine("unestie string");
  string recenica = Console.ReadLine();
  int nBroj = recenica.Length / 3;
  int x = 0;
  Console.WriteLine(recenica.Length);
  Console.ReadLine();
  string dodaj = "";
  for (int i = 0; i < recenica.Length; i++)
  {
      if (i % 3 != 0)
      {
          dodaj += recenica[i];
          Console.WriteLine(dodaj);
          Console.WriteLine("POZICIJA 1");
          Console.ReadLine();



      }
      else
      {
          dodaj += recenica[i];
          Console.WriteLine("POZICIJA 2");
          Console.WriteLine(dodaj);
          list.Add(dodaj);
          dodaj = " ";
          Console.ReadLine();
      }
  }



  KOD ĆE POSLUZITI ZA RAZVRSTAVANJE STRINGOVA U LISTU.....
VJV SVAKI 15 ELEMENT UNESNE PREKO  SKENERA
  Console.WriteLine("string dijeljeno sa 15 daje: " + x);
  if (recenica.Length % 15 == 0)
  {
      Console.WriteLine("unos je ispravan");
  }
  else
  {
      Console.WriteLine("broj nije dijeljiv sa 15");
  }
  Console.ReadLine();

  foreach (string s in list)
  {
      Console.WriteLine("dobili smo brojeve: " + s);
  }





  Console.ReadLine();
*/

/*JEDNA OD BOOLJIH OPCIJA
                 * 
                 * for (int i = 0; i < novo.Count; i++)
                 {
                     k++;
                     for (int j = 0; j < list.Count; j++) {

                         if (novo[i]==list[j])
                         {


                             dataGridView1.Rows[j].DefaultCellStyle.ForeColor = Color.Green;

                             MessageBox.Show("Broj je u listi");
                         }

                         else
                         {



                         }
                     }

                 }*/
/* int n = dataGridView1.Rows[i].Cells[2].RowIndex;
 dataGridView1.Rows[i].Cells[2].Value = novo[i].ToString();
 dataGridView1.Columns[2].DefaultCellStyle.BackColor = Color.Red;*/



// else if (Reg.Text.Length !=15) 
//  {
//    MessageBox.Show("PREMALEN IILI PREVELIK BROJ ZNAMENKI");
//Reg.Clear();
// }







/* MessageBox.Show(k.ToString());
 OPCIJA BEZ LISTE
 int j = 0;
 for (int i = 0; i < dataGridView1.Rows.Count; i++)
 { ode exception trebaa jer nakraju lovi null vrijendost pa ga izbaci
 j++;
     if (Reg.Text == dataGridView1.Rows[i].Cells[1].Value)
     {// ttrbea vidit kako obojat samo jednu celiju a ne cijeli row
         dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
         break;

     }
     else
     {

     }

 }
 //pokusaj test
 MessageBox.Show("u data gridu ima: " + j.ToString());

*/




/* for( int i = 0; i <Reg.Text.Length; i++)
        {

            if(Reg.Text[i].ToString() =="\r")
            {

                Reg.Text.Remove(Reg.Text[i]);

            }
        }*/

//OPCIJA SA LISTOM
//  if (Reg.Text.Length == 15)
//   {

//da bi aplikacija radila treba se povezati na svoju bazu podataka isto tako treba imati tbblici koja sadrzi određene stupce
//NAPOMENE BUTTON 1 NE RADI TJ JOS JE U IZRADI KOJU BI FUNKCIJU U APLIKACIJI TREBAO IMATI(OVISNO STO JE BITNO STO JOS ZELIMO DA PROGRAM RADI)
//lista list sluzi za umetanje podataka iz baze podatkaka u grid
        //
        //lista novo sluzi za unos podataka u listu preko text boxa ili mozda random broj 
        //OVA APLIKACIJA  je u izradi i   sluzit ce  ZA LOKALNU PRIMJENU ODREDENOG KORISNIKA  da  preko windows forms dobijemo podatke koje cita rfid readere
        //te ih usporeduje sa podatcima iz baze podataka

//povezivanje preko sqlclient 
