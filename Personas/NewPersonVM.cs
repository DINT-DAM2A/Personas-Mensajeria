using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.ObjectModel;

namespace Personas
{
    class NewPersonVM : ObservableObject
    {
        public RelayCommand AbrirDialogo { get; }

        private readonly ServicioNavegacion servicio;

        public NewPersonVM()
        {
            servicio = new ServicioNavegacion();
            AbrirDialogo = new RelayCommand(AbrirDialogoNacionalidad);

            ListaNacionalidades = GetSamples();
        }

        private ObservableCollection<String> listaNacionalidades;

        public ObservableCollection<String> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { SetProperty(ref listaNacionalidades, value); }
        }

        private void AbrirDialogoNacionalidad()
        {
            servicio.AbrirDialogoNacionalidad();
        }

        private ObservableCollection<String> GetSamples()
        {
            ObservableCollection<String> lista = new ObservableCollection<String>();
            lista.Add("Italiana");
            lista.Add("Española");
            lista.Add("Francesa");

            return lista;
        }
    }
}
