namespace DeWPF
{
    // Une pièce de monnaie à deux faces
    internal class Piece : ObjetHasard
    {
        public Piece() : base("Pièce", 2) { }

        protected sealed override void CreerFaces()
        {
            Faces[0] = new Face(0, "pile");
            Faces[1] = new Face(0, "face");
        }
    }
}
