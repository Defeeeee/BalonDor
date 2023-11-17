using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace BalonDor
{
    public partial class Form2 : Form
    {
        public Dictionary<string, int> BalonDor;
        public Form2(Dictionary<string, int> BalonDor)
        {
            InitializeComponent();

            this.BalonDor = BalonDor;
            
            dataGridView1.Columns.Add("Jugador","Jugador");
            dataGridView1.Columns.Add("Balones", "Balones");
            foreach (var jugador in BalonDor)
            {
                dataGridView1.Rows.Add(jugador.Key, jugador.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BalonDor[textBox1.Text] > BalonDor[textBox2.Text])
                labelRes.Text = textBox1.Text + " tiene más balones de oro que " + textBox2.Text;
            else if (BalonDor[textBox1.Text] < BalonDor[textBox2.Text])
                labelRes.Text = textBox2.Text + " tiene más balones de oro que " + textBox1.Text;
            else
                labelRes.Text = textBox1.Text + " y " + textBox2.Text + " tienen la misma cantidad de balones de oro";
        }
    }
}