using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp3.PRAKT3DataSetTableAdapters;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для sushi.xaml
    /// </summary>
    public partial class sushi : Page
    {
        SUSHITableAdapter context = new SUSHITableAdapter();
        int kkc = 0;
        public sushi(int kk)
        {
            InitializeComponent();
            sudhik.ItemsSource = context.GetData();
            kkc = kk;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object id = (sudhik.SelectedItem as DataRowView).Row[0];
            context.DeleteQuery(Convert.ToInt32(id));
            sudhik.ItemsSource = context.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            context.InsertQuery(text1.Text, Convert.ToDecimal(text2.Text), text3.Text);
            sudhik.ItemsSource = context.GetData();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var id = (sudhik.SelectedItem as DataRowView).Row[0];
            context.UpdateQuery(text1.Text, Convert.ToDecimal(text2.Text), text3.Text, Convert.ToInt32(id));
            sudhik.ItemsSource = context.GetData();
        }

        private void ihgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var das = (sudhik.SelectedItem as DataRowView);
            if (das != null)
            {
                text1.Text = das.Row[1].ToString();
                text2.Text = das.Row[2].ToString();
                text3.Text = das.Row[3].ToString();
            }

        }


    }
}
