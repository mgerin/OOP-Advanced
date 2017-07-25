namespace _04.Telephony.Entities
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    using _04.Telephony.Entities.Interfaces;

    public class Smartphone : ICall, IBrowse
    {
        public void Call(string number)
        {
            Console.WriteLine(!ValidCallNumber(number)
                                  ? "Invalid number!"
                                  : $"Calling... {number}");
        }

        public void Browse(string url)
        {
            Console.WriteLine(!ValidUrlAddress(url)
                                  ? "Invalid URL!"
                                  : $"Browsing: {url}!");
        }

        private static bool ValidCallNumber(string callNumber)
        {
            return Regex.IsMatch(callNumber, "^\\d+$");
        }

        private static bool ValidUrlAddress(string urlAddress)
        {
            bool containsDigit = Regex.IsMatch(urlAddress, "\\d");
            return !containsDigit;
        }
    }
}
