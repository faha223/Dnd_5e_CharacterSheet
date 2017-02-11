using System;
using System.Windows.Input;

namespace DnD_5e_CharacterSheet.MVVM
{
    internal class ParameteredCommandRouter<T>: ICommand
    {
        private Func<T, bool> canExecute;
        private Action<T> execute;

        public ParameteredCommandRouter(Action<T> Execute, Func<T, bool> CanExecute)
        {
            execute = Execute;
            canExecute = CanExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (canExecute != null)
                return canExecute((T)parameter);
            return true;
        }

        public void Execute(object parameter)
        {
            execute((T)parameter);
        }
    }
}