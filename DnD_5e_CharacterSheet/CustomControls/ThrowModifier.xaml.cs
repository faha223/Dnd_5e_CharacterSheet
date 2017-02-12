using System.Windows;
using System.Windows.Controls;

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
            DependencyProperty.Register("ModifierValue", typeof(int), typeof(ThrowModifier), new PropertyMetadata(-5));

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
