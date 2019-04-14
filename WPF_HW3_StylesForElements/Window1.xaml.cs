using System.Windows;
using System.Windows.Media;

namespace WPF_HW3_StylesForElements
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            ImageSourceConverter converter = new ImageSourceConverter();
            ImageSource imageSource = (ImageSource)converter.ConvertFromString(System.IO.Path.GetFullPath("..\\..\\1.jpg"));
            imagePhoto.Source = imageSource;
            imagePhoto.Width = 300;
            imagePhoto.Height = 300;
        }
    }
}
