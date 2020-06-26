using System;
using System.Collections.Generic;
using System.Text;

namespace Apptwitt
{
    public class Tweets
    {
        private string id;
        public string Pseudo { get; set; }
        private string identifiant;
        private string nameUser;
        public string Texte { get; set; }
        public string DateCreation { get; set; }

        public string Id { get => id; set => id = value; }
        public string Identifiant { get => identifiant; set => identifiant = value; }
        public string NameUser { get => nameUser; set => nameUser = value; }

        public Tweets(string pseudo, string texte, string dateCreation)
        {
            Pseudo = pseudo;
            Texte = texte;
            DateCreation = dateCreation;
        }
    }
}
