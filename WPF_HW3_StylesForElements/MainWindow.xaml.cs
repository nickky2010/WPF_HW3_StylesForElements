using System.Windows;
using System.Windows.Controls;

namespace WPF_HW3_StylesForElements
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Style buttonStyle = new Style();
            buttonStyle.Setters.Add(new Setter { Property = Control.FontSizeProperty, Value = 24.5 });
            buttonStyle.Setters.Add(new Setter { Property = Control.MarginProperty, Value = new Thickness(30) });
            buttonStyle.TargetType = typeof(Button);
            Resources.Add("buttonStyle", buttonStyle);
            buttonCalculate.Style = buttonStyle;
            buttonAuthor.Style = buttonStyle;
        }

        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            double height = double.Parse(textBoxHeight.Text.Replace('.',','));
            double width = double.Parse(textBoxWidth.Text.Replace('.', ','));
            textBoxSquare.Text = (height * width).ToString();
            textBoxPerimeter.Text = (height * 2 + width*2).ToString();
        }

        private void ButtonAuthor_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
