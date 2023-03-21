using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        private string Titulo;
        private int Año;
        private string Pais;
        private string Director;
        //Campos
        private List<Actor> actores = new List<Actor>();

        //Constructores
     
        //Métodos
     
        public void Imprime()
        {
     //       Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades

        //Constructores


        //Métodos 
        public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({Año})");
        }
    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            Pelicula p2 = new Pelicula();
            p1.SetTitulo("La La Land");
            p1.SetAño(2016);
            Console.WriteLine("{0}({1})", p1.GetTitulo(), p1.GetAño());
        }
    }
}
