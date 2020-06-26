using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Apptwitt
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void Connected_Clicked(Object sender, EventArgs e)
        {
            Console.WriteLine("You're connected");
            String Identifiantmess = this.Message.Text;
            String PassWord = this.Password.Text;
            this.Message.Text = ("");
            this.Message.IsVisible = false;
            if (this.Identifiant.Text == null || this.Password.Text == null)
            {
                this.Message.Text = ("Aucun champ ne doit être vide");
                this.Message.IsVisible = true;
            }
            else if (this.Identifiant.Text.Length < 3 || this.Password.Text.Length < 6)
            {
                this.Message.Text = ("Le Mot de passe ou l'identifiant est incorrect");
                this.Message.IsVisible = true;
            }
            else
            {
                this.BarreNotif.IsVisible = true;
                this.Tweets.IsVisible = true;
                this.Formulaire.IsVisible = false;
            };
        }
    }
}
