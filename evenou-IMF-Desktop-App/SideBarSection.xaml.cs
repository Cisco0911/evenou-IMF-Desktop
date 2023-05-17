using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace evenou_IMF_Desktop_App
{
    /// <summary>
    /// Logique d'interaction pour SideBarSection.xaml
    /// </summary>
    public partial class SideBarSection : UserControl
    {
        // Dependency Property: IsSelected
        //public static readonly DependencyProperty IsSelectedProperty =
        //    DependencyProperty.Register("IsSelected", typeof(string), typeof(SideBarSection), new PropertyMetadata(""));

        //public string IsSelected
        //{
        //    get { return (string)GetValue(IsSelectedProperty); }
        //    set { SetValue(IsSelectedProperty, value); }
        //}

        // Dependency Property: Content
        public static new readonly DependencyProperty ContentProperty =
            DependencyProperty.Register("Content", typeof(object), typeof(SideBarSection), new PropertyMetadata(null));

        public new string Content
        {
            get { return (string)GetValue(ContentProperty); }
            set { SetValue(ContentProperty, value); }
        }

        // Event: OnSelected
        public event EventHandler OnSelected;

        public SideBarSection()
        {
            InitializeComponent();
            // Subscribe to the PropertyChanged event of the App instance
            ((App)Application.Current).PropertyChanged += SideBarSection_PropertyChanged;
        }

        public override void OnApplyTemplate()
        {
            //SectionButton.Content = (string)App.Current.Properties["SelectedSection"];
            if (this.Content == (string)((App)Application.Current).SelectedSection)
            {
                SectionButton.Tag = "True";
            }
            else SectionButton.Tag = "False";
        }

        private void SideBarSection_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Check if the changed property is SelectedSection
            if (e.PropertyName == "SelectedSection")
            {
                // Do something with the updated value
                var newValue = ((App)App.Current).SelectedSection;
                //MessageBox.Show("SelectedSection changed to " + newValue);

                if (this.Content == (string)newValue)
                {
                    SectionButton.Tag = "True";
                }
                else SectionButton.Tag = "False";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //IsSelected = true;
            //SectionButton.Content = (string)Application.Current.Properties["SelectedSection"];

            Button button = sender as Button;

            ((App)App.Current).SelectedSection = button.Content;

            //MessageBox.Show("want to change SelectedSection to " + ((App)App.Current).SelectedSection);
            //OnSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}
