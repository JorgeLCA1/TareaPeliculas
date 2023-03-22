using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        private string titulo;
        private Int16 año;
        private string pais;
        private string director;
        private List<Actor> actores = new List<Actor>();

        //Constructores
     
        //Métodos
        public string GetTitulo()
        {
            return titulo;
        }
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public Int16 GetAño()
        {
            return año;
        }
        public void SetAño(Int16 año)
        {
            this.año = año;
        }
        public string GetPais()
        {
            return pais;
        }
        public void SetPais(string pais)
        {
            this.pais = pais;
        }
        public string GetDirector()
        {
            return director;
        }
        public void SetDirector(string director)
        {
            this.director = director;
        }


        public void Imprime()
        {
        Console.WriteLine($"{titulo} ({año})");

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
        Pelicula pelicula1 = new Pelicula();
        pelicula1.SetTitulo("Forest Gump");
        pelicula1.SetAño(1994);
        pelicula1.SetPais("Estados Unidos");
        pelicula1.SetDirector("Robert Zemeckis");
        Console.WriteLine("{0} - ({1})", pelicula1.GetTitulo(), pelicula1.GetAño());

        Pelicula pelicula2= new Pelicula();
        pelicula2.SetTitulo("El señor de los anillos: el retorno del rey");
        pelicula2.SetAño(2003);
        pelicula2.SetPais("Nueva Zelanda");
        pelicula2.SetDirector("Peter Jackson");
        Console.WriteLine("{0} - ({1})", pelicula2.GetTitulo(), pelicula2.GetAño());

        
        
        
        
        }
    }
}
