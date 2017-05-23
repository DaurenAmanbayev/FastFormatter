using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFastFormat.Extractor
{
    public class PatternBrowser
    {
        Dictionary<string, Pattern> patterns = new Dictionary<string, Pattern>();
        
        public string LastPattern { get; set; }
        public string Location { get; set; }

        public void AddPattern(Pattern pattern)
        {
            if (!patterns.ContainsKey(pattern.Name))
            {
                patterns.Add(pattern.Name, pattern);
            }
            else
            {
                patterns.Remove(pattern.Name);
                patterns.Add(pattern.Name, pattern);
            }
        }
        public void RemovePattern(string name)
        {
            patterns.Remove(name);
        }
        public Pattern GetPattern(string name)
        {
            if (patterns.ContainsKey(name))
            {
                return patterns[name];
            }
            else
                return string.Empty;
        }
        public List<string> GetPatternNamesList()
        {
            return patterns.Keys.ToList();
        }
        public List<Pattern> GetPatternList()
        {
            return patterns.Values.ToList();
        }
        public void Save(string filename)
        {
            List<Pattern> collection = patterns.Values.ToList();
            Helper.SaveXml(filename, collection);
                
        }
        public void Read(string filename)
        {
            var collection = Helper.ReadXml<List<Pattern>>(filename);

            foreach (var pattern in collection)
            {
                AddPattern(pattern);
            }
        }
        public Dictionary<string, Pattern> Content()
        {
            return patterns;
        }
        #region STATIC
        public static readonly string IpAddress = @"\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}";
        public static readonly string Mail = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
               @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        public static readonly string Community = @"(\S){1,}";
        public static readonly string OidKey= @"(\d+\.){1,}\d";
        #endregion
    }
}
