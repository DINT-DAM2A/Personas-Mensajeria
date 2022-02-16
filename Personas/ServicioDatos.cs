using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System.Collections.ObjectModel;

namespace Personas
{
    class ServicioDatos : ObservableObject
    {
        private static ServicioDatos instance = null;

        private ServicioDatos()
        {
            init();
        }

        public ObservableCollection<string> listaNacionalidades;
        public ObservableCollection<string> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { SetProperty(ref listaNacionalidades, value); }
        }

        private ObservableCollection<Persona> listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }

        public static ServicioDatos Instance()
        {
            if (instance == null)
            {
                instance = new ServicioDatos();
            }

            return instance;
        }

        public void AddPersona(Persona per)
        {
            ListaPersonas.Add(per);
        }

        private void init()
        {
            if (listaNacionalidades == null)
            {
                ListaNacionalidades = GetSamplesNacionalidades();

                //Listener que recibe altas de nuevas nacionalidades
                WeakReferenceMessenger.Default.Register<NewNacionalidadMessage>(this, (r, m) =>
                {
                    ListaNacionalidades.Add(m.Value);
                });
            }

            if (ListaPersonas == null)
            {
                ListaPersonas = GetSamplesPersonas();

                //Listener que recibe altas de nuevas personas
                WeakReferenceMessenger.Default.Register<NewPersonMessage>(this, (r, m) =>
                {
                    ListaPersonas.Add(m.Value);
                });
            }
        }

        private ObservableCollection<string> GetSamplesNacionalidades()
        {
            ObservableCollection<string> lista = new ObservableCollection<string>();
            lista.Add("Italiana");
            lista.Add("Española");
            lista.Add("Francesa");

            return lista;
        }

        public static ObservableCollection<Persona> GetSamplesPersonas()
        {
            ObservableCollection<Persona> lista = new ObservableCollection<Persona>();

            lista.Add(new Persona("Pietro", 30, "Italiana"));
            lista.Add(new Persona("Julia", 25, "Española"));
            lista.Add(new Persona("Sophie", 35, "Francesa"));

            return lista;
        }

    }
}
