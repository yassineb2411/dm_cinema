using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dm_cinema
{
    class Acteur
    {
        private string anneeNaissance;
        private int id;
        private string nom;
        private string prenom;

        public Acteur() { }

        public Acteur(string anneeNaissance, int id, string nom, string prenom)
        {
            this.anneeNaissance = anneeNaissance;
            this.id = id;
            this.nom = nom;
            this.Prenom = prenom;
        }

        public string AnneeNaissance
        {
            get { return anneeNaissance; }  
            set { anneeNaissance = value;}
        }

        public int Id
        {
            get { return id; }      
            set { id = value; }
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }

        public override string ToString()
        {
            return "Nom : " + this.Nom + " - Prénom : " + this.Prenom + " - Année de naissance : " + this.AnneeNaissance;
        }
    }
}
