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
    /// Логика взаимодействия для sushi_stor.xaml
    /// </summary>
    public partial class sushi_stor : Page
    {
        SUSHI_STORETableAdapter context = new SUSHI_STORETableAdapter();
        int kkc;
        public sushi_stor()
        {
            InitializeComponent();
            sushik_store.ItemsSource = context.GetData();
        }
        public sushi_stor(int kk)
        {
            InitializeComponent();
            sushik_store.ItemsSource = context.GetData();
            kkc = kk;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            object id = (sushik_store.SelectedItem as DataRowView).Row[0];
            context.DeleteQuery(Convert.ToInt32(id));
            sushik_store.ItemsSource = context.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            context.InsertQuery(text1.Text, Convert.ToInt32(text2.Text), Convert.ToInt32(text3.Text),Convert.ToInt32(text4.Text),text5.Text);
            sushik_store.ItemsSource = context.GetData();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var id = (sushik_store.SelectedItem as DataRowView).Row[0];
            context.UpdateQuery(text1.Text, Convert.ToInt32(text2.Text), Convert.ToInt32(text3.Text), Convert.ToInt32(text4.Text), text5.Text, Convert.ToInt32(id));
            sushik_store.ItemsSource = context.GetData();
        }

        private void ihgr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var das = (sushik_store.SelectedItem as DataRowView);
            if (das != null)
            {
                text1.Text = das.Row[1].ToString();
                text2.Text = das.Row[2].ToString();
                text3.Text = das.Row[3].ToString();
                text4.Text = das.Row[4].ToString();
                text5.Text = das.Row[5].ToString();
            }

        }
    }
}

