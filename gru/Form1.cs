using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gru
{
    public partial class Form1 : Form
    {
        private Gru gru;

        public Form1()
        {
            InitializeComponent();
            gru = new Gru("Gru1", "Produttore1", 2000);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAlza_Click(object sender, EventArgs e)
        {
            double increment = Convert.ToDouble(numericUpDown1.Value);
            gru.AlzaGru(increment);
            textBoxAltezza.Text = gru.ConosciAltezza().ToString();
        }

        private void buttonAbbassa_Click(object sender, EventArgs e)
        {
            double decrement = Convert.ToDouble(numericUpDown1.Value);
            gru.AbbassaGru(decrement);
            textBoxAltezza.Text = gru.ConosciAltezza().ToString();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            gru.PosizioneSicurezza();
            textBoxAltezza.Text = gru.ConosciAltezza().ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
