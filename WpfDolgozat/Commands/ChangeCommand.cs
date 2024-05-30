using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfDolgozat.Commands
{
    public class ChangeCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;
        private Action<object> _execute;

        public ChangeCommand(Action<object> execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
