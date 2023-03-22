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
        public Int16 GetAño()
        {
            return año;
        }
        public void SetAño(Int16 añoo)
        {
            año = añoo;
        }

        public string GetTitulo()
        {
            return titulo;
        }
        public void SetTitulo(string tituloo)
        {
            titulo = tituloo;
        }
        public string Titulo{
            get{return titulo;}
            set{titulo = value;}
        }
        public Int16 Año{
            get{return año;}
            set{año = value;}
        }
        public Pelicula(){}
        public Pelicula(string Titulo, Int16 Año)
        {
            this.Titulo = Titulo;
            this.Año = Año;
            
        }
        
     
        //Métodos
       


        public void Imprime()
        {
            Console.WriteLine($"{GetTitulo()} ({GetAño()})");
        }
       public void ImprimeActores(){
        foreach (Actor act in actores)
        {
            Console.WriteLine(act.ToString());
        }
       }
         public void AgregaActor(Actor actor){
              actores.Add(actor);
         }
    }
    public class Actor 
    {
        //Propiedades
    private string Nombre;
    private Int16 AñoActor;

        //Constructores
    public Actor(string Nombre, Int16 AñoActor){
        this.Nombre = Nombre;
        this.AñoActor = AñoActor;
    }


        //Métodos 

public override string ToString()
        {
            return $"{Nombre} ({AñoActor})";
        }
        public Int16 getAñoActor()
        {
            return AñoActor;
        }
        public void setAñoActor(Int16 a)
        {
            AñoActor = a;
        }
        public string getNombre()
        {
            return Nombre;
        }
        public void setNombre(string nom)
        {
            Nombre = nom;
        }
        public string nombre{
            get{return Nombre;}
            set{Nombre = value;}
        }
        public Int16 añoActor{
            get{return AñoActor;}
            set{AñoActor = value;}
        }
        
        
       /* public void Imprime()
        {
            Console.WriteLine($"{Nombre} ({AñoActor})");
        } */

    }

    // Puedes probar tu código en Main() pero lo importante
    // es que pase las pruebas

    class Program
    {


        static void Main(string[] args)
        {
        Pelicula pelicula1 = new Pelicula("Forest Gump", 1994);
        pelicula1.AgregaActor(new Actor("Tom Hanks", 1980));
        pelicula1.AgregaActor(new Actor("Robin Wright", 1986));
        pelicula1.ImprimeActores();
        
        
        
        
        
        
        /* pelicula1.SetTitulo("Forest Gump");
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

        pelicula1.AgregaActor(new Actor("Tom Hanks", 1980));
        pelicula1.AgregaActor(new Actor("Robin Wright", 1986));
        pelicula1.ImprimerActores();

        //Lista peliculas
        List<Pelicula> peliculas = new List<Pelicula>();
        peliculas.Add(new Pelicula("Forest Gump", 1994, "Estados Unidos", "Robert Zemeckis"));
        peliculas.Add(new Pelicula("El señor de los anillos: el retorno del rey", 2003, "Nueva Zelanda", "Peter Jackson"));
        peliculas.Add(new Pelicula("Braveheart", 1995, "Estados Unidos", "Mel Gibson"));
        peliculas.Add(new Pelicula("Titanic", 1997, "Estados Unidos", "James Cameron"));
        peliculas.Add(new Pelicula("Rocky", 1976, "Estados Unidos", "John G. Avildsen"));
        
        foreach(Pelicula pelicula in peliculas)
        {
            Console.WriteLine($"{pelicula.GetTitulo()} ({pelicula.GetAño()})"); 
        } */
        
        }
    }
}
