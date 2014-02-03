using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTests
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"Branch ship.client.main.w5m2 2011/10/25 01:09:28 'Created by CreateBranch script for REDMOND\BTSA010 '";
            string pattern = "Branch (.+?) (.*)";
            Match match = Regex.Match(input, pattern);
            //while (match.Success)
            {
                Console.WriteLine( match.Groups[0].Value);
                Console.WriteLine(match.Groups[1].Value);
                Console.WriteLine(match.Groups[2].Value);
                Console.WriteLine(match.Groups.Count);
            }
            Console.ReadLine();
        }
    }
}
