using System;
using System.Collections.Generic;
using System.Text;

namespace Apptwitt.Services
{
    public interface ITwitterService
    {
        bool Authenticate(string User, string password);
        Array GetTweets(string Tweet);
    }
}
