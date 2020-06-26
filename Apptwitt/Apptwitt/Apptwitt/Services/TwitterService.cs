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

        public Array GetTweets(string Tweet)
        {
            throw new NotImplementedException();
        }
    }
}
