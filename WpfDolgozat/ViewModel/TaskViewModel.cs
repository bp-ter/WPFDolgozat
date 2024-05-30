using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfDolgozat.Commands;
using WpfDolgozat.View;

namespace WpfDolgozat.ViewModel
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        private object currentView;
        private Task1View task1View;
        private Task2View task2View;
        private Task3View task3View;

        public ChangeCommand Task1ViewCommand { get; set; }
        public ChangeCommand Task2ViewCommand { get; set; }
        public ChangeCommand Task3ViewCommand {  get; set; }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void onPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public object CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                onPropertyChanged();

            }
        }

        public TaskViewModel()
        {
            task1View = new Task1View();
            task2View = new Task2View();
            task3View = new Task3View();
            CurrentView = task1View;

            Task1ViewCommand = new ChangeCommand(x => CurrentView = task1View);
            Task2ViewCommand = new ChangeCommand(x => CurrentView = task2View);
            Task3ViewCommand = new ChangeCommand(x => CurrentView = task3View);
        }
    }
}
