using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading; 

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        private MenuStrip menu;
        private Label label;

        public Form1()
        {
            InitializeComponent();
            Size = new Size(700, 700);

            label = CreateLabel.Form1_CreateLabel();

            menu = CreateMenu.Form1_CreateMenu();

            this.MainMenuStrip = menu;
            this.Controls.AddRange(new Control[] { menu, label});
        }

    }
}
