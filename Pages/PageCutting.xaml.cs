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
    /// Логика взаимодействия для PageCutting.xaml
    /// </summary>
    public partial class PageCutting : Page
    {
        public PageCutting()
        {
            InitializeComponent();
            var fabric = AuxClasses.DBClass.entObj.Fabric.FirstOrDefault(x => x.Id == 3);
            Rectangle rect1 = new Rectangle();
            if (fabric.Width < 1000 && fabric.Length < 1000)
            {
                rect1.Width = fabric.Width;
                rect1.Height = (double)fabric.Length;
            }
            else
            {
                rect1.Width = fabric.Width / 10;
                rect1.Height = (double)fabric.Length / 10;
            }
            rect1.Stroke = Brushes.Black;
            cnvDraw.Children.Add(rect1);
        }

        private void menuBack_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.FrameClass.frmObj.GoBack();
        }
    }
}
