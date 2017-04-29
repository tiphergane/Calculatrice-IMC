using System;
using System.Windows;

namespace TutoVideo
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
        /// Code to close the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDC_Quitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();            
        }

        /// <summary>
        /// Code to show the About box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IDC_About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ceci est le tuto #KittensCanCode session 1\r\nCoded by: tiphergane\r\nCoded in:\tC#\r\n", "About meoow");
        }

        private void IDC_Calculer_Click(object sender, RoutedEventArgs e)
        {
            float taille = float.Parse(IDC_Taille_saisie.Text);
            float poids = float.Parse(IDC_poids_saisie.Text);
            CalcImc(taille, poids);
            
        }


        /// <summary>
        /// IMC calcul subroutine
        /// </summary>
        /// <param name="taille"></param>
        /// <param name="poids"></param>
        private void CalcImc(float taille, float poids)
        {
            float resultat = poids / ((float)Math.Pow(taille, 2) / 10000);
            IDC_resultat_calcul.Text = resultat.ToString();
        }
    }
}
