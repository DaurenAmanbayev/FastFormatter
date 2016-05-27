using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FastFormatter
{
    class TextWorker
    {
        //парсит строки из текста
        public List<string> ExtractLine(string input)
        {
            List<string> Lines = new List<string>();
            string pattern = "\r\n";
            int prev = 0, next = 0;
            int last = input.LastIndexOf(pattern) + pattern.Length;//step of pattern
            int size = input.Length;
            bool stop = true;
            while (stop)
            {
                next = input.IndexOf(pattern, prev);//находим требуемый индекс
                if (next > prev)//если следующий индекс больше, чем предыдущий 
                {
                    Lines.Add(input.Substring(prev, next - prev));//добавить отрезок строки между индексами
                    prev = next + pattern.Length;
                }
                else//если следующий индекс меньше, чем предыдущий 
                {
                    if (last < size)//проверяем, что индекс последнего совпадения меньше чем размер текста
                    {
                        Lines.Add(input.Substring(last, size - last));//добавляем конец строки в наш перечень
                    }
                    break;
                }
            }
            return Lines;
        }
        //вариант парсинга путем регулярных выражений
        public string[] ExtractLines(string input)
        {
            return Regex.Split(input, "\r\n");
        }
        //генерация текста делается вставка для каждой строки с обеих сторон
        //к примеру, имеется список переменных, которые требуется поместить в кавычки 'variable'
        public string GenerateBrackets(string input, string prevPattern, string endPattern)
        {
            List<string> Lines = ExtractLines(input).ToList();
            StringBuilder builder = new StringBuilder();         
           
            foreach (string line in Lines)
            {
               builder.AppendLine(prevPattern + line + endPattern);
            }
            return builder.ToString(); 
        }

        //public string GenerateScript(string input, List<string> patterns, Hashtable data)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    foreach (string key in patterns.Keys)
        //    {

        //        string value=patterns[key].ToString();
        //        input.Replace(key, value);
        //    }
        //}
    }
}
