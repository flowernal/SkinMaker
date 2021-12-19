﻿using System;
using System.Collections.Generic;
using System.IO;
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

namespace SkinMaker
{
    /// <summary>
    /// Interakční logika pro MainContent.xaml
    /// </summary>
    public partial class MainContent : UserControl
    {
        MainWindow mw;

        public MainContent(MainWindow recievedWindow)
        {
            mw = recievedWindow;
            InitializeComponent();
        }

        private void NewSkin_Click(object sender, RoutedEventArgs e)
        {
            mw.contentControl.Content = new NewSkinContent(mw);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Options_Click(object sender, RoutedEventArgs e)
        {
            mw.contentControl.Content = new OptionsContent(mw);
        }
    }
}
