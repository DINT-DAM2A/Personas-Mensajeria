using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Personas
{
    class ListPersonsVM : ObservableObject
    {
        public ListPersonsVM()
        {
            ListaPersonas = Persona.GetSamples();
        }

        private ObservableCollection<Persona> listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }
    }

}
