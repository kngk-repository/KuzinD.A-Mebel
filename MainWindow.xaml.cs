﻿using System;
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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
         
        {
            InitializeComponent();
        //кнопка навигации
            MainFrame.Navigate(new ButtonsPage());
            manager.MainFrame= MainFrame;
            
        }

        private void Btn_Back(object sender, RoutedEventArgs e)
        {
            manager.MainFrame.GoBack();
        }
        
        private void MainFrame_ContentRendered(object sender, EventArgs e)
        //Кнопка Back исчезает на первой стрнице
        {
            if (MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}


