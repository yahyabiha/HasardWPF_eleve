namespace DeWPF
{
    // Une face d'un objet de hasard
    public interface IFace
    {
        // Une face a une valeur
        int Valeur { get; }


        // Une face a un nom
        string Nom { get; }
    }
}
