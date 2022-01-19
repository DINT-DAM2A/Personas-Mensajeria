using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.Message;

namespace Personas
{
    class ConsultaPersonaVM : ObservableObject
    {
        public ConsultaPersonaVM()
        {
            PersonaLista = WeakReferenceMessenger.Default.Send<SelectedPersonMessage>();
        }

        private Persona personaLista;
        public Persona PersonaLista
        {
            get { return personaLista; }
            set { SetProperty(ref personaLista, value); }
        }

    }
}
