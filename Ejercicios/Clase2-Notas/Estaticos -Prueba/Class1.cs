namespace Entidades
{

    //para crear una clase estatica (static)  si se crea una clase estatica todo lo de adentro tiene que ser estatico

    //estatic se recerva en la memoria aparte no heat  (solo existe una ves )

    //atributos == variables (se encuentran afuera de las clases pero dentro de los metodos)
    
    //metodos == funciones

    public static class Class1
    {
        private static int primerNumero;
        private static int segundoNumero;

        //contructor (inicializa variables) se ejecutan al principio del programa siempre 
        static Calculadora() 
        {
            primerNumero = 0;
            segundoNumero = 0;
        }

        private static int ContarNumeros() 
        {

            return 2;
        }

        //todas las clases pueden tener muchos metodos 
        //todas los metodos tienen que estar adentro de una clase


        private static int contar()
        {
            return 2;   
        }

    }

}