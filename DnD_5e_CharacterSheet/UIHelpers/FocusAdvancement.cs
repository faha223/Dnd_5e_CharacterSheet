using System.Windows;
using System.Windows.Input;

namespace DnD_5e_CharacterSheet.UIHelpers
{
    public static class FocusAdvancement
    {
        public static bool GetAdvancesByEnterKey(DependencyObject obj)
        {
            return (bool)obj.GetValue(AdvancesByEnterKeyProperty);
        }

        public static void SetAdvancesByEnterKey(DependencyObject obj, bool value)
        {
            obj.SetValue(AdvancesByEnterKeyProperty, value);
        }

        public static readonly DependencyProperty AdvancesByEnterKeyProperty =
            DependencyProperty.RegisterAttached("AdvancesByEnterKey", typeof(bool), typeof(FocusAdvancement),
            new UIPropertyMetadata(OnAdvancesByEnterKeyPropertyChanged));

        static void OnAdvancesByEnterKeyPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var element = d as UIElement;
            if (element == null) return;

            if ((bool)e.NewValue) element.PreviewKeyDown += PreviewKeyDown;
            else element.PreviewKeyDown -= PreviewKeyDown;
        }

        static void PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Key.Equals(Key.Enter) && !e.Key.Equals(Key.Down) && !e.Key.Equals(Key.Up)) return;

            var dir = FocusNavigationDirection.Next;
            if (e.Key.Equals(Key.Up))
                dir = FocusNavigationDirection.Previous;

            var element = sender as UIElement;
            if (element != null) element.MoveFocus(new TraversalRequest(dir));
        }
    }
}
