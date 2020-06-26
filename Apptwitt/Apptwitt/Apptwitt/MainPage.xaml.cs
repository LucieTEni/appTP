using Apptwitt.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace Apptwitt
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public TwitterService TService = new TwitterService();
        public MainPage()
        {
            InitializeComponent();
        }

        public void Connected_Clicked(object sender, EventArgs e)
        {
            Console.WriteLine("You're connected");
            Message.Text = ("");
            Message.IsVisible = false;
            Identifiant.Text = ("lulurouge2");
            Password.Text = ("1456lulu");
            if (TService.Authenticate(Identifiant.Text, Password.Text) == true)
            {
                Message.IsVisible = true;
                Message.Text = ("You're Connected !");
                BarreNotif.IsVisible = true;
                Tweets.IsVisible = true;
                Formulaire.IsVisible = false;
                this.ListTweet.ItemsSource = new TwitterService().GetTweets();
            }
            if (!TService.Authenticate(Identifiant.Text, Password.Text))
            {
                Console.WriteLine(Identifiant.Text);
                Message.IsVisible = true;
                Message.Text = ("Identifiant ou Mot de Passe Incorrect");
                BarreNotif.IsVisible = false;
                Tweets.IsVisible = false;
            };
            
            if (Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                Message.IsVisible = true;
                Message.Text = ("Veuilez vous connectez à internet");
            }
        }
    }
}
