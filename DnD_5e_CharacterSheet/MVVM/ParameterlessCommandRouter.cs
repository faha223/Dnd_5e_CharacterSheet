using System;
using System.Windows.Input;

namespace DnD_5e_CharacterSheet.MVVM
{
    internal class ParameterlessCommandRouter : ICommand
    {
        private Func<bool> canExecute;
        private Action execute;

        public ParameterlessCommandRouter(Action Execute, Func<bool> CanExecute)
        {
            execute = Execute;
            canExecute = CanExecute;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            if (canExecute != null)
                return canExecute();
            return true;
        }

        public void Execute(object parameter)
        {
            execute();
        }
    }
}