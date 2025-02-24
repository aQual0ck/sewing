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
using System.ComponentModel;

namespace sewing.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEditFabric.xaml
    /// </summary>
    public partial class PageEditFabric : Page
    {
        AuxClasses.Fabric realF;
        public PageEditFabric(object fabric)
        {
            InitializeComponent();
            DataContext = fabric;

            var id = TypeDescriptor.GetProperties(DataContext)["Id"].GetValue(DataContext);
            realF = AuxClasses.DBClass.entObj.Fabric.FirstOrDefault(x => x.Id == (int)id);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuBack_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }

        private void menuCutting_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageCutting());
        }
    }
}
