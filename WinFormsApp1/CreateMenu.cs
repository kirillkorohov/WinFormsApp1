using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace WinFormsApp1
{
    internal partial class CreateMenu
    {
        private static MenuStrip menu;

        private static ToolStripMenuItem file;
        private static ToolStripMenuItem newF;
        private static ToolStripMenuItem openF;

        private static ToolStripMenuItem edit;
        private static ToolStripMenuItem cut;
        private static ToolStripMenuItem copy;
        private static ToolStripMenuItem paste;

        private static ToolStripMenuItem run;
        private static ToolStripMenuItem startDebugging;
        private static ToolStripMenuItem runWithoutDebugging;

        private static ToolStripMenuItem help;
        private static ToolStripMenuItem welcome;

        public static MenuStrip Form1_CreateMenu()
        {
            newF = new ToolStripMenuItem("New File");
            newF.ShortcutKeys = Keys.Control | Keys.N;
            newF.ShowShortcutKeys = true;

            openF = new ToolStripMenuItem("Open File");
            openF.ShortcutKeys = Keys.Control | Keys.O;
            openF.ShowShortcutKeys = true;
            openF.Click += OpenFile_Click;

            cut = new ToolStripMenuItem("Cut");
            cut.ShortcutKeys = Keys.Control | Keys.X;
            cut.ShowShortcutKeys = true;

            copy = new ToolStripMenuItem("Copy");
            copy.ShortcutKeys = Keys.Control | Keys.C;
            copy.ShowShortcutKeys = true;

            paste = new ToolStripMenuItem("Paste");
            paste.ShortcutKeys = Keys.Control | Keys.V;
            paste.ShowShortcutKeys = true;

            startDebugging = new ToolStripMenuItem("Start debugging");
            startDebugging.ShortcutKeys = Keys.F5;
            startDebugging.ShowShortcutKeys = true;

            runWithoutDebugging = new ToolStripMenuItem("Run without debugging");

            welcome = new ToolStripMenuItem("Welcome");

            edit = new ToolStripMenuItem("Edit");
            edit.DropDownItems.AddRange(new ToolStripMenuItem[] { cut, copy, paste });

            file = new ToolStripMenuItem("File");
            file.DropDownItems.AddRange(new ToolStripMenuItem[] { newF, openF });

            run = new ToolStripMenuItem("Run");
            run.DropDownItems.AddRange(new ToolStripMenuItem[] { startDebugging, runWithoutDebugging });

            help = new ToolStripMenuItem("Help");
            help.DropDownItems.AddRange(new ToolStripMenuItem[] { welcome });

            menu = new MenuStrip();
            menu.Items.AddRange(new ToolStripItem[] { file, edit, run, help });

            return menu;
        }

        static void OpenFile_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;

            Label label = clickedItem.Tag as Label;

            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if (label == null)
                {
                    MessageBox.Show("Null");
                    return;
                }
                try
                {
                    string fileText = File.ReadAllText(ofd.FileName);
                    label.Text = fileText;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
