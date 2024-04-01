using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using WpfApp3.PRAKT3DataSetTableAdapters;


namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int kk = 4;
        object id = "d";
        public MainWindow()
        {
            InitializeComponent();
            kk = 0;
            datagrids.Content = new sushi_stor();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            kk = 1;
            datagrids.Content = new ingrid(kk);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            kk = 2;
            datagrids.Content = new sushi_stor();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            kk = 0;
            datagrids.Content = new sushi(kk);
            
        }


    }
}
