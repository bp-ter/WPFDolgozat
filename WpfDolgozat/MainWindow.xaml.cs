using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Beolvasas.Data;
using Beolvasas.Models;
using WpfDolgozat.ViewModel;


namespace WpfDolgozat
{
    
    public partial class MainWindow : Window
    {
        public ObservableCollection<Person> Emberek;
        public PersonContext db;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new TaskViewModel();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }



        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }

}