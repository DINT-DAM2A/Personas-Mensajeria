using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Personas
{
    class NewPersonVM : ObservableObject
    {
        public RelayCommand AbrirDialogo { get; }
        public RelayCommand AddPersona { get; }

        private readonly ServicioNavegacion servicio;
        private readonly ServicioDatos datos = ServicioDatos.Instance();

        public NewPersonVM()
        {
            servicio = new ServicioNavegacion();
            AbrirDialogo = new RelayCommand(AbrirDialogoNacionalidad);
            AddPersona = new RelayCommand(AnyadirPersona);
            PersonaFormulario = new Persona();

            ListaNacionalidades = datos.ListaNacionalidades;
        }

        private ObservableCollection<string> listaNacionalidades;
        public ObservableCollection<string> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { SetProperty(ref listaNacionalidades, value); }
        }

        private Persona personaFormulario;
        public Persona PersonaFormulario
        {
            get { return personaFormulario; }
            set { SetProperty(ref personaFormulario, value); }
        }

        private void AbrirDialogoNacionalidad()
        {
            servicio.AbrirDialogoNacionalidad();
        }

        private void AnyadirPersona()
        {
            datos.AddPersona(PersonaFormulario);
        }

    }
}
