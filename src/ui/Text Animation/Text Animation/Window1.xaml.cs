using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace Text_Animation
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(Window1_Loaded);
        }

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {
            TranslateAnimation(text1, 10);
            TranslateAnimation(text2, 5);
        }

        private void TranslateAnimation(TextBlock text, double time)
        {
            double right = 0;
            FrameworkElement parent = text.Parent as FrameworkElement;

            // 텍스트의 길이가 부모 패널을 넘어갈 때 
            if (text.ActualWidth > parent.ActualWidth)
            {
                right = text.ActualWidth - parent.ActualWidth;
            }

            // 부모 패널이 Grid라면 Margin 값 변경
            // 텍스트가 잘리는 현상 방지
            if (parent is Grid)
            {
                text.Margin = new Thickness(0, 0, -right, 0);
            }

            // TranslateTransform을 생성해야 애니메이션 적용
            text.RenderTransform = new TranslateTransform();

            Storyboard story = new Storyboard();

            DoubleAnimation animation = new DoubleAnimation();

            animation.From = parent.ActualWidth;
            animation.To = -(parent.ActualWidth + right);
            animation.Duration = TimeSpan.FromSeconds(time);
            animation.RepeatBehavior = RepeatBehavior.Forever;

            // TranslateTransform.XProperty 값 설정
            DependencyProperty[] Dproperty = new DependencyProperty[]
            {
                TextBlock.RenderTransformProperty,
                TranslateTransform.XProperty
            };

            string path = "(0).(1)";

            Storyboard.SetTargetProperty(animation, new PropertyPath(path, Dproperty));
            story.Children.Add(animation);
            story.Begin(text);
        }
    }
}
