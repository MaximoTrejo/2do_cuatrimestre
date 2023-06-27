namespace Clase_5__Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int [] edades=new int[5]

            //creo una lista (el int es el nombre y le creo espacio )
            List<int> list = new List<int>();
            //con el list.add es para agregar elementos a la lista
            list.Add(1);    
            list.Add(2);
            //el foreach es para recorrerla 
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

        }
    }
}