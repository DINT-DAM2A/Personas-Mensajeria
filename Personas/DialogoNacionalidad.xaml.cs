using Microsoft.Toolkit.Mvvm.Input;
using System.Windows;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para DialogoNacionalidad.xaml
    /// </summary>
    public partial class DialogoNacionalidad : Window
    {
        DialogoNacionalidadVM vm;

        public DialogoNacionalidad()
        {
            InitializeComponent();
            vm = new DialogoNacionalidadVM();
            this.DataContext = vm;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.AddNacionalidad();
            DialogResult = true;
        }
    }
}
