using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Message;
using System.Collections.ObjectModel;

namespace Personas
{
    class ListPersonsVM : ObservableRecipient
    {
        private readonly ServicioDatos datos = ServicioDatos.Instance();

        public ListPersonsVM()
        {
            ListaPersonas = datos.ListaPersonas;

            WeakReferenceMessenger.Default.Register<ListPersonsVM, SelectedPersonMessage>(this, (r, m) =>
            {
                m.Reply(r.PersonaSeleccionada);
            });
        }

        private ObservableCollection<Persona> listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }

        private Persona personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

    }
}
