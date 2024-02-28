using SingletonPattern;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Accede a la instancia Singleton utilizando su propiedad estática Instance.
        Singleton singletonInstance = Singleton.Instance;

        // Utiliza los métodos y propiedades de la instancia Singleton.
        singletonInstance.SomeMethod();

        // Verifica que la instancia sea la misma en diferentes partes del código.
        Singleton anotherSingletonInstance = Singleton.Instance;
        Console.WriteLine(singletonInstance == anotherSingletonInstance); // Debería imprimir 'True'.

        Console.ReadLine(); // Para mantener la consola abierta.
    }
}
