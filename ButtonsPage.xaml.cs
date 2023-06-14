using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorldOfDivanXD
{
    /// <summary>
    /// Логика взаимодействия для ButtonsPage.xaml
    /// </summary>
    public partial class ButtonsPage : Page
    {
        public ButtonsPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            manager.MainFrame.Navigate(new MebelPage());
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            manager.MainFrame.Navigate(new TovarsPage());
        }
    }
}
