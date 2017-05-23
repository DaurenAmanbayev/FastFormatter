using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TextFastFormat.Extractor;

namespace TextFastFormat.Editor
{
    public class TextWorker
    {       
        //вариант парсинга путем регулярных выражений
        public static string[] ExtractLines(string input)
        {
            return Regex.Split(input, "\r\n");
        }

        //генерация текста делается вставка для каждой строки с обеих сторон
        //к примеру, имеется список переменных, которые требуется поместить в кавычки 'variable'
        public static string GenerateBrackets(string input, string startBracket, string endBracket)
        {
            List<string> Lines = ExtractLines(input).ToList();
            StringBuilder builder = new StringBuilder();

            foreach (string line in Lines)
            {
                builder.AppendLine(startBracket + line + endBracket);
            }
            return builder.ToString();
        }
        public static string GenerateContent(ICollection<string> lines, string separator)
        {
            //"\r\n"
            return string.Join(separator, lines);
        }

        public static string Replace(string input, string oldString, string newString)
        {
            return input.Replace(oldString, newString);
        }
        public static string Remove(string input, string removePattern)
        {
            var indexes = RegexWorker.Singletone.ExtractSubstringInfo(input, removePattern);

            foreach (var index in indexes)
            {
                input=input.Remove(index.Index, index.Length);
            }
            return input;
        }
        public static string TrimByLine(string input, string chars)
        {
            string[] lines = ExtractLines(input);
            StringBuilder builder = new StringBuilder();
            foreach (var line in lines)
            {
                builder.AppendLine(TrimChars(line, chars));
            }
            return builder.ToString();
        }
        public static string FormatByLine(string input, string format)
        {
            string[] lines = ExtractLines(input);
            StringBuilder builder = new StringBuilder();
            foreach (var line in lines)
            {
                builder.AppendLine(string.Format(format, line));
            }
            return builder.ToString();
        }

        public static string TrimChars(string input, string chars)
        {
            foreach (char ch in chars)
            {
                input.Trim(ch);
            }
            return input;
        }       

    }
}
