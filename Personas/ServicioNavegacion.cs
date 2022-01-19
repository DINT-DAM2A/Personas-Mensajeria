using System.Windows;
using System.Windows.Controls;

namespace Personas
{
    class ServicioNavegacion
    {
        private UserControl ListPersons;

        public ServicioNavegacion()
        {
        }

        internal UserControl AbrirNewPerson()
        {
            return new NewPerson();
        }

        internal UserControl AbrirListPersons()
        {
            if (ListPersons == null)
            {
                ListPersons = new ListPersons();
            }

            return ListPersons;
        }

        public bool? AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad ventana = new DialogoNacionalidad();
            ventana.Owner = Application.Current.MainWindow;

            return ventana.ShowDialog();
        }

    }
}
