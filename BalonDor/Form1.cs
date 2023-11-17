using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalonDor
{
    public partial class Form1 : Form
    {
        public Dictionary<string, int> BalonDor = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && int.TryParse(textBox2.Text, out _))
            {
                BalonDor.Add(textBox1.Text, Convert.ToInt32(textBox2.Text));
            }
            else
            {
                MessageBox.Show("Añade un jugador y la cantidad de balones de oro que tiene", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox2.Text = "Ingrese la cantidad de balones";
            textBox1.Text = "Ingrese el jugador";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2(BalonDor);
            form2.ShowDialog();
        }
    }
}