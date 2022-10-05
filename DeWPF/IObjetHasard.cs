namespace DeWPF
{
    // Un objet de hasard
    public interface IObjetHasard
    {
        // L'objet a un nom
        string Nom { get; }

        // L'objet doit pouvoir retourner le nombre de faces qu'il a
        int NbFaces { get; }

        // Retourne toutes les faces de l'objet
        Face[] Faces { get; }

        // Quand l'objet est lancé, il retourne la face montrée
        Face Lancer();
    }
}
