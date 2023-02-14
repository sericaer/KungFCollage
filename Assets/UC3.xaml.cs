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
    public partial class UC3 : UserControl
    {
        public UC3()
        {
            InitializeComponent();
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }
#endif
    }
}
