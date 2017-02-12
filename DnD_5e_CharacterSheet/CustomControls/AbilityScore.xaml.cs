using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for AbilityScore.xaml
    /// </summary>
    public partial class AbilityScore : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Ability
        {
            get { return (string)GetValue(AbilityProperty); }
            set { SetValue(AbilityProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Ability.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AbilityProperty =
            DependencyProperty.Register("Ability", typeof(string), typeof(AbilityScore), new PropertyMetadata(string.Empty));

        public int Score
        {
            get { return (int)GetValue(ScoreProperty); }
            set { SetValue(ScoreProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Score.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ScoreProperty =
            DependencyProperty.Register("Score", typeof(int), typeof(AbilityScore), new FrameworkPropertyMetadata(1, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, ScoreChanged));

        private static void ScoreChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            ((AbilityScore)d).PropertyChanged?.Invoke(d, new PropertyChangedEventArgs("Modifier"));
        }

        public int Modifier
        {
            get { return getAbilityModifier(Score); }
        }
        
        public AbilityScore()
        {
            InitializeComponent();
        }

        private int getAbilityModifier(int abilityScore)
        {
            switch (abilityScore)
            {
                case 1:
                    return -5;
                case 2:
                case 3:
                    return -4;
                case 4:
                case 5:
                    return -3;
                case 6:
                case 7:
                    return -2;
                case 8:
                case 9:
                    return -1;
                case 10:
                case 11:
                    return 0;
                case 12:
                case 13:
                    return 1;
                case 14:
                case 15:
                    return 2;
                case 16:
                case 17:
                    return 3;
                case 18:
                case 19:
                    return 4;
                case 20:
                case 21:
                    return 5;
                case 22:
                case 23:
                    return 6;
                case 24:
                case 25:
                    return 7;
                case 26:
                case 27:
                    return 8;
                case 28:
                case 29:
                    return 9;
                case 30:
                    return 10;
                default:
                    return 0;
            }
        }
    }
}
