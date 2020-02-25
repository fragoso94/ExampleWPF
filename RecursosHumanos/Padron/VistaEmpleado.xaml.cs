using Microsoft.Win32;
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

namespace RecursosHumanos.Padron
{
    /// <summary>
    /// Lógica de interacción para VistaEmpleado.xaml
    /// </summary>
    public partial class VistaEmpleado : UserControl
    {
        public VistaEmpleado()
        {
            InitializeComponent();
        }

        private void agregarFoto(object sender, RoutedEventArgs e)
        {
            abrirExplorador(1);
        }
        private void agregarFirma(object sender, RoutedEventArgs e)
        {
            abrirExplorador(2);
        }

        private void abrirExplorador(int i)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                Uri fileUri = new Uri(openFileDialog.FileName);
                switch (i)
                {
                    case 1:
                        imgFoto.Source = new BitmapImage(fileUri);
                        break;
                    case 2:
                        imgFirma.Source = new BitmapImage(fileUri);
                        break;
                    default: MessageBox.Show("No existe la opción.");
                        break;
                }
                
            }
        }
    }
}
