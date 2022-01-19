using System.Windows;
using System.Windows.Controls;

namespace Personas
{
    class ServicioNavegacion
    {
        private static readonly UserControl listPersons = new ListPersons();

        public ServicioNavegacion()
        {
        }

        internal UserControl AbrirNewPerson()
        {
            return new NewPerson();
        }

        internal UserControl AbrirListPersons()
        {
            return listPersons;
        }

        public bool? AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad ventana = new DialogoNacionalidad();
            ventana.Owner = Application.Current.MainWindow;

            return ventana.ShowDialog();
        }

    }
}
