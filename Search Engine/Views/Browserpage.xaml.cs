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
namespace SearchEngine
{
    public partial class PhonePage4 : PhoneApplicationPage
    {
        public PhonePage4()
        {
            InitializeComponent();
        }

        private void Mytextbox1_Loaded(object sender, RoutedEventArgs e)
        {
            Mytextbox1.Text = String.Format("{0}",NavigationContext.QueryString["id"]); 
        }


        private void Mygo1_Click(object sender, RoutedEventArgs e)
        {
            string site;
            if (Mytextbox1.Text=="Audio_name")
            {
                
                site = "https://www.bing.com/search?q=filetype%3Amp3+"+Textbox2.Text;
                Myweb1.Navigate(new Uri(site, UriKind.Absolute));
            }
            else if(Mytextbox1.Text=="Video_name")
            {

                site = "https://www.youtube.com/results?search_query=" + Textbox2.Text;
              Myweb1.Navigate(new Uri(site, UriKind.Absolute));
            }
            else if (Mytextbox1.Text=="Image_name")
            {
                site = "https://www.bing.com/images/search?q="+Textbox2.Text;
                Myweb1.Navigate(new Uri(site, UriKind.Absolute));
            }
            else if (Mytextbox1.Text == "PDF_name")
            {
                site = "https://www.bing.com/search?q=filetype%3Apdf+" + Textbox2.Text;
                Myweb1.Navigate(new Uri(site, UriKind.Absolute));
            }
            else if (Mytextbox1.Text == "DOC_name")
            {
                site = "https://www.bing.com/search?q=filetype%3Adoc+" + Textbox2.Text;
                Myweb1.Navigate(new Uri(site, UriKind.Absolute));
            }
            else if (Mytextbox1.Text == "PPT_name")
            {
                site = "https://www.bing.com/search?q=filetype%3Appt+" + Textbox2.Text;
                Myweb1.Navigate(new Uri(site, UriKind.Absolute));
            }
            else if (Mytextbox1.Text == "XLS_name")
            {
                site = "https://www.bing.com/search?q=filetype%3Axls+" + Textbox2.Text;
                Myweb1.Navigate(new Uri(site, UriKind.Absolute));
            }
            else if (Mytextbox1.Text == "Place1 to Place2")
            {
                site = "https://www.bing.com/maps/?q=" + Textbox2.Text;
                Myweb1.Navigate(new Uri(site, UriKind.Absolute));
            }

            else if (Mytextbox1.Text == "Enter_place.")
            {
                site = "https://www.bing.com/maps/?q=restaurant%20in%20" + Textbox2.Text;
                Myweb1.Navigate(new Uri(site, UriKind.Absolute));

            }
            else if (Mytextbox1.Text == "Enter_place..")
            {
                site = "https://www.bing.com/maps/?q=Tourist%20place%20in%20" + Textbox2.Text;
                Myweb1.Navigate(new Uri(site, UriKind.Absolute));

            }
            else if (Mytextbox1.Text == "Enter_place...")
            {
                //string Myvalue = "Entre place";
                //Textbox2.Text = Myvalue;

                site = "https://www.bing.com/maps/?q=Market%20place%20in%20" + Textbox2.Text;
                Myweb1.Navigate(new Uri(site, UriKind.Absolute));

            }

        }

        private void Textbox2_Loaded(object sender, RoutedEventArgs e)
        {
    
           Textbox2.Text = String.Format("{0}", NavigationContext.QueryString["id"]);

              
        }
    }  
}
