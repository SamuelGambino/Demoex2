using Demoex2.AppDataFile;
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
using System.Windows.Threading;

namespace Demoex2.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
            var currentAgents = GromykoBD_2Entities.GetContext().Agent.ToList();
            LV.ItemsSource = currentAgents;
            

            //var currentHistory = GromykoBD_2Entities.GetContext().History_Sales.ToList();
            //LV.ItemsSource = currentHistory;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();
        }
        

        private void UpdateData(object sender, object e)
        {
           var holdrex =  GromykoBD_2Entities.GetContext().Agent.ToList();
           foreach (var abs in holdrex)
            {
                var Coldrex = abs.History_Sales1.Select(a => a.Count_Product);
                abs.Count = (int)Coldrex.Sum();
            }    
        }
    }
}
