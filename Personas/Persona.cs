using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.ObjectModel;

namespace Personas
{
    class Persona : ObservableObject
    {
        public Persona()
        {
            Nombre = "";
            Edad = 0;
            Nacionalidad = "";
        }

        public Persona(string nombre, int edad, string nacionalidad)
        {
            Nombre = nombre;
            Edad = edad;
            Nacionalidad = nacionalidad;
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private String nacionalidad;

        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public static ObservableCollection<Persona> GetSamples()
        {
            ObservableCollection<Persona> lista = new ObservableCollection<Persona>();

            lista.Add(new Persona("Pietro", 30, "Italiana"));
            lista.Add(new Persona("Julia", 25, "Española"));
            lista.Add(new Persona("Sophie", 35, "Francesa"));

            return lista;
        }

    }
}
