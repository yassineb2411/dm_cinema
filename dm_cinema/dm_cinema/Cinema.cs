using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    internal class Cinema
    {
        private Cinema cine;
        private List<Acteur> LesActeurs;
        private List<Film> LesFilms;

        public Cinema()
        {
            this.LesActeurs = new List<Acteur>();
            this.LesFilms = new List<Film>();
        }

        public Acteur getActeur(int id)
        {
            Acteur acteur1 = null;
            foreach(Acteur acteur in this.LesActeurs)
            {
                if(acteur.Id == id)
                {
                    acteur1 = acteur;
                }
            }
            return acteur1;
        }

        public Film getFilm(int id)
        {
            Film film1 = null;
            foreach (Film film in this.LesFilms)
            {
                if (film.IdFilm == id)
                {
                    film1 = film;
                }
            }
            return film1;
        }

        public int nbActeurs()
        {
            int nbActeurs = LesActeurs.Count;
            return nbActeurs;
        }

        public void setFilm(string annee, string genre, int idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            Film film1 = new Film(annee, genre, idFilm, resume, titre, acteurPrincipal);
            LesFilms.Add(film1);
        }

        public void setActeur(string anneeNaissance, int id, string nom, string prenom)
        {
            Acteur acteur1 = new Acteur(anneeNaissance, id, nom, prenom);
            LesActeurs.Add(acteur1);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Film LeFilm in LesFilms)
            {
                string annee1 = LeFilm.Annee;
                string titre1 = LeFilm.Titre;
                string genre1 = LeFilm.Genre;
                string resume1 = LeFilm.Resume;
                Acteur acteurPrincipal1 = LeFilm.getActeurPrincipal();

                sb.AppendLine("Année : " + annee1);
                sb.AppendLine("Titre : " + titre1);
                sb.AppendLine("Genre : " + genre1);
                sb.AppendLine("Résumé : " + resume1);
                sb.AppendLine("Acteur Principal -> " + acteurPrincipal1);
                sb.AppendLine();
            }

            return sb.ToString();
        }

    }
}
