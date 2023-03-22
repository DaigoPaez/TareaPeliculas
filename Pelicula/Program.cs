using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        private string titulo;
        private int año;
        private string pais;
        private string director;
        //Campos
        private List<Actor> actores = new List<Actor>();

        //Constructores
        public Pelicula(){}
        public Pelicula(string titulo, int año){}

        //Métodos
        public string GetTitulo(){return titulo;}
        public void SetTitulo(string title){title=titulo;}
        public int GetAño(){return año;}
        public void SetAño(int year){year=año;}
        public string GetPais(){return pais;}
        public string GetDirector(){return director;}
        public void AgregaActor(Actor actor){actores.Add(actor);}
        public void ImprimeActores()
        {
        }
        public void Imprime()
        {
            Console.WriteLine($"{titulo} ({año})");
     //       Console.WriteLine($"{titulo} ({año})");

        }


    }

    public class Actor
    {
        //Propiedades
        string Nombre;
        int Año;
        //Constructores
        public Actor(){}
        public Actor(string Nombre, int Año){}

        //Métodos 
        public string GetNombre(){return Nombre;}
        public int GetAño(){return Año;}
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

            List<Pelicula> peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula ("1", 2020));
            peliculas.Add(new Pelicula ("2", 2012));
            peliculas.Add(new Pelicula ("3", 2005));
            peliculas.Add(new Pelicula ("4", 1986));
            peliculas.Add(new Pelicula ("5", 2013));

            p1.AgregaActor(new Actor("Ryan Gosling", 1980));
            p1.AgregaActor(new Actor("Emma Stone", 1988));

            p1.ImprimeActores();
        }
    }
}
