using System;
using System.Windows.Forms;

namespace point_of_sale_mgs
{
    public partial class splash : Form
    {
        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value += 1;
            if (progressBar1.Value == 100)
            {
                Form1 ds = new Form1();
                ds.Show();
                this.Hide();
                timer1.Enabled = false;

            }
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString();
            label3.Text = DateTime.Now.ToLongDateString();
        }
    }
}