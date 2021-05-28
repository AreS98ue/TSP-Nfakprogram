using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DronV1
{
    public partial class Form1 : Form
    {
        public double[,] klijentisakordinatama;
        Random Nasumican = new Random();
        public const int BrKlijentaXiYkordinate = 3;
        public int duzinakolone;
        public int [] kordinatefin;
        public double duzina = 0;
        List<double> xVrednosti = new List<double>();
        List<double> yVrednosti = new List<double>();

        public Form1()
        {
            InitializeComponent();
            chart1.Hide();
        }
        public void PunjenjeNasumicnihKordinatada()
        {
           
            duzinakolone = 1 + Convert.ToInt32(txtboxBrojKlijenata.Text);
            klijentisakordinatama = new double[BrKlijentaXiYkordinate, duzinakolone];
            if (txtboxXza1.Text.Length == 0 && txtboxYza1.Text.Length == 0)
            {
                klijentisakordinatama[0, 0] = 0;
                klijentisakordinatama[1, 0] = 0;
                klijentisakordinatama[2, 0] = 0;

            }
            else
            {
                klijentisakordinatama[0, 0] = 0;
                if (txtboxXza1.Text.Length == 0)
                {
                    klijentisakordinatama[1, 0] = 0;

                }
                else
                {
                    klijentisakordinatama[1, 0] = Math.Round(Convert.ToDouble(txtboxXza1.Text), 2);
                }
                if (txtboxYza1.Text.Length == 0)
                {
                    klijentisakordinatama[2, 0] = 0;

                }
                else
                {
                    klijentisakordinatama[2, 0] = Math.Round(Convert.ToDouble(txtboxYza1.Text), 2);
                }


            }
            for (int i = 1; i < duzinakolone; i++)
            {
                klijentisakordinatama[0, i] = i;
                klijentisakordinatama[1, i] = Math.Round(Nasumican.Next(-50, 51) + Nasumican.NextDouble(), 2);
                klijentisakordinatama[2, i] = Math.Round(Nasumican.Next(-50, 51) + Nasumican.NextDouble(), 2);

            }
            //klijentisakordinatama[0, 1] = 1;
            //klijentisakordinatama[1, 1] = 10.79;
            //klijentisakordinatama[2, 1] = 8.41;

            //klijentisakordinatama[0, 2] = 2;
            //klijentisakordinatama[1, 2] = -18.59;
            //klijentisakordinatama[2, 2] = -22.41;

            //klijentisakordinatama[0, 3] = 3;
            //klijentisakordinatama[1, 3] = -3.02;
            //klijentisakordinatama[2, 3] = 48.04;

        }



        public double UkupanPredjenPut (double [,] klijentisakordinatama, int [] privremeni)
        {
            double ukupnaduzina = 0;
            for (int i = 0; i < privremeni.Length-1; i++)
            {
                
                int pozicija1 = privremeni[i];
                int pozicija2 = privremeni[i+1];

                double vredX1 = klijentisakordinatama[1, pozicija1];
                double vredY1 = klijentisakordinatama[2, pozicija1];

                double vredX2 = klijentisakordinatama[1, pozicija2];
                double vredY2 = klijentisakordinatama[2, pozicija2];
                ukupnaduzina += DistancaIzmedjuDveTacke(vredX1, vredX2, vredY1, vredY2);



            }
            
            return ukupnaduzina;
        }
        public double DistancaIzmedjuDveTacke(double x1,double x2, double y1, double y2)
        {

            double distanca = 0;

   

            if (x1 == x2)
            {
                
                distanca = Math.Abs(y1 - y2);
                return distanca;
            }
            else if (y1 == y2)
            {
                
                distanca = Math.Abs(x1 - x2);

                return distanca;
            }
            double Xrez = Math.Pow(x1 - x2, 2);
            double Yrez = Math.Pow(y1 - y2, 2);
            distanca = Math.Sqrt(Xrez + Yrez);
            distanca = Math.Round(distanca, 2);

            return distanca;
            





        }


        public void printArr(int[] a, int n)
        {
            int[] priv = new int[a.Length + 2];
            priv[0] = 0;
            priv[priv.Length - 1] = 0;
            Array.Copy(a, 0, priv, 1, a.Length);
            if (duzinakolone-1 <= 5)
            {
                foreach (var item in priv)
                {
                    txtBoxDuzinaSvakePutanje.Text += " " + item + " ";
                }
                txtBoxDuzinaSvakePutanje.Text += " duzina " + UkupanPredjenPut(klijentisakordinatama, priv).ToString() + " km " + "\r\n";
            }
            if (UkupanPredjenPut(klijentisakordinatama, priv)<duzina || duzina == 0)
            {
                duzina = UkupanPredjenPut(klijentisakordinatama, priv);
                Array.Copy(priv, kordinatefin, priv.Length);
            }

           
        }

        //Permutacije Heap Algoritmom
        public void heapPermutation(int[] a, int size, int n)
        {
            // Ako je velicina 1 stampaj datu permutaciju 
            if (size == 1)
                printArr(a, n);

            for (int i = 0; i < size; i++)
            {
                heapPermutation(a, size - 1, n);

                // ako je velicina neparna zameni prvi i poslednji element 

                if (size % 2 == 1)
                {
                    int temp = a[0];
                    a[0] = a[size - 1];
                    a[size - 1] = temp;
                }

                // Ako je velicina parna zameni inti  zadnji element
                else
                {
                    int temp = a[i];
                    a[i] = a[size - 1];
                    a[size - 1] = temp;
                }
            }
        }





        private void btnBrojKlijenata_Click(object sender, EventArgs e)
        {
          
            PunjenjeNasumicnihKordinatada();

            int[] a = new int[duzinakolone - 1];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (int)klijentisakordinatama[0, i + 1];
            }
            kordinatefin = new int[duzinakolone + 1];
            heapPermutation(a, a.Length, a.Length);
            // punjenje textboxa
            foreach (var item in kordinatefin)
            {
                txtBoxPutanja.Text += item.ToString() + " ";
            }
            for (int i = 0; i < duzinakolone; i++)
            {
                txtBoxKordinate.Text += " Pozicija: " + klijentisakordinatama[0, i].ToString() + " X: " + klijentisakordinatama[1, i].ToString() +  " Y: "
                    + klijentisakordinatama[2, i].ToString()  + "\r\n";
            }
            txtBoxDistanca.Text = duzina.ToString() + " km ";
            for (int i = kordinatefin.Length-1; i >=0; i--)
            {
                txtBoxPutanja2.Text += kordinatefin[i].ToString() + " ";
            }
            
            
            // grafik
            for (int i = 0; i < kordinatefin.Length; i++)
            {
                xVrednosti.Add(klijentisakordinatama[1, kordinatefin[i]]);
                yVrednosti.Add(klijentisakordinatama[2, kordinatefin[i]]); 

            }
            chart1.Series["Putanja"].Points.DataBindXY(xVrednosti, yVrednosti);
            
            chart1.Show();
            btnBrojKlijenata.Enabled = false;
        }
        public void Obrisi()
        {
            duzina = 0;
            txtboxBrojKlijenata.Clear();
            txtboxXza1.Clear();
            txtboxYza1.Clear();
            txtBoxDistanca.Clear();
            txtBoxDuzinaSvakePutanje.Clear();
            txtBoxKordinate.Clear();
            txtBoxPutanja.Clear();
            txtBoxPutanja2.Clear();
            xVrednosti.Clear();
            yVrednosti.Clear();
            chart1.Hide();
            btnBrojKlijenata.Enabled = true;
            txtboxBrojKlijenata.Focus();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Obrisi();


        }
    }
}
