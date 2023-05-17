using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace evenou_IMF_Desktop_App
{
    /// <summary>
    /// Interaction logic for VerticalNavigationBar.xaml
    /// </summary>
    public partial class VerticalNavigationBar : UserControl
    {
        //public static readonly DependencyProperty SectionsProperty =
        //    DependencyProperty.Register("Sections", typeof(List<string>), typeof(VerticalNavigationBar), new PropertyMetadata(new List<string>()));

        //public static readonly DependencyProperty SelectedSectionProperty =
        //    DependencyProperty.Register("SelectedSection", typeof(string), typeof(VerticalNavigationBar), new PropertyMetadata(null));

        //public List<string> Sections
        //{
        //    get { return (List<string>)GetValue(SectionsProperty); }
        //    set { SetValue(SectionsProperty, value); }
        //}

        //public string SelectedSection
        //{
        //    get { return (string)GetValue(SelectedSectionProperty); }
        //    set { SetValue(SelectedSectionProperty, value); }
        //}

        public BitmapImage Logo
        {
            get { var uri = new Uri("pack://application:,,,/evenou-IMF-Desktop-App;component/Images/IMF logo.png"); return new BitmapImage(uri); }
            set { Logo = value; }
        }

        public VerticalNavigationBar()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void SectionButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                Application.Current.Properties["SelectedSection"] = button.Content as string;
            }
        }
    }
}
