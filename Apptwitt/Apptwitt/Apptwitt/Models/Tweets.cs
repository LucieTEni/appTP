using System;
using System.Collections.Generic;
using System.Text;

namespace Apptwitt
{
    public class Tweets
    {
        private string id;
        public string Pseudo;
        private string identifiant;
        private string nameUser;
        public string Texte;
        public string DateCreation;

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
