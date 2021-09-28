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

namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void TextoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            CaracteresTextBlock.Text = $"{TextoTextBox.Text.Length.ToString()} / 140";

            if (TextoTextBox.Text.Length >= 140)
                TextoTextBox.IsReadOnly = true;
        }
    }
}
