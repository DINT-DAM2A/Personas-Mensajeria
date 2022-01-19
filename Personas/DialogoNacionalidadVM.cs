using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;

namespace Personas
{
    class DialogoNacionalidadVM : ObservableObject
    {
        public DialogoNacionalidadVM()
        {
        }

        private string newNacionalidad;
        public string NewNacionalidad
        {
            get { return newNacionalidad; }
            set { SetProperty(ref newNacionalidad, value); }
        }

        public void AddNacionalidad()
        {
            if (NewNacionalidad != "" && NewNacionalidad != null)
            {
                WeakReferenceMessenger.Default.Send(new NewNacionalidadMessage(NewNacionalidad));
            }
        }

    }

}
