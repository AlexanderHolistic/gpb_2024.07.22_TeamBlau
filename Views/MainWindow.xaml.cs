using Template.ViewModels;
using System.Windows;

namespace Template
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowViewModel ViewModel
        {
            get { return this.DataContext as MainWindowViewModel; }
            set { this.DataContext = value; }
        }


        public MainWindow()
        {
            InitializeComponent();
        }


    }
}