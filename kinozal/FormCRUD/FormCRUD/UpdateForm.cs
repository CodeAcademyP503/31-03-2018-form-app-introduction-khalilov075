using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCRUD
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
            SaveButton.Click += new EventHandler(SaveData);
            foreach (var item in User.List)
            {
                if(item.Id== WelcomeScreen.SelectedItem)
                {
                    NameBox.Text = item.Name;
                    SurnameBox.Text = item.Surname;
                    AgeBox.Text = item.Age.ToString();
                }
            }
        }

        public void SaveData(object obj, EventArgs e)
        {
            foreach (var item in User.List)
            {
                if (item.Id == WelcomeScreen.SelectedItem)
                {
                    item.Name = NameBox.Text;
                    item.Surname = SurnameBox.Text;
                    item.Age = Convert.ToInt32(AgeBox.Text);
                    this.Hide();

                }
            }

        }
    }
}
