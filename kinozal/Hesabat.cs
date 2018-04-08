using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaApp
{
    public partial class Hesabat : Form
    {
        public Hesabat()
        {
            InitializeComponent();
            foreach (Button item in Seats.ReservedSeats)
            {
                yerler.Text += item.Text + " | ";
                yerler.Enabled = false;
            }
            azn.Text += Seats.ReservedSeats.Count*5;
            azn.Enabled = false;
            seans.Text = Seats.seans_check;
            seans.Enabled = false;
            
        }


        

      

       
      

        private void NameBox_TextChanged(object sender, EventArgs e)
        {  
          
        }

        private void Hesabat_Load(object sender, EventArgs e)
        {

        }

       
    }
}
    
