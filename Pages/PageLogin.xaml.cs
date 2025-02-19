﻿using System;
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
using System.Windows.Threading;
using System.Diagnostics;

namespace sewing.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txbLogin.Text != "" && psbPassword.Password != "")
                {
                    var userObj = AuxClasses.DBClass.entObj.Users.FirstOrDefault(x => x.Username == txbLogin.Text && x.Password == psbPassword.Password);
                    if (userObj == null)
                    {
                        tbWarning.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        switch (userObj.RoleId)
                        {
                            case 1:
                                AuxClasses.FrameClass.frmObj.Navigate(new PageAdmin());
                                break;
                            case 2:
                                AuxClasses.FrameClass.frmObj.Navigate(new PageStorage());
                                break;
                            case 3:
                                AuxClasses.FrameClass.frmObj.Navigate(new PageManagement());
                                break;
                            case 4:
                                AuxClasses.FrameClass.frmObj.Navigate(new PageClient());
                                break;
                        }
                    }
                }
                else
                {
                    tbNoText.Visibility = Visibility.Visible;
                    var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(5) };
                    timer.Start();
                    timer.Tick += (sender1, args) =>
                    {
                        timer.Stop();
                        tbNoText.Visibility = Visibility.Visible;
                    };
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message.ToString(), "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
