using Microsoft.Toolkit.Mvvm.Input;
using System.Windows;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para DialogoNacionalidad.xaml
    /// </summary>
    public partial class DialogoNacionalidad : Window
    {

        public DialogoNacionalidad()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
