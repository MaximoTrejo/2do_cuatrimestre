namespace Genero_Cursos
{
    public class Class1
    {
        public string Generos(bool gneroM, bool gneroF)
        {
            string Genero;
            if (gneroM)
            {
                Genero = "masculino";
            }
            else if (gneroF)
            {
                Genero = "femenino";
            }
            else
            {
                Genero = "no binario";
            }
            return Genero;
        }

        public string Cursos(bool a1, bool a2)
        {
            string cursos;
            if (a1)
            {
                cursos = "C#";
            }
            else if (a2)
            {
                cursos = "C++";
            }
            else
            {
                cursos = "Java Script";
            }
            return cursos;
        }
    }
}