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
    /// Логика взаимодействия для PageProduct.xaml
    /// </summary>
    public partial class PageProduct : Page
    {
        public bool isEditable;
        public PageProduct(bool isAdmin)
        {
            InitializeComponent();
            dgrProduct.ItemsSource = AuxClasses.DBClass.entObj.Product.ToList();
            isEditable = isAdmin;
            MenuItem menuAdd = new MenuItem()
            {
                Header = "Добавить",
                Name = "menuAdd"
            };
            menuAdd.Click += menuAdd_Click;
            if (isEditable == true)
                menu.Items.Add(menuAdd);
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (isEditable == true) 
                AuxClasses.FrameClass.frmObj.Navigate(new PageEditProduct(dgrProduct.SelectedItem));
        }

        private void menuAdd_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.Navigate(new PageAddProduct());
        }
    }
}
