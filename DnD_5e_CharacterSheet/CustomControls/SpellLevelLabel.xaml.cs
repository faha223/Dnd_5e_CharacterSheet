using System.Windows;
using System.Windows.Controls;

namespace DnD_5e_CharacterSheet.CustomControls
{
    /// <summary>
    /// Interaction logic for SpellLevelLabel.xaml
    /// </summary>
    public partial class SpellLevelLabel : UserControl
    {
        public int SpellLevel
        {
            get { return (int)GetValue(SpellLevelProperty); }
            set { SetValue(SpellLevelProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SpellLevel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpellLevelProperty =
            DependencyProperty.Register("SpellLevel", typeof(int), typeof(SpellLevelLabel), new PropertyMetadata(1));

        public int SpellSlots
        {
            get { return (int)GetValue(SpellSlotsProperty); }
            set { SetValue(SpellSlotsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SpellSlots.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpellSlotsProperty =
            DependencyProperty.Register("SpellSlots", typeof(int), typeof(SpellLevelLabel), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public int SpellSlotsExpended
        {
            get { return (int)GetValue(SpellSlotsExpendedProperty); }
            set { SetValue(SpellSlotsExpendedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SpellSlotsExpended.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SpellSlotsExpendedProperty =
            DependencyProperty.Register("SpellSlotsExpended", typeof(int), typeof(SpellLevelLabel), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        public bool ShowLabels
        {
            get { return (bool)GetValue(ShowLabelsProperty); }
            set { SetValue(ShowLabelsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ShowLabels.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ShowLabelsProperty =
            DependencyProperty.Register("ShowLabels", typeof(bool), typeof(SpellLevelLabel), new PropertyMetadata(false));

        public SpellLevelLabel()
        {
            InitializeComponent();
        }
    }
}
