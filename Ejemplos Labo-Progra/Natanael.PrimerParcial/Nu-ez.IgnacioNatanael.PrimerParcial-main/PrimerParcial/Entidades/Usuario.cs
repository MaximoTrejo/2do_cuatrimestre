using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        #region Atributos
        private double legajo;
        public string apellido;
        public string nombre;
        public string correo;
        private string clave;
        public string perfil;


        // public int entero;
        //  private double doble;
        // protected bool booleano;

        #endregion

        #region Propiedad
        /*  public double Doble
          {
              get
              {
                  return this.doble;
              }
              set
              {
                  this.doble = value;
              }
          }*/

        #endregion

        #region Constructor
        public Usuario(string ape, string nom, double leg, string cor, string cla, string per)
        {
            apellido = ape;
            nombre = nom;
            legajo = leg;
            correo = cor;
            clave = cla;
            perfil = per;
        }

        public Usuario() {}
        #endregion


        #region Propiedad
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public double Legajo
        {
            get { return legajo; }
            set { legajo = value; }
        }
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public string Perfil
        {
            get { return perfil; }
            set { perfil = value; }
        }
        #endregion

        #region Método
        public string Mostrar()
        {
            return $"Apellido: {apellido}Nombre: {nombre} Legajo: " +
                $"{legajo} Correo: {correo} Clave:  {clave} " +
                $" Perfil:  {perfil}";

        }

        /*
            return $"legajo: {this.legajo} | nombre: {this.nombre} | apellido: {this.apellido}" +
                $"| correo: {this.correo} | clave: {this.clave} | perfil: {this.perfil}" +
                $"| activo: {this.activo}";
        */
        #endregion
    }
}