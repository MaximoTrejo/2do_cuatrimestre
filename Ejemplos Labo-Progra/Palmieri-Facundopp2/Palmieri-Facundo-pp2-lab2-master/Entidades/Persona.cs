using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected string contra;

        public Persona(string nombre, string apellido, int dni, string contra)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.contra = contra;
        }
        public string Nombre
        {
            get { return nombre; }
        }

        public string Apellido
        {
            get { return apellido; }
        }

        public int Dni
        {
            get { return dni; }
        }

        public bool checkContra(string contraseña)
        {
            return contra == contraseña;
        }

        /// <summary>
        /// Crea un metodo virtual para que las clases hija las puedan llamar y modificar y te da los datos de una persona en un string
        /// </summary>
        /// <returns>Un string con todos los datos de una persona</returns>
        public virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"su nombre es:{Nombre}");
            sb.AppendLine($"su apellifo es:{Apellido}");
            sb.AppendLine($"su D.N.I es:{Dni}");

            return sb.ToString();
        }





    }
}
