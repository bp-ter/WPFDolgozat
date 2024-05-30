using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Beolvasas.Data;
using Beolvasas.Models;

namespace WpfDolgozat.View
{
    /// <summary>
    /// Interaction logic for Task3View.xaml
    /// </summary>
    public partial class Task3View : UserControl
    {       
        public ObservableCollection<Person> Emberek;
        public PersonContext db;
        public Task3View()
        {
            InitializeComponent();
                Emberek = new ObservableCollection<Person>();
                db = new PersonContext();
               ReflesAnimals();
               lbEmberek.ItemsSource = Emberek;
               spInput.DataContext = Emberek;
        }
        private void ReflesAnimals()
        {
                Emberek.Clear();
                if (db.Persons.Any())
                    foreach (var item in db.Persons)
                        Emberek.Add((Person)item);
                else Emberek.Add(new Person());
        }
            private void Add_Click(object sender, RoutedEventArgs e)
            {
                Person ember = lbEmberek.SelectedItem as Person;

                if (ember.Name != null)
                {
                    ember.Id = 0;
                    db.Persons.Add(ember);
                    db.SaveChanges();

                    ReflesAnimals();
                    lbEmberek.SelectedItem = ember;
                }
            }

            private void Update_Click(object sender, RoutedEventArgs e)
            {
                Person allat = lbEmberek.SelectedItem as Person;
                if (allat.Name != null)
                {
                    db.Persons.Update(allat);
                    db.SaveChanges();
                    ReflesAnimals();
                    lbEmberek.SelectedItem = allat;
                }
            }

            private void Delete_Click(object sender, RoutedEventArgs e)
            {
                Person ember = lbEmberek.SelectedItem as Person;
                if (ember != null && ember.Id != 0)
                {
                    int index = lbEmberek.SelectedIndex;
                    db.Persons.Remove(ember);
                    db.SaveChanges();
                    ReflesAnimals();
                    lbEmberek.SelectedIndex = index < lbEmberek.Items.Count ? index : lbEmberek.Items.Count - 1;
                }
            }
    }
}
