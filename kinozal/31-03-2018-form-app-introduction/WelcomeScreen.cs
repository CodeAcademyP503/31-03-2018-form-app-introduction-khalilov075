using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31_03_2018_form_app_introduction
{
    public partial class WelcomeScreen : Form
    {
        public int LeftPos = 0;
        public int TopPos = 0;
        public int BtnNumber = 1;
        public int BtnCount = 10;
        
        public List<string> btnName = new List<string>() { "First", "Second", "Third", "Fourth", "Fifth" };
        public WelcomeScreen()
        {
            InitializeComponent();
            for (int setir = 0; setir < BtnCount; setir++)
            {
                for (int sutun = 0; sutun < BtnCount; sutun++)
                {
                    var btn = new Button();
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Text = BtnNumber.ToString();
                    btn.Left = LeftPos;
                    btn.Top = TopPos;
                    LeftPos += 50;
                    BtnNumber++;
                    Controls.Add(btn);
                }
                LeftPos = 0;
                TopPos += 50;

            }

            
            

        }
    }
}
