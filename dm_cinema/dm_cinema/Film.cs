using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    class Film
    {
        private string annee;
        private string genre;
        private int idFilm;
        private string resume;
        private string titre;
        private Acteur acteurPrincipal;

        public Film() { }

        public Film(string annee, string genre, int idFilm, string resume, string titre, Acteur acteurPrincipal)
        {
            this.annee = annee;
            this.genre = genre;
            this.idFilm = idFilm;   
            this.resume = resume;
            this.titre = titre;
            this.acteurPrincipal = acteurPrincipal;
        }

        public string Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int IdFilm
        {
            get { return idFilm; }
            set { idFilm = value; }
        }

        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }

        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }

        public override string ToString()
        {
            return "Titre : " + this.Titre + Environment.NewLine + "Année : " + this.Annee + Environment.NewLine + "Genre : " + this.Genre + Environment.NewLine + "Résumé : " + this.resume ;
        }

        public Acteur getActeurPrincipal()
        {
            return this.acteurPrincipal;
        }
    }
}
