using System;
using System.Windows;

namespace IMC
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Calcul du résultat de l'IMC et l'affiche à la place du label "résultat"
        /// </summary>
        /// <param name="taille"></param>
        /// <param name="poids"></param>

        private void CalcImc(float taille, float poids)
        {
           float resultat = poids / ((float)Math.Pow(taille, 2) / 10000);
           IDC_resultat.Text = resultat.ToString();
            IDB_ProgressBar.Value = resultat;
        }

        /// <summary>
        /// Calcul du poids idéal selon votre taille
        /// </summary>
        /// <param name="taille"></param>
        /// <param name="poids"></param>
        /// 
        private void CalcImcIdeal(float taille)
        {
            float resultat_low = (((float)Math.Pow(taille, 2) / 10000) * 19);
            float resultat_high = (((float)Math.Pow(taille, 2) / 10000) * 25);
            IDC_Ideal_resultat.Text = String.Format("{0} et {1} Kg", resultat_low, resultat_high);
        }

        /// <summary>
        /// Entry point du programme, plus récupération des info de taille et de poids.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float taille = float.Parse(IDC_textbox2.Text);
            float poids = float.Parse(IDC_textbox1.Text);
            CalcImc(taille, poids);
            CalcImcIdeal(taille);
        }

        private void IDC_button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("IMC Calculator\r\nCoded by:\t tiphergane\r\nCoded in:\tC#\r\nGreetz to Fabrice \"pook\" Lamant for the WPF challenge\r\n","About meoow");
        }

        private void IDC_Quit_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            IMC.Close();
        }

    }
}
