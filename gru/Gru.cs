using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gru
{
    public class Gru
    {
        private string numeroSeriale;
        private string produttore;
        private double pesoMassimoNominale;
        private double altezzaMinimaNominale;
        private double altezzaMassimaNominale;
        private double altezzaBraccio;

    //  Proprietà della gru
        public string NumeroSeriale
        {
            get { return numeroSeriale; }
        }
        public string Produttore
        {
            get { return produttore; }
        }
        public double PesoMassimoNominale
        {
            get { return pesoMassimoNominale; }
        }

    //  Altezza minima braccio
        public double AltezzaMinimaNominale
        {
            get { return altezzaMinimaNominale = 10; }
        }

    //  Altezza massima braccio
        public double AltezzaMassimaNominale
        {
            get { return altezzaMassimaNominale = 80; }
        }

    //  Altezza attuale braccio
        public double AltezzaBraccio
        {
            get { return altezzaBraccio; }
            set { altezzaBraccio  = value; }
        }

    //  Costruttore
        public Gru(string numeroseriale, string produttore, double pesoMassimoNominale)
        {
            numeroSeriale = numeroseriale;
            this.produttore = produttore;
            this.pesoMassimoNominale = pesoMassimoNominale;

        //  Impostato inizialmente all'altezza minima
            AltezzaBraccio = AltezzaMinimaNominale;
        }

    //  Alza gru
        public void AlzaGru(double altezza)
        {
            if (AltezzaBraccio + altezza > AltezzaMassimaNominale)
            {
                Console.WriteLine("ERRORE! ALTEZZA MASSIMA RAGGIUNTA!");
            }
            else
            {
                AltezzaBraccio += altezza;
                Console.WriteLine($"Gru alzata di {altezza} metri." +
                                  $"Altezza attuale: {AltezzaBraccio} metri.");
            }
        }

    //  Abbassa gru
        public void AbbassaGru(double altezza)
        {
            if (AltezzaBraccio - altezza < AltezzaMinimaNominale)
            {
                Console.WriteLine("ERRORE! ALTEZZA MINIMA RAGGIUNTA!");
            }
            else
            {
                AltezzaBraccio -= altezza;
                Console.WriteLine($"Gru abbassata di {altezza} metri." +
                                  $"Altezza attuale: {AltezzaBraccio} metri.");
            }
        }

    //  Posizione di sicurezza
        public void PosizioneSicurezza()
        {
            AltezzaBraccio = AltezzaMinimaNominale;
            Console.WriteLine($"Gru riportata in posizione di sicurezza. " +
                              $"Altezza attuale: {AltezzaBraccio} metri.");
        }

    //  Altezza attuale gru
        public double ConosciAltezza()
        {
            return AltezzaBraccio;
        }
    }
}
