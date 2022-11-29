using Demoex2.Pages;
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

namespace Demoex2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrmMain.Navigate(new PageMain());
        }

        private void PasswordUser_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PasswordUser.Text == "0000")
            {
                userName.Text = "Менеджер";
            }
            else 
            {
                userName.Text = "Пользователь";
            }
        }
    }
}
