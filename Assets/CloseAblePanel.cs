#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

#endif


namespace KungFCollage
{
    [ContentProperty("Children")]
    public class CloseAblePanel : UserControl
    {
        public Visibility CloseType { get; set; }
        public UIElementCollection Children { get; set; }

        public CloseAblePanel()
        {
            var stackPanel = new StackPanel() { Orientation = Orientation.Horizontal, VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Right };

            var grid = new Grid();
            stackPanel.Children.Add(grid);

            var button = new Button() { Content = "X", Width = 30, Height = 30, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Top };
            stackPanel.Children.Add(button);

            button.Click += (sender, e) =>
            {
                this.Visibility = CloseType;
            };

            Children = grid.Children;
            Content = stackPanel;
            CloseType = Visibility.Hidden;
        }
    }
}
