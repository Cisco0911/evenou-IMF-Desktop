using System;
using System.ComponentModel;
using System.Windows;

namespace evenou_IMF_Desktop_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application, INotifyPropertyChanged
    {
        // Declare your global variable as a property
        private object _selectedSection;
        public object SelectedSection
        {
            get { return _selectedSection; }
            set
            {
                if (_selectedSection != value)
                {
                    _selectedSection = value;
                    OnPropertyChanged("SelectedSection");
                }
            }
        }

        // Implement the INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //MessageBox.Show("want to change SelectedSection to " + SelectedSection+propertyName);
        }


        // Set the default value in the constructor
        public App()
        {
            InitializeComponent();
            SelectedSection = "Credit";
        }


        // Or set the default value in the OnStartup method
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            AppDomain.CurrentDomain.SetData("APPNAME", this);

            SelectedSection = "Credit";
            //App.Current.Properties["SelectedSection"] = SelectedSection;
        }
    }
}
