namespace hilos
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    class Program
    {
        // Declarar un delegado para el evento
        public delegate void OperacionTerminadaEventHandler(string mensaje);

        // Declarar el evento
        public static event OperacionTerminadaEventHandler OperacionTerminada;

        static void Main(string[] args)
        {
            // Asociar métodos al evento
            OperacionTerminada += MostrarMensaje;
            OperacionTerminada += FinalizarPrograma;

            // Crear una lista de productos
            List<Producto> productos = new List<Producto>()
        {
            new Producto("Producto 1", 10),
            new Producto("Producto 2", 5),
            new Producto("Producto 3", 8)
        };

            // Crear una lista de usuarios
            List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario("Usuario 1", 100),
            new Usuario("Usuario 2", 50),
            new Usuario("Usuario 3", 80)
        };

            // Crear hilos para reducir el stock de productos y el monto de usuarios
            Thread productosThread = new Thread(() => ReducirStockProductos(productos));
            Thread usuariosThread = new Thread(() => ReducirMontoUsuarios(usuarios));
            productosThread.Start();
            usuariosThread.Start();

            // Esperar a que ambos hilos terminen antes de salir del programa
            productosThread.Join();
            usuariosThread.Join();
        }

        static void ReducirStockProductos(List<Producto> productos)
        {
            foreach (Producto producto in productos)
            {
                Console.WriteLine($"Reduciendo stock de {producto.Nombre}...");

                // Simular una operación que reduce el stock del producto
                Thread.Sleep(2000);
                producto.ReducirStock();
            }

            OperacionTerminada?.Invoke("Stock de productos reducido.");
        }

        static void ReducirMontoUsuarios(List<Usuario> usuarios)
        {
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine($"Reduciendo monto de {usuario.Nombre}...");

                // Simular una operación que reduce el monto del usuario
                Thread.Sleep(1500);
                usuario.ReducirMonto();
            }

            OperacionTerminada?.Invoke("Monto de usuarios reducido.");
        }

        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine("Mensaje del evento: " + mensaje);
        }

        static void FinalizarPrograma(string mensaje)
        {
            Console.WriteLine("Finalizando programa...");
            // Puedes agregar aquí cualquier lógica adicional que necesites para finalizar el programa.
        }
    }

    class Producto
    {
        public string Nombre { get; set; }
        public int Stock { get; set; }

        public Producto(string nombre, int stock)
        {
            Nombre = nombre;
            Stock = stock;
        }

        public void ReducirStock()
        {
            Stock--;
        }
    }

    class Usuario
    {
        public string Nombre { get; set; }
        public int Monto { get; set; }

        public Usuario(string nombre, int monto)
        {
            Nombre = nombre;
            Monto = monto;
        }

        public void ReducirMonto()
        {
            Monto -= 10;
        }
    }
}