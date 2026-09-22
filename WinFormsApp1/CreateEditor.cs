using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal partial class CreateEditor
    {
        private static RichTextBox editor;

        public static RichTextBox Form1_CreateEditor()
        {
            editor = new RichTextBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Consolas", 12f),
                AcceptsTab = true,
                WordWrap = false,
                ScrollBars = RichTextBoxScrollBars.Both,
                HideSelection = false,
                BorderStyle = BorderStyle.None,
                DetectUrls = false,
                BackColor = Color.AliceBlue
            };

            return editor;
        }
    }
}
