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
using WpfApp3.PRAKT2DataSetTableAdapters;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для ingrid.xaml
    /// </summary>
    public partial class ingrid : Page
    {

        INGREDIENTSTableAdapter context = new INGREDIENTSTableAdapter(); 
        public ingrid()
        {
            InitializeComponent();
            ihgr.ItemsSource = context.GetData();
        }

        
    }
}
