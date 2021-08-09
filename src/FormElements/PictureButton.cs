using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sozluk.FormElements
{
    public partial class PictureButton : UserControl
    {
        public new event EventHandler OnMouseClick;

        public PictureButton()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void OnMouseEnter(object sender, EventArgs e)
        {

        }

        private void OnMouseLeave(object sender, EventArgs e)
        {

        }
    }
}
