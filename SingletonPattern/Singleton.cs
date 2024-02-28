using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    using System;

    public class Singleton
    {
        // Variable estática privada para almacenar la única instancia de la clase.
        private static Singleton instance;

        // Declara un constructor privado para evitar que se creen instancias de la clase desde fuera de la misma.
        private Singleton() { }

        // Declara un método estático público que devuelva la única instancia de la clase.
        public static Singleton Instance
        {
            get
            {
                // Verifica si la instancia ya ha sido creada; si no, crea una nueva.
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        // Agrega otros métodos y propiedades según sea necesario.
        public void SomeMethod()
        {
            Console.WriteLine("SomeMethod called.");
        }
    }

}
