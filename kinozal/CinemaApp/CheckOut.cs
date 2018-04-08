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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
            foreach (Button item in Seats.ReservedSeats)
            {
                SelectedSeats.Text += item.Text + " ,";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = "Salam, " + NameBox.Text + " " + SurnameBox.Text + ". Siz " + SelectedSeats.Text + " yerleri reserv etmisiniz ve odeyeceyiniz mebleg " + Seats.ReservedSeats.Count * 5 + " AZN-dir.Enjoy your life (bacarirsansa)";
            netice.Text += result;
        }
    }
}
