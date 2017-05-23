using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFastFormat.Extractor
{
   public class RegexWorker
    {
        #region SINGLETONE
        private RegexWorker() { }
        //Singletone pattern
        private static RegexWorker _singletone;
        public static RegexWorker Singletone
        {
            get
            {
                if (_singletone == null)
                    _singletone = new RegexWorker();
                return _singletone;
            }
        }
        #endregion

        //replace pattern
        public string ReplacePattern(string input, string pattern, string replacement)
        {
            return Regex.Replace(input, pattern, replacement);
        }
        //extract list of address from text
        public List<IPAddress> ExtractIpAddress(string input)
        {          
            Regex regexIp = new Regex(PatternBrowser.IpAddress);
            MatchCollection result = regexIp.Matches(input);
            List<IPAddress> list = new List<IPAddress>();
            IPAddress host;
            foreach (Match match in result)
            {
                string strAddress = match.ToString();
                if (IPAddress.TryParse(strAddress, out host))
                {
                    list.Add(host);
                }
            }
            return list;
        }      
        //list of matches by pattern
        public List<string> SeparatorMatches(string input, string pattern)
        {
            var list = new List<string>();
            Regex reg = new Regex(pattern);
            var matches= reg.Matches(input);

            foreach (var match in matches)
            {
                list.Add(match.ToString());
            }

            return list;
        }
        //return index and string length from text by pattern
        public List<SubstringIndex> ExtractSubstringInfo(string input, string pattern)
        {
            MatchCollection result = Regex.Matches(input, pattern, RegexOptions.IgnoreCase);
            List<SubstringIndex> list = new List<SubstringIndex>();
            foreach (Match match in result)
            {
                SubstringIndex info = new SubstringIndex();
                info.Index = match.Index;
                info.Length = match.Length;
                list.Add(info);
            }
            return list;
        }
        public static string Replace(string input, string pattern, string replace)
        {
           return Regex.Replace(input, pattern, replace);
        }
    }
}
