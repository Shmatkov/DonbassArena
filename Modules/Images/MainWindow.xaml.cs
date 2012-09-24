using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Modules
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            String s = textBox1.Text;
            String s2 = s.Trim('*', '.');
            textBox2.Text = s2;
            
        }

        private void seatN_MouseEnter(object sender, MouseEventArgs e)
        {
            Brush brush = Brushes.Bisque;
            Path p = (Path)sender;
            p.Fill = brush;
            p.Stroke = Brushes.CadetBlue;
        }

        private void seatN_MouseLeave(object sender, MouseEventArgs e)
        {
            Brush brush = Brushes.White;
            Path p = (Path)sender;
            p.Fill = brush;
        }

        private void colorPicker1_SelectedColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            textBox1.Text = e.NewValue.ToString();
        }
    }
}
