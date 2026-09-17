using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    internal partial class CreateLabel
    {
        private static Label label;
        public static Label Form1_CreateLabel()
        {
            label = new Label
            {
                Dock = DockStyle.Fill,
                BackColor = Color.AliceBlue
            };

            return label;
        }
    }
}
