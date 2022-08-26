using exercice_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice_1
{
    public class Livre
    {
        public string Titre { get; }
        public string Auteur { get; }
        public string Editeur { get; }
        private int _NbDePages;
        public int NbDePages
        {
            get { return _NbDePages; }

            set { 
                if (value < 0)
                    {
                        throw new ArgumentException("le nombres de pages doit depasser 0");
                }
                _NbDePages = value;
            }
        }
        public int Annee { get; }


        public Livre(string titre, string auteur, string editeur, int nbDePages, int annee)
        {
            Titre = titre;
            Auteur = auteur;
            Editeur = editeur;
            NbDePages = nbDePages;
            Annee = annee;

        }
        override public string ToString()
        {
            StringBuilder Phrase = new StringBuilder(Titre,100);
            Phrase.Append(", ");
            Phrase.Append(Auteur);
            Phrase.Append(", ");
            Phrase.Append(Editeur);
            Phrase.Append(", ");
            Phrase.Append(_NbDePages);
            Phrase.Append(" pages ");
            Phrase.Append(Annee);
            Phrase.Append(".");

            return Phrase.ToString();

            // return $"{Titre}, {Auteur}, {Editeur}, {_NbDePages}, pages, {Annee}. ";
        }
    }



}
