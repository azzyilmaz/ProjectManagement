using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management.Helpers
{
    public static class Tools
    {
        public static void Clean(Control.ControlCollection collection)
        {
            foreach (Control item in collection)
            {
                if (item is TextBox)
                    (item as TextBox).Clear();
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = -1;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
                else if (item is PictureBox)
                {
                    PictureBox pcb = item as PictureBox;
                    pcb.Image = null;
                    pcb.Tag = null;
                }
                else if (item is GroupBox)
                    Clean((item as GroupBox).Controls);

            }
        }
    }
}
