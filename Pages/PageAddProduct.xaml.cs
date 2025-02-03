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
    /// Логика взаимодействия для PageAddProduct.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {
        private AuxClasses.Product product;
        public PageAddProduct()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            product = new AuxClasses.Product()
            {
                ItemNumber = txbItemNumber.ToString(),
                ProductName = txbProductName.ToString(),
                Width = Convert.ToDouble(txbWidth.Text),
                Length = Convert.ToDouble(txbLength.Text),
                Notes = txbNotes.ToString()
            };
            AuxClasses.DBClass.entObj.Product.Add(product);
            AuxClasses.DBClass.entObj.SaveChanges();
        }
    }
}
