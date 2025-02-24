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

namespace sewing.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageFabric.xaml
    /// </summary>
    public partial class PageFabric : Page
    {
        bool isEditable;
        public PageFabric(bool isNotClient)
        {
            InitializeComponent();
            isEditable = isNotClient;
            dgrFabric.ItemsSource = AuxClasses.DBClass.entObj.Fabric.ToList();
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (isEditable)
                AuxClasses.FrameClass.frmObj.Navigate(new PageEditFabric(dgrFabric.SelectedItem));
        }
    }
}
