using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class EstadoMateria
    {
        protected int idMateria;
        protected int idParcialUno;
        protected int idParcialDos;
        private eEstado estado_Materia;
        protected float notaUno;
        protected float notaDos;
        protected bool presente;

        public EstadoMateria(int idmateria, eEstado estadoMateria)
        {
            this.idMateria = idmateria;
            this.notaUno = -1;
            this.notaDos = -1;
            this.idParcialUno =-1;
            this.idParcialDos =-1;
            this.estado_Materia = estadoMateria;
            presente = false;
        }

        public EstadoMateria(int idmateria,eEstado estadoMateria, float notaUno, float notaDos,int idParcialUno, int idParcialDos) : this(idmateria,  estadoMateria)
        {
            this.notaUno = notaUno;
            this.notaDos = notaDos;
            this.idParcialUno = idParcialUno;
            this.idParcialDos = idParcialDos;
        }


        public int IdMateria
        {
            get { return idMateria; }
            set { idMateria = value; }
        }

        public int IdParcialUno
        {
            get { return idParcialUno; }
            set { idParcialUno = value; }
        }
        public int IdParcialDos
        {
            get { return idParcialDos; }
            set { idParcialDos = value; }
        }

        public eEstado Estado_Materia
        {
            get { return estado_Materia; }
            set { estado_Materia = value; }

        }

        public static explicit operator EstadoMateria(SqlDataReader v)
        {
            eEstado estadoMateria= eEstado.Regular;
            switch (v["estado"])
            {
                case 0:
                    estadoMateria = eEstado.Regular;
                    break;
                case 1:
                    estadoMateria = eEstado.Libre;
                    break;
                case 2:
                    estadoMateria = eEstado.Cursando;
                    break;
                case 3:
                    estadoMateria = eEstado.aprobado;
                    break;
            }

            EstadoMateria u = new(Convert.ToInt32(v["Id_Materia"]), estadoMateria, Convert.ToSingle(v["Nota_uno"]), Convert.ToSingle(v["Nota_Dos"]), Convert.ToInt32(v["Id_Parcial_Uno"]), Convert.ToInt32(v["Id_Parcial_Dos"]));
            return u;


        }

        public bool Presente
        {
            get { return presente; }
            set { presente = value; }
        }

        public float NotaUno
        {
            get { return notaUno; }
            set { notaUno = value; }
        }
        public float NotaDos
        {
            get { return notaDos; }
            set { notaDos = value; }
        }


    }
}
