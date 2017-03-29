using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Tworzymy nowy obiekt sumator
        Sumator sumator1 = new Sumator();
        Sumator sumator2 = new Sumator();
        Sumator sumator3 = new Sumator();
        Sumator sumator4 = new Sumator();
        public MainWindow()
        {
            InitializeComponent();
            Wynik();
            WylaczenieJedynek();
        }

        //------------------------------------------------------
        // Przyciski
        //------------------------------------------------------
        private void A1_Click(object sender, RoutedEventArgs e)
        {
            if (A1.Content.ToString() == "1")
            {
                A1.Content = "0";
                sumator1.A1naFalsz();
                A1_j.Visibility = Visibility.Hidden;
            }
            else
            {
                A1.Content = "1";
                sumator1.A1naPrawda();
                A1_j.Visibility = Visibility.Visible;
            }
            Wynik();
        }
        private void B1_Click(object sender, RoutedEventArgs e)
        {
            if (B1.Content.ToString() == "1")
            {
                B1.Content = "0";
                sumator1.A2naFalsz();
                B1_j.Visibility = Visibility.Hidden;
            }
            else
            {
                B1.Content = "1";
                sumator1.A2naPrawda();
                B1_j.Visibility = Visibility.Visible;
            }
            Wynik();
        }
        private void A2_Click(object sender, RoutedEventArgs e)
        {
            if (A2.Content.ToString() == "1")
            {
                A2.Content = "0";
                sumator2.A1naFalsz();
                A2_j.Visibility = Visibility.Hidden;
            }
            else
            {
                A2.Content = "1";
                sumator2.A1naPrawda();
                A2_j.Visibility = Visibility.Visible;
            }
            Wynik();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            if (B2.Content.ToString() == "1")
            {
                B2.Content = "0";
                sumator2.A2naFalsz();
                B2_j.Visibility = Visibility.Hidden;
            }
            else
            {
                B2.Content = "1";
                sumator2.A2naPrawda();
                B2_j.Visibility = Visibility.Visible;
            }
            Wynik();
        }

        private void A3_Click(object sender, RoutedEventArgs e)
        {
            if (A3.Content.ToString() == "1")
            {
                A3.Content = "0";
                sumator3.A1naFalsz();
                A3_j.Visibility = Visibility.Hidden;
            }
            else
            {
                A3.Content = "1";
                sumator3.A1naPrawda();
                A3_j.Visibility = Visibility.Visible;
            }
            Wynik();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            if (B3.Content.ToString() == "1")
            {
                B3.Content = "0";
                sumator3.A2naFalsz();
                B3_j.Visibility = Visibility.Hidden;
            }
            else
            {
                B3.Content = "1";
                sumator3.A2naPrawda();
                B3_j.Visibility = Visibility.Visible;
            }
            Wynik();
        }

        private void A4_Click(object sender, RoutedEventArgs e)
        {
            if (A4.Content.ToString() == "1")
            {
                A4.Content = "0";
                sumator4.A1naFalsz();
                A4_j.Visibility = Visibility.Hidden;
            }
            else
            {
                A4.Content = "1";
                sumator4.A1naPrawda();
                A4_j.Visibility = Visibility.Visible;
            }
            Wynik();
        }

        private void B4_Click(object sender, RoutedEventArgs e)
        {
            if (B4.Content.ToString() == "1")
            {
                B4.Content = "0";
                sumator4.A2naFalsz();
                B4_j.Visibility = Visibility.Hidden;
            }
            else
            {
                B4.Content = "1";
                sumator4.A2naPrawda();
                B4_j.Visibility = Visibility.Visible;
            }
            Wynik();
        }
        private void Wynik()
        {
            sumator1.Sprawdz();
            if (sumator1.C_Wartosc())
                C1_j.Visibility = Visibility.Visible;
            else
                C1_j.Visibility = Visibility.Hidden;
            sumator2.BitKontrolny(sumator1);
            sumator2.Sprawdz();
            if (sumator2.C_Wartosc())
                C2_j.Visibility = Visibility.Visible;
            else
                C2_j.Visibility = Visibility.Hidden;
            sumator3.BitKontrolny(sumator2);
            sumator3.Sprawdz();
            if (sumator3.C_Wartosc())
                C3_j.Visibility = Visibility.Visible;
            else
                C3_j.Visibility = Visibility.Hidden;
            sumator4.BitKontrolny(sumator3);
            sumator4.Sprawdz();
            if (sumator1.S_Wartosc())
                S1_j.Visibility = Visibility.Visible;
            else
                S1_j.Visibility = Visibility.Hidden;
            if (sumator2.S_Wartosc())
                S2_j.Visibility = Visibility.Visible;
            else
                S2_j.Visibility = Visibility.Hidden;
            if (sumator3.S_Wartosc())
                S3_j.Visibility = Visibility.Visible;
            else
                S3_j.Visibility = Visibility.Hidden;
            if (sumator4.S_Wartosc())
                S4_j.Visibility = Visibility.Visible;
            else
                S4_j.Visibility = Visibility.Hidden;
            if (sumator4.C_Wartosc() == true)
            {
                wynik.Content = (Convert.ToInt32(sumator4.C_Wartosc())).ToString() + (Convert.ToInt32(sumator4.S_Wartosc())).ToString() + (Convert.ToInt32(sumator3.S_Wartosc())).ToString() + (Convert.ToInt32(sumator2.S_Wartosc())).ToString() + (Convert.ToInt32(sumator1.S_Wartosc())).ToString();
                C4_j.Visibility = Visibility.Visible;
            }
            else
            {
                wynik.Content = (Convert.ToInt32(sumator4.S_Wartosc())).ToString() + (Convert.ToInt32(sumator3.S_Wartosc())).ToString() + (Convert.ToInt32(sumator2.S_Wartosc())).ToString() + (Convert.ToInt32(sumator1.S_Wartosc())).ToString();
                C4_j.Visibility = Visibility.Hidden;
            }
        }
        private void WylaczenieJedynek()
        {
            B1_j.Visibility = Visibility.Hidden;
            A1_j.Visibility = Visibility.Hidden;
            B2_j.Visibility = Visibility.Hidden;
            A2_j.Visibility = Visibility.Hidden;
            B3_j.Visibility = Visibility.Hidden;
            A3_j.Visibility = Visibility.Hidden;
            B4_j.Visibility = Visibility.Hidden;
            A4_j.Visibility = Visibility.Hidden;
            S1_j.Visibility = Visibility.Hidden;
            S2_j.Visibility = Visibility.Hidden;
            S3_j.Visibility = Visibility.Hidden;
            S4_j.Visibility = Visibility.Hidden;
            C1_j.Visibility = Visibility.Hidden;
            C2_j.Visibility = Visibility.Hidden;
            C3_j.Visibility = Visibility.Hidden;
            C4_j.Visibility = Visibility.Hidden;
        }

    }


}