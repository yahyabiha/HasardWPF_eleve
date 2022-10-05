
namespace DeWPF
{
    public class Face : IFace
    {
        public int Valeur { get; }

        public string Nom { get; }

        public Face(int v, string nom)
        {
            Valeur = v;
            Nom = nom;
        }
    }
}
