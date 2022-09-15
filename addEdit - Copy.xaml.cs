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
using System.Windows.Shapes;

namespace SQLLoginPrompt
{
    /// <summary>
    /// Interaction logic for addEdit.xaml
    /// </summary>
    public partial class addEdit : Window
    {
        public addEdit()
        {
            InitializeComponent();
        }

        private void BtMinimaze(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtClose(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Move(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
