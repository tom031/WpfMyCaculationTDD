﻿using SimpleCaculation;
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

namespace WpfMyCaculationTDD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _addButton_Click(object sender, RoutedEventArgs e)
        {
            int first = int.Parse(this._firstTextBox.Text);
            int second = int.Parse(this._secondTextBox.Text);

            var total = new Calculator();

            var result = total.Add(first, second);

            this._totalTextBlock.Text = result.ToString();
        }
    }
}
