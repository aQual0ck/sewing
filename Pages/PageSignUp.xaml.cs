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
    /// Логика взаимодействия для PageSignUp.xaml
    /// </summary>
    public partial class PageSignUp : Page
    {
        public PageSignUp()
        {
            InitializeComponent();
        }

        private void psbPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            int pswdstr = UserRegistration.PasswordStrengthChecker.GetPasswordStrength(psbPassword.Password);

            if (!string.IsNullOrEmpty(psbPassword.Password))
            {
                tbPasswordStr1.Visibility = Visibility.Visible;
                tbPasswordStr2.Visibility = Visibility.Visible;

                if (pswdstr <= 1 || pswdstr == 2)
                {
                    tbPasswordStr2.Text = "Слабый";
                }
                else if (pswdstr == 3 || pswdstr == 4)
                {
                    tbPasswordStr2.Text = "Средний";
                }
                else
                {
                    tbPasswordStr2.Text = "Сильный";
                }
            }
            else
            {
                tbPasswordStr1.Visibility = Visibility.Hidden;
                tbPasswordStr2.Visibility = Visibility.Hidden;
            }
        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {
            AuxClasses.Users user = new AuxClasses.Users()
            {
                Username = txbLogin.Text,
                Password = psbPassword.Password,
                RoleId = 4,
                FullName = txbFullName.Text
            };
            AuxClasses.DBClass.entObj.Users.Add(user);
            AuxClasses.DBClass.entObj.SaveChanges();
        }
    }
}
