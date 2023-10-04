using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2709prac
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Popup[] popups;
        public MainWindow()
        {
            InitializeComponent();
            popups = new Popup[] { PP1, PP2 };
        }

        private void OnClick(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < popups.Length; i++)
            {
                popups[i].IsOpen = false;
            }
        }

        private void OnMouseEnterText(object sender, MouseEventArgs e)
        {
            PP1.IsOpen = true;
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            PP2.IsOpen = true;
        }
    }
}
