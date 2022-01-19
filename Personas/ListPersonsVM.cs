using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System.Collections.ObjectModel;

namespace Personas
{
    class ListPersonsVM : ObservableObject
    {
        private readonly ServicioDatos datos = ServicioDatos.Instance();

        public ListPersonsVM()
        {
            ListaPersonas = datos.ListaPersonas;
        }

        private ObservableCollection<Persona> listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }

    }
}
