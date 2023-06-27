using System.Text;

namespace Ingresante
{
    public class ingresante
    {
        string cursos;
        string direccion;
        int edad;
        string genero;
        string nombre;
        string pais;

        public ingresante(string cursos ,string direccion , int edad, string genero,string nombre,string pais )
        {
            this.cursos = cursos;
            this.direccion = direccion;
            this.edad = edad;
            this.genero = genero;
            this.nombre = nombre;
            this.pais = pais;

        }
        public string Mostrar()
        {
            string mensaje;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre} \nEdad: {this.edad} \n apellido: {this.direccion}  \ngenero: {this.genero}  \npais: {this.pais}  \ncursos: {this.cursos} " );
            mensaje = sb.ToString();
            return mensaje;
        }

        
    }
}