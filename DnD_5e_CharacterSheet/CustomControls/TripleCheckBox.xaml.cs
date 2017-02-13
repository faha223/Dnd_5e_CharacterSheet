using System;
using System.Collections.Generic;
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

namespace DnD_5e_CharacterSheet.CustomControls
{
    /// <summary>
    /// Interaction logic for TripleCheckBox.xaml
    /// </summary>
    public partial class TripleCheckBox : UserControl
    {
        public bool IsChecked1
        {
            get { return (bool)GetValue(IsChecked1Property); }
            set { SetValue(IsChecked1Property, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked1.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsChecked1Property =
            DependencyProperty.Register("IsChecked1", typeof(bool), typeof(TripleCheckBox), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        
        public bool IsChecked2
        {
            get { return (bool)GetValue(IsChecked2Property); }
            set { SetValue(IsChecked2Property, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsChecked2Property =
            DependencyProperty.Register("IsChecked2", typeof(bool), typeof(TripleCheckBox), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));
        
        public bool IsChecked3
        {
            get { return (bool)GetValue(IsChecked3Property); }
            set { SetValue(IsChecked3Property, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked3.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsChecked3Property =
            DependencyProperty.Register("IsChecked3", typeof(bool), typeof(TripleCheckBox), new FrameworkPropertyMetadata(false, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public TripleCheckBox()
        {
            InitializeComponent();
        }
    }
}
