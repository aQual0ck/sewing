using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Логика взаимодействия для PageEditProduct.xaml
    /// </summary>
    public partial class PageEditProduct : Page
    {
        AuxClasses.Product realP;
        public PageEditProduct(object product)
        {
            InitializeComponent();
            DataContext = product;

            var id = TypeDescriptor.GetProperties(DataContext)["Id"].GetValue(DataContext);
            realP = AuxClasses.DBClass.entObj.Product.FirstOrDefault(x => x.Id == (int)id);
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string text = new TextRange(txbNotes.Document.ContentStart, txbNotes.Document.ContentEnd).Text;

            realP.ItemNumber = txbItemNumber.Text;
            realP.ProductName = txbProductName.Text;
            realP.Width = Convert.ToInt32(txbWidth.Text);
            realP.Length = Convert.ToInt32(txbLength.Text);
            realP.Notes = text;

            AuxClasses.DBClass.entObj.SaveChanges();
        }
    }
}
