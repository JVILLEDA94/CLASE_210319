using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, R;
            String D;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);

            R = A + B;

            D = "RESULTADO: " + R.ToString();
            label3.Text = D;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int A, B, R;
            String D;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);

            R = A - B;

            D = "RESULTADO: " + R.ToString();
            label3.Text = D;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int A, B, R;
            String D;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);

            R = A * B;

            D = "RESULTADO: " + R.ToString();
            label3.Text = D;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int A, B, R;
            String D;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);

            if (B == 0)
            {
                 MessageBox.Show("No puedes dividir entre 0");
                    
            }
            else
            {
                R = A / B;
                D = "RESULTADO: " + R.ToString();
                label3.Text = D;
            }
            
            
        }
    }
}
