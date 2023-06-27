using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
      public class Pasajero : Usuario
      {
          #region Atributos
          public int dni;
          public int edad;
          public int equipMano;
          public int equipBodega;
          public string telefono;


        #region Constructores
        public Pasajero(string ape, string nom, double leg, string cor, string cla, string per, int dniC, int edadC, int equipManoC, int equipoBodegaC,string telefonoC) : base(ape, nom, leg, cor, cla, per)
        {
            this.dni = dniC;
            this.edad = edadC;
            this.equipMano = equipManoC;
            this.equipBodega = equipoBodegaC;
            this.telefono = telefonoC;
        }
        public Pasajero() {}
        #endregion

        #endregion

        #region Método
        #endregion

    }
}