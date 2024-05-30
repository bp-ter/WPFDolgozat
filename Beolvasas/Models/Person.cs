using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Beolvasas.Models
{
    public class Person : INotifyPropertyChanged
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                Pperson();
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; Pperson(); }
        }

        private string building;

        public string Building
        {
            get { return building; }
            set { building = value; Pperson(); }
        }

        private string postcode;

        public string Postcode
        {
            get { return postcode; }
            set { postcode = value; Pperson(); }
        }

        private string position;

        public string Position
        {
            get { return position; }
            set { position = value; Pperson(); }
        }

        private string transport;

        public string Transport
        {
            get { return transport; }
            set { transport = value; Pperson(); }
        }

        public Person(int id, string name, string building, string postcode, string position, string transport)
        {
            Id = id;
            Name = name;
            Building = building;
            Postcode = postcode;
            Position = position;
            Transport = transport;
        }

        public Person(string sor)
        {
            string[] a = sor.Split(';');
            Name = a[0];
            Building = a[1];
            Postcode = a[2];
            Position = a[3];
            Transport = a[4];
        }

        public Person()
        {
        }

        public override string ToString()
        {
            return Name != null ? $"Név: {Name}, Épület: {Building}, Irányítószám: {Postcode}, Pozíció: {Position}, Közlekedés: {Transport}" : "";
        }

        private void Pperson([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}


