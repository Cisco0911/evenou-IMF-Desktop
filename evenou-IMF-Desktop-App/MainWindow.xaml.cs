using System.Collections.Generic;
using System.Windows;

namespace evenou_IMF_Desktop_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> NavigationSections { get; set; }
        public string SelectedNavigationSection { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            // Initialiser les données pour la navigation
            NavigationSections = new List<string> { "Credits", "Epargnes", "Tontines", "Gestionnaires", "Clients" };
            SelectedNavigationSection = "Test";

            // Définir le contexte de données de la page sur cette instance
            DataContext = this;
        }
    }
}
