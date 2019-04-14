using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF_HW3_StylesForElements
{
    public class Rectangle : DependencyObject
    {
        public double Square { get; set; }
        public double Perimeter { get; set; }

        public static readonly DependencyProperty widthProperty;
        public static readonly DependencyProperty heightProperty;

        static Rectangle()
        {
            widthProperty = DependencyProperty.Register("Width", typeof(double), typeof(Rectangle));
            heightProperty = DependencyProperty.Register("Height", typeof(double), typeof(Rectangle));

        }
        public string Name { get; set; }
        public double Width
        {
            get
            {
                return (double)GetValue(widthProperty);
            }
            set
            {
                SetValue(widthProperty, value);
            }
        }
        public double Height
        {
            get
            {
                return (double)GetValue(heightProperty);
            }
            set
            {
                SetValue(heightProperty, value);
            }
        }

    }
}
