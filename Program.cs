using System;
using System.Collections.Generic;

namespace Peliculas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peliculaNombre = new List<string>();
            peliculaNombre.Add("Toy Story");
            peliculaNombre.Add("Avengers");
            peliculaNombre.Add("Bicentennial Man");
            peliculaNombre.Add("Beetlejuice");
            peliculaNombre.Add("Silence of the lambs");
            peliculaNombre.Add("Bad Boys");
            peliculaNombre.Add("Bad Boys");
            peliculaNombre.Add("Aladdin");
            peliculaNombre.Add("Aladdin");
        //No permite elementos duplicados 
            HashSet<string> setPeliculaNombre = new HashSet<string>();
            setPeliculaNombre.Add("Toy Story");
            setPeliculaNombre.Add("Avengers");
            setPeliculaNombre.Add("Bicentennial Man");
            setPeliculaNombre.Add("Beetlejuice");
            setPeliculaNombre.Add("Silence of the lambs");
            setPeliculaNombre.Add("Bad Boys");
            setPeliculaNombre.Add("Bad Boys");
            setPeliculaNombre.Add("Aladdin");
            setPeliculaNombre.Add("Aladdin");

            Console.WriteLine("Cant. de peliculas en peliculaNombre: " + peliculaNombre.Count);
            Console.WriteLine("Cant. de peliculas en setpeliculaNombre: " + setPeliculaNombre.Count);

            HashSet <Pelicula> peliculasSet = new HashSet<Pelicula>();
            peliculasSet.Add(new Pelicula("Bad Boys", 1995));
            peliculasSet.Add(new Pelicula("Bad Boys", 1983));
            peliculasSet.Add(new Pelicula("Aladdin", 2019));
            peliculasSet.Add(new Pelicula("Aladdin", 1992));
            peliculasSet.Add(new Pelicula("Aladdin", 1992));//son objetos distintos, incluso si tienen los
            //mismos datos 

            Console.WriteLine("Cant. de peliculasSet: " + peliculasSet.Count);
            //c# override equals: comparar valores

            //Map - Java
            //Dictionary - c#, python
            //Object - Javascript

            Dictionary<string, string> nomPeliculasFavoritas = new Dictionary<string, string>();
            nomPeliculasFavoritas.Add("Pedro", "Titanic");
            nomPeliculasFavoritas.Add("Sebastián", "Fast and furious");
            nomPeliculasFavoritas.Add("Rosa", "Barbie in the 12 dancing princesses");

            string nomPeliculaFavPedro = nomPeliculasFavoritas.GetValueOrDefault("Pedro");
            Console.WriteLine("La pelicula favorita de Pedro es: " + nomPeliculaFavPedro);
            string nomPeliculaFavRamiro = nomPeliculasFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");
            Console.WriteLine("La pelicula favorita de Ramiro es: " + nomPeliculaFavRamiro);
            
            nomPeliculasFavoritas.Add("Ramiro", "Avatar");
              nomPeliculaFavRamiro = nomPeliculasFavoritas.GetValueOrDefault("Ramiro", "(Ninguna)");
            Console.WriteLine("La pelicula favorita de Ramiro es: " + nomPeliculaFavRamiro);

            //uso real de obtener valores de un dictonary
            if(nomPeliculasFavoritas.TryGetValue("María", out string nomPeliculaFavMaria))
            {
                Console.WriteLine("La pelicula favorita de Maria es: " + nomPeliculaFavMaria);
            }
            else
            {
                Console.WriteLine("Maria no tiene pelicula favorita.");
            }

            //iterar lista
            Console.WriteLine("------------------------");
            Console.WriteLine("Lista");
            for(int i=0; i<peliculaNombre.Count; i++)
            {
                Console.WriteLine(peliculaNombre[i]);
            }
            //iterar HashSet
            Console.WriteLine("-----------------------");
            Console.WriteLine("HashSet");
            foreach (string nombrePelicula in setPeliculaNombre)
            {
                Console.WriteLine(nombrePelicula);
            }

            //Dictionary
            Console.WriteLine("--------------------");
            Console.WriteLine("Dictionary");
            foreach (var key  in nomPeliculasFavoritas.Keys)
            {
                Console.WriteLine(key);
            }
            foreach (var value in nomPeliculasFavoritas.Values)
            {
               Console.WriteLine(value); 
            }
            foreach (var key in nomPeliculasFavoritas.Keys)
            {
                Console.WriteLine(key + ":" + nomPeliculasFavoritas.GetValueOrDefault(key));
            }
        }
    }
}
