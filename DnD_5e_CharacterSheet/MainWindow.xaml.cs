using DnD_5e_CharacterSheet.ViewModels;
using System;
using System.Windows;

namespace DnD_5e_CharacterSheet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainWindowViewModel vm = new MainWindowViewModel();

        public MainWindow()
        {
            InitializeComponent();
            vm.CloseRequested += VM_CloseRequested;
            Closing += MainWindow_Closing;
            DataContext = vm;
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!vm.EnsureSavedChanges())
            {
                e.Cancel = true;
            }
        }

        private void VM_CloseRequested()
        {
            Close();
        }
    }
}
