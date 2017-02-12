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
    /// Interaction logic for ThrowModifier.xaml
    /// </summary>
    public partial class ThrowModifier : UserControl
    {
        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for IsChecked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty IsCheckedProperty =
            DependencyProperty.Register("IsChecked", typeof(bool), typeof(ThrowModifier), new PropertyMetadata(false));

        public int ModifierValue
        {
            get { return (int)GetValue(ModifierValueProperty); }
            set { SetValue(ModifierValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ModifierValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ModifierValueProperty =
            DependencyProperty.Register("ModifierValue", typeof(int), typeof(ThrowModifier), new PropertyMetadata(0));

        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Label.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register("Label", typeof(string), typeof(ThrowModifier), new PropertyMetadata(string.Empty));

        public ThrowModifier()
        {
            InitializeComponent();
        }
    }
}
