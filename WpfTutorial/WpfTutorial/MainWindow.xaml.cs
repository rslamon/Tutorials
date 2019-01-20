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
using Microsoft.Win32;

namespace WpfTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string usersName = "";

        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Hello World";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Title = e.GetPosition(this).ToString();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The App is closing");
            this.Close();
        }

        private void BtnOpenFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.ShowDialog();
        }

        private void BtnSaveFile_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog savDlg = new SaveFileDialog();
            savDlg.ShowDialog();
        }

        //private void SendButton_Click(object sender, RoutedEventArgs e)
        //{
        //    usersName = UsersName.Text;
        //    MessageBox.Show($"Hello {usersName}");
        //}


    }
}
