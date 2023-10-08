using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Acteur monActeur = new Acteur("13/06/1942", 1, "Ford", "Harisson");
            monActeur.ToString();

            Film monFilm = new Film("1982", "Science-fiction", 1, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner", monActeur);
            monFilm.ToString();

            Console.WriteLine("DM_ CINEMA");
            Console.WriteLine("----------------------------------------------");

            Cinema monCinema = new Cinema();

            monCinema.setActeur("13/06/1942", 1, "Ford", "Harisson");
            monCinema.setActeur("09/07/1956", 2, "Hanks", "Tom");

            Acteur acteurPrincipal1 = monCinema.getActeur(1);
            Acteur acteurPrincipal2 = monCinema.getActeur(2);

            monCinema.setFilm("1982", "Science-fiction", 1, "L'action du film se situe à Los Angeles en 2019 et met en scène Rick Deckard (interprété par Harrison Ford), un ancien policier qui reprend du service pour traquer un groupe de réplicants, des androïdes créés à l'image de l'Homme, menés par l'énigmatique Roy Batty (interprété par Rutger Hauer).", "Blade Runner", acteurPrincipal1);
            monCinema.setFilm("1992", "Animation", 2, "Le film met en scène un groupe de jouets. Woody, une poupée représentant un cow-boy, et Buzz l'Éclair, une figurine d'astronaute, en sont les personnages principaux.", "Toy Story", acteurPrincipal2);

            Console.WriteLine(monCinema.ToString());
            Console.ReadKey();
        }
    }
}
