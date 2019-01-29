using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace PictureEnlargement
{
    public partial class PrintOperations : Form
    {
        public PrintOperations()
        {
            InitializeComponent();
        }

        public PrintOperations(System.Windows.Forms.Form f)
        {
            InitializeComponent();
           form1 = f;
            MessageBox.Show(Format.Text);

        }

        private void PrintOperations_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font myfont = new Font("Arial", 30, FontStyle.Bold);
            g.DrawString("Select Picture Size", myfont, Brushes.Blue, 50, 50);

        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.ActiveForm.MainMenuStrip.Items.ToString());
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.ActiveForm.MainMenuStrip.ToString());
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.ActiveForm.MainMenuStrip.ToString());
        }
    }
}
