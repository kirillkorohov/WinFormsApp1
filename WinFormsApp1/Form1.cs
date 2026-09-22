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
        private RichTextBox editor;
        private Panel sidebarHost;

        public Form1()
        {
            InitializeComponent();
            Size = new Size(700, 700);

            label = CreateLabel.Form1_CreateLabel();

            menu = CreateMenu.Form1_CreateMenu();

            editor = CreateEditor.Form1_CreateEditor();
            CreateMenu.AttachDocument(editor);

            sidebarHost = new Panel
            {
                Name = "sidebarHost",
                Dock = DockStyle.Left,
                Width = 250,
                BackColor = Color.Gainsboro
            };

            this.MainMenuStrip = menu;
            this.Controls.Add(editor);
            this.Controls.Add(sidebarHost);
            this.Controls.Add(menu);
        }

    }
}
