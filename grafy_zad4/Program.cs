using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace grafy_zad4
{
    class Program
    {
        public static void SearchFromBack(string source) //podziel stringa na pol, a nastepnie stosunkowo zmniejszaj polowe
        {
            bool condition = false;
            int i = 0;
            while (!condition)
            {
                string suffix; //x
                string prefix;

                prefix = source.Substring(0, (source.Length / 2) - i);
                suffix = source.Substring(prefix.Length);

                i++;
                if (suffix.StartsWith(prefix) && prefix.Length != 0)
                {
                    Console.WriteLine("Odpowiedz: {0}", (prefix.Length) * 2);
                    break;
                }
                else if (prefix.Length == 0)
                {
                    Console.WriteLine("Nie znalezniono odpowiedzi");
                    break;
                }
                i++;
            }
        }
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            bool longestPrefixFound = false;
            int i = 0;
            string prefix = "";
            string suffix = "";
            int currentPrefixLength = 0;
            int previousPrefixLength = 0;
            int minimalGuaranteedPrefixLength = 0;
            int tmp = 0;
            bool minimalGuaranteedPrefixLengthChanged = false;
            Console.Write("Input: ");
            string source = Console.ReadLine();
            stopWatch.Start();
            SearchFromBack(source);
            
            //while (!longestPrefixFound)
            //{
            //    if (i == 0)
            //    {
            //        currentPrefixLength = source.Length / 2;
            //        prefix = source.Substring(0, currentPrefixLength);
            //        suffix = source.Substring(prefix.Length);
            //        if (suffix.StartsWith(prefix) && prefix.Length != 0)
            //        {
            //            Console.WriteLine("Odpowiedz: {0}, ilosc iteracji: {1}", (prefix.Length) * 2, i);
            //            stopWatch.Stop();
            //            break;
            //        }
            //        else
            //        {
            //            i++;
            //        }
            //        Console.WriteLine("prefix: {0}, current prefix length {1}, previous prefix length {2}, tmp{3}", prefix, currentPrefixLength, previousPrefixLength, tmp);
            //    }
            //    else if (!minimalGuaranteedPrefixLengthChanged || tmp == previousPrefixLength)
            //    {
            //        previousPrefixLength = currentPrefixLength;
            //        currentPrefixLength /= 2;
            //        prefix = source.Substring(0, currentPrefixLength);
            //        suffix = source.Substring(prefix.Length);
            //        if (suffix.StartsWith(prefix))
            //        {
            //            if (Regex.Matches(suffix, prefix).Count > 1)
            //            {

            //            }
            //            //Console.WriteLine("Odpowiedz: {0}, ilosc iteracji: {1}, prefix: {2}", (prefix.Length) * 2, i);
            //            //stopWatch.Stop();
            //            //break;
            //        }
            //        else if (suffix.Contains(prefix))
            //        {
            //            minimalGuaranteedPrefixLengthChanged = true;
            //            i++;
            //        }
            //        else
            //        {
            //            i++;
            //        }
            //        Console.WriteLine("prefix: {0}, current prefix length {1}, previous prefix length {2}, tmp {3}", prefix, currentPrefixLength, previousPrefixLength, tmp);
            //    }
            //    else if (minimalGuaranteedPrefixLengthChanged)
            //    {
            //        currentPrefixLength += (previousPrefixLength - currentPrefixLength) / 2;
            //        prefix = source.Substring(0, currentPrefixLength);
            //        suffix = source.Substring(prefix.Length);
            //        if (suffix.StartsWith(prefix))
            //        {
            //            Console.WriteLine("Odpowiedz: {0}, ilosc iteracji: {1}, prefix: {2}", (prefix.Length) * 2, i, prefix);
            //            stopWatch.Stop();
            //            break;
            //        }
            //        else if (suffix.Contains(prefix))
            //        {
            //            i++;
            //        }
            //        else
            //        {
            //            tmp = currentPrefixLength;
            //            previousPrefixLength = currentPrefixLength;
            //            currentPrefixLength = minimalGuaranteedPrefixLength; i++;
            //        }
            //        Console.WriteLine("prefix: {0}, current prefix length {1}, previous prefix length {2}, tmp {3}", prefix, currentPrefixLength, previousPrefixLength, tmp);
            //    }
            //    else if (prefix.Length == 1)
            //    {
            //        if (source[0] == source[1])
            //        {
            //            Console.WriteLine("Odpowiedz: 2");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Brak najdluzszego prefixu");
            //        }
            //    }
            //}
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:000}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
