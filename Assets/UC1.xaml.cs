#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows;
using System.Windows.Controls;
#endif

namespace KungFCollage
{
    /// <summary>
    /// UC1.xaml 的交互逻辑
    /// </summary>
    public partial class UC1 : UserControl
    {
        public UC1()
        {
            InitializeComponent();

            BT.Click += (sender, e) =>
            {
                this.Visibility = Visibility.Hidden;
            };
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }

        Button BT => FindName(nameof(BT)) as Button;
#endif
    }
}
