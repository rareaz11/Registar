using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registar
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dodavanje dodavanje = new Dodavanje();
          
            dodavanje.Show();
             
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            DodavanjeNovihZivotinja d=new DodavanjeNovihZivotinja();    
            d.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Brisanje b= new Brisanje(); 
            b.Show();
        }
    }
}
