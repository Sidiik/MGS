using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_of_sale_mgs
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = button1.Text.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = button2.Text.ToString();
            pnlshow.Controls.Clear();
            Sales employee = new Sales();
            pnlshow.Controls.Add(employee);
            employee.BorderStyle = BorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = button3.Text.ToString();
            label2.Text = button2.Text.ToString();
            pnlshow.Controls.Clear();
            Sales employee = new Sales();
            pnlshow.Controls.Add(employee);
            employee.BorderStyle = BorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = button4.Text.ToString();
            pnlshow.Controls.Clear();
            reciept employee = new reciept();
            pnlshow.Controls.Add(employee);
            employee.BorderStyle = BorderStyle.None;
            employee.Dock = DockStyle.Fill;
            employee.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = button4.Text.ToString();
        }
    }
}
