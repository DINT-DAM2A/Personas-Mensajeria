using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;

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

        private string nombre;

        public string Nombre
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

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

    }
}
