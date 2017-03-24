using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zad2.Core.Services
{
    public class IpValidator : IIpValidator
    {
        private const string Pattern = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";

        public bool Validate(string ip)
        {
            var regex = new Regex(Pattern);
            return regex.IsMatch(ip);
        }
    }
}