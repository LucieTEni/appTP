using System;
using System.Collections.Generic;
using System.Text;

namespace Apptwitt.Services
{
    public class TwitterService : ITwitterService
    {
        public bool Authenticate(string User, string password)
        {
            if (User.Equals("lulurouge2") &&  password.Equals("1456lulu"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Tweets> GetTweets(string Tweet)
        {
            List<Tweets> tweets = new List<Tweets>();
            tweets.Add(new Tweets("lulurouge", "pouloulou", "28-05-2020"));
            tweets.Add(new Tweets("lulurouge", "pouloulou", "28-05-2020"));
            tweets.Add(new Tweets("lulurouge", "pouloulou", "28-05-2020"));

            return tweets;
        }
    }
}
