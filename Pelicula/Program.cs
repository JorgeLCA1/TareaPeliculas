using System;
using System.Collections.Generic;

namespace Pelicula
{

    public class Pelicula
    {
        //Campos
        public string titulo;
        public Int16 año;
        public string pais;
        public string director;
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
        Pelicula pelicula1 = new Pelicula();
        pelicula1.titulo="Forest Gump";
        pelicula1.año=1994;
        pelicula1.pais="Estados Unidos";
        pelicula1.director="Robert Zemeckis";

        Pelicula pelicula2= new Pelicula();
        pelicula2.titulo="El señor de los anillos: el retorno del rey";
        pelicula2.año=2003;
        pelicula2.pais="Nueva Zelanda";
        pelicula2.director="Peter Jackson";

        
        Console.WriteLine("Peliculas ganadoras de Oscar a mejor película");
        console.WriteLine("============================================");
        console.WriteLine("- "+pelicula1.titulo+" ("+pelicula1.año+") - "+pelicula1.pais+" - "+pelicula1.director);
        Console.WriteLine("- "+pelicula2.titulo+" ("+pelicula2.año+") - "+pelicula2.pais+" - "+pelicula2.director);
        
        }
    }
}
