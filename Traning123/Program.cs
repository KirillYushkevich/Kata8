using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Traning123
{
    class Program
    {
        static void Main(string[] args)
        {

            Kata.MyLanguages("#FF9933");
            Console.ReadKey();
        }
    }




    public static class Kata
    {
        public static List<int> MyLanguages(string s)
        {
            List<int> result = new List<int>();
            char[] arr = s.ToCharArray();
            string[] temp = new string[] { arr[1].ToString() + arr[2].ToString(), arr[3].ToString() + arr[4].ToString(), arr[5].ToString() + arr[6].ToString() };
            foreach (string str in temp)
            {
                result.Add(int.Parse(str, System.Globalization.NumberStyles.HexNumber));
            }
            return result;
        }
    }

}
