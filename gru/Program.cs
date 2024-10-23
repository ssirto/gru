using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gru
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Gru gru1 = new Gru("Gru1", "Produttore1", 2000);
            Gru gru2 = new Gru("Gru2", "Produttore2", 2500);

            gru1.AlzaGru(15);
            gru1.AbbassaGru(3.5);
            Console.WriteLine($"Altezza attuale della gru 1: {gru1.ConosciAltezza()} metri.");

            gru1.AlzaGru(20);
            gru2.AlzaGru(100);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
