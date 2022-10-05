
/*********************************************
 * VOUS NE DEVEZ PAS MODIFIER CE FICHIER !!! *
 * *******************************************/

namespace DeWPF
{
    public class Lancer
    {
        public ObjetHasard Objet { get; }
        public Face Face { get; }

        public Lancer(ObjetHasard objet, Face face)
        {
            Objet = objet;
            Face = face;
        }
    }
}
