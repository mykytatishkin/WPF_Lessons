using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFProductsMVVM.Infrastructure
{
    internal class RelyCommand: ICommand
    {
        Predicate<object>? canExecuteMethod;
        Action<object>? executeMethod;

        public event EventHandler? CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public RelyCommand(Action<object>? executeMethod, Predicate<object>? canExecuteMethod = null)
        {
            this.canExecuteMethod = canExecuteMethod;
            this.executeMethod = executeMethod;
        }

        public bool CanExecute(object? parameter)
        {
            return canExecuteMethod == null || canExecuteMethod(parameter);
        }

        public void Execute(object? parameter)
        {
            executeMethod?.Invoke(parameter);
        }
    }
}
