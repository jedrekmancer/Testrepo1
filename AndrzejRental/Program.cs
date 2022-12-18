using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AndrzejRental.RentalUtils;

namespace AndrzejRental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rental x = new Rental();
            PopuletMovies(x);


            Console.WriteLine("Podaj tytuł filmu, jaki chciałbyś/chciałabyś wypożyczyć.");

            IMovie movie = x.Find(Console.ReadLine());
            if (movie != null)
            {
                //Console.WriteLine(
            }

            





            Console.ReadKey();
        }



        static void PopuletMovies(Rental wypozyczalnia)
        {
            wypozyczalnia.AddMovie(new BluRayMovie("Garfild", 2));
            wypozyczalnia.AddMovie(new BluRayMovie("Pamiętnik", 5));
            wypozyczalnia.AddMovie(new BluRayMovie("Need For Speed", 3));
            wypozyczalnia.AddMovie(new BluRayMovie("Skazani na Shawshank", 3));
            wypozyczalnia.AddMovie(new DvdMovie("Za szybko za wściekle", 3));
            wypozyczalnia.AddMovie(new DvdMovie("Harry Potter - Kamień Filozoficzny", 5));
            wypozyczalnia.AddMovie(new DvdMovie("Harry Potter - Komnata Tajemnic", 5));
            wypozyczalnia.AddMovie(new VhsMovie("Once Upon a Time in the West", 3));
            wypozyczalnia.AddMovie(new VhsMovie("The Godfather", 7));
            wypozyczalnia.AddMovie(new VhsMovie("The Godfather II", 5));
            wypozyczalnia.AddMovie(new VhsMovie("12 Angry Men", 4));
            //rozwiazanie numer 1 - najpierw tworze obiekt, przechowuje w zmiennej MoviePhisical
            //nastepnie dodaje go do listy, a potem wolam na nim metode wyswietlajaca liczbe nośników:
            MoviePhisical x = new VhsMovie("12 Angry Men", 4);
            wypozyczalnia.AddMovie(x);
            //x.CalculateAllFilms();
            //rozwiazanie numer 2:
            //wypozyczalnia.AddMovie(new VhsMovie("12 Angry Men", 4));
            //IMovie x = wypozyczalnia.Find("12 Angry Men");
            //(x as MoviePhisical).CalculateAllFilms();
            wypozyczalnia.AddMovie(new StreamingMovie("Intouchables"));
            wypozyczalnia.AddMovie(new StreamingMovie("Inception"));
            wypozyczalnia.AddMovie(new StreamingMovie("Green Book"));
            wypozyczalnia.AddMovie(new StreamingMovie("Zootopia"));
            Console.WriteLine(MoviePhisical.CalculateAllFilms_Static());
        }


    }
}
