using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeWPF
{
    public abstract class ObjetHasard : IObjetHasard
    {
        protected static readonly Random rnd = new Random();

        public string Nom { get; }

        public Face[] Faces { get; }

        public int NbFaces => Faces.Length;

        public ObjetHasard(string nom, int nbFaces)
        {
            Nom = nom;
            Faces = new Face[nbFaces];
            CreerFaces();
        }

        protected virtual void CreerFaces()
        {
            for (int valeur = 1; valeur <= NbFaces; valeur++)
            {
                Faces[valeur-1] = new Face(valeur, valeur.ToString());
            }
        }

        public Face Lancer()
        {
            return Faces[rnd.Next(NbFaces)];
        }
    }
}
