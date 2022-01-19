using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Windows.Controls;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        public RelayCommand NewPersonCommand { get; }
        public RelayCommand ListPersonsCommand { get; }
        public RelayCommand ConsultaPersonaCommand { get; }

        private readonly ServicioNavegacion servicio;

        public MainWindowVM()
        {
            servicio = new ServicioNavegacion();
            NewPersonCommand = new RelayCommand(AbrirNewPerson);
            ListPersonsCommand = new RelayCommand(AbrirListPersons);
            ConsultaPersonaCommand = new RelayCommand(AbrirConsultaPersona);
        }

        private UserControl ventanaVisible;
        public UserControl VentanaVisible
        {
            get { return ventanaVisible; }
            set { SetProperty(ref ventanaVisible, value); }
        }

        private void AbrirNewPerson()
        {
            VentanaVisible = servicio.AbrirNewPerson();
        }

        private void AbrirListPersons()
        {
            VentanaVisible = servicio.AbrirListPersons();
        }

        private void AbrirConsultaPersona()
        {
            VentanaVisible = servicio.AbrirConsultaPersona();
        }
    }
}
