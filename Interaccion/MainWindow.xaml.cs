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

namespace Interaccion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); //verifica que esten iniciados los elementos del interfaz de usuario
            
            btnBoton.Click += 
                BtnBoton_Click;
        }

        private void BtnBoton_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Adios mundo!";
            lblHolaMundo.FontSize = 29;
            lblHolaMundo.Foreground = Brushes.Red;
        }

        private void BtnBotonSegundo_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Segundo boton!";
            lblHolaMundo.FontSize = 18;
            lblHolaMundo.Foreground = Brushes.Aqua;
        }

        private void BtnBotonTercero_Click(object sender, RoutedEventArgs e)
        {
            lblHolaMundo.Text = "Tercer boton!";
            lblHolaMundo.FontSize = 35;
            lblHolaMundo.Foreground = Brushes.Green;
        }
    }
}
