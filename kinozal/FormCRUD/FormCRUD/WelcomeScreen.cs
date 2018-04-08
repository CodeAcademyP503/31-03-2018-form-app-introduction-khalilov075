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
    public partial class WelcomeScreen : Form
    {
        public int Count = 1;
        public static int SelectedItem;
        public WelcomeScreen()
        {
            InitializeComponent();
            SaveButton.Click += new EventHandler(SaveData);
            ReadButton.Click += new EventHandler(ReadData);
            DeleteButton.Click += new EventHandler(DeleteData);
            UpdateButton.Click += new EventHandler(UpdateData);

        }

        public void SaveData(object obj,EventArgs e)
        {
            var btn = obj as Button; 
            var name = NameBox.Text;
            var surname = SurnameBox.Text;
            var age = Convert.ToInt32(AgeBox.Text);
            
            var newUser=new User(name, surname, age);
            newUser.Id = Count;
            NameBox.Text = "";
            SurnameBox.Text = "";
            AgeBox.Text = "";
            Count++;
            SelectForDelete.Items.Add(newUser.Id);
            SelectForUpdate.Items.Add(newUser.Id);

        }
        public void ReadData(object obj, EventArgs e)
        {
            ResultBox.Text = "";
            
            foreach (var item in User.List)
            {
                ResultBox.Text += item.Id + "." + item.Name + " - " + item.Surname + " - " + item.Age + "\r\n";
            }
        }

        public void DeleteData(object obj, EventArgs e)
        {
            var selectedId = Convert.ToInt32(SelectForDelete.SelectedItem);

            foreach (var item in User.List)
            {
                if (selectedId == item.Id)
                {
                    User.List.Remove(item);
                    break;
                }
            }
            SelectForDelete.Items.Clear();
            foreach (var item in User.List)
            {
                SelectForDelete.Items.Add(item.Id);
            }
        }

        public void UpdateData(object obj, EventArgs e)
        {
            SelectedItem=Convert.ToInt32(SelectForUpdate.SelectedItem);
            var updateForm = new UpdateForm();
            updateForm.Show();
        }




    }
}
