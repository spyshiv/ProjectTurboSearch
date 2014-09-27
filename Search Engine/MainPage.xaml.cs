using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Threading;
using Microsoft.Phone.Tasks;


namespace SearchEngine
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            Thread.Sleep(1000);
        }

        private void Myrate_Click(object sender, RoutedEventArgs e)
        {
            MarketplaceSearchTask marketplaceSearchTask = new MarketplaceSearchTask(); 
	        marketplaceSearchTask.ContentType = MarketplaceContentType.Applications; 
	        marketplaceSearchTask.SearchTerms = "Turbo Search"; 
	        marketplaceSearchTask.Show();

        }
    }
}