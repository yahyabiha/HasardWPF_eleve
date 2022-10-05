using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DeWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Piece piece;
        private readonly De6 de6;

        private readonly Dictionary<int, Lancer> _lancers;

        public MainWindow()
        {
            InitializeComponent();

            PieceMonnaie.MouseLeftButtonDown += OnPieceMonnaieLeftButtonDown;
            De6Faces.MouseLeftButtonDown += OnDe6FacesLeftButtonDown;

            piece = new Piece();
            de6 = new De6();

            _lancers = new Dictionary<int, Lancer>();
        }

        private void OnPieceMonnaieLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _lancers[_lancers.Count + 1] = new Lancer(piece, piece.Lancer());
            MonnaieLbl.Content = _lancers[_lancers.Count].Face.Nom;

            AfficherLancers();
        }

        private void OnDe6FacesLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _lancers[_lancers.Count + 1] = new Lancer(de6, de6.Lancer());
            De6Lbl.Content = _lancers[_lancers.Count].Face.Nom;

            AfficherLancers();
        }

        private void AfficherLancers()
        {
            string lancersStr = "";

            foreach (KeyValuePair<int, Lancer> element in _lancers)
            {
                lancersStr += $"Lancer {element.Key}: {element.Value.Objet.Nom} -> {element.Value.Face.Nom}\n";
            }

            LancersTB.Text = lancersStr;
        }
    }
}
