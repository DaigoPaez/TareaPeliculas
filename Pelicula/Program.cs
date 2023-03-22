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
        public Pelicula(string titulo, int año)
        {
            this.titulo=titulo;
            this.año=año;
        }

        //Métodos
        public string GetTitulo(){return titulo;}
        public int GetAño(){return año;}
        public string GetPais(){return pais;}
        public string GetDirector(){return director;}
        public void SetTitulo(string title){titulo=title;}
        public void SetAño(int year){año=year;}
        public void SetPais(string country){pais=country;}
        public void SetDirector(string direc){director=direc;}
        public void AgregaActor(Actor actor){actores.Add(actor);}
        public void ImprimeActores()
        {
            foreach(Actor persona in actores)
            {
            Console.WriteLine($"{persona.GetNombre()} ({persona.GetAño()})");
            }
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
        public Actor(string Nombre, int Año)
        {
            this.Nombre=Nombre;
            this.Año=Año;
        }

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
            Console.WriteLine("> Películas:");
            Console.WriteLine("{0} ({1})", p1.GetTitulo(), p1.GetAño());
            List<Pelicula> peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula ("Emos vs Darketos", 2008));
            peliculas.Add(new Pelicula ("Yakuza: Like a Dragon", 2020));
            peliculas.Add(new Pelicula ("Kaguya-sama: Love is War, La película", 2022));
            peliculas.Add(new Pelicula ("Marcianos vs Mexicanos", 1986));
            peliculas.Add(new Pelicula ("Pulp Fiction", 1994));

            foreach(Pelicula pelicula in peliculas)
            {
                pelicula.Imprime();
            }

            Console.WriteLine("> Actores:");
            p1.AgregaActor(new Actor("Ryan Gosling", 1980));
            p1.AgregaActor(new Actor("Emma Stone", 1988));
            p1.ImprimeActores();
        }
    }
}
