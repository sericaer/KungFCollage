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
    public class UC2 : UserControl
    {
        public UIElementCollection Children { get; set; }

        public UC2()
        {
            //Grid grid = new Grid();

            ////ContentPresenter content = new ContentPresenter();
            ////content.Content = Content;

            ////grid.Children.Add(content);

            //var stackPanel = new StackPanel() { Orientation = Orientation.Horizontal };
            //grid.Children.Add(stackPanel);

            //var subGrid = new Grid();
            //stackPanel.Children.Add(subGrid);

            //var button = new Button() { Content = "X", Width = 30, Height = 30, VerticalAlignment = VerticalAlignment.Top };
            //stackPanel.Children.Add(button);

            //button.Click += (sender, e) =>
            //{
            //    this.Visibility = Visibility.Hidden;
            //};

            //Children = subGrid.Children;

            //Content = grid;

            var dock = new DockPanel();

            var button = new Button() { Content = "X", Width = 30, Height = 30, VerticalAlignment = VerticalAlignment.Top, HorizontalAlignment = HorizontalAlignment.Right };
            dock.Children.Add(button);

            button.Click += (sender, e) =>
            {
                this.Visibility = Visibility.Hidden;
            };

            Children = dock.Children;

            Content = dock;
        }
    }
}
