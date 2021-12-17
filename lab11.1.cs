using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
 
class Program
{
    static string _Replace(string str, int pos)
    {
        string _str = str.Substring(0, pos);
        for(int i = pos; i < str.Length; i++)
            _str += str[i] == '0' ? '1' : (str[i] == '1' ? '0' : str[i]);
        return _str;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(_Replace("101010101010", 3));
        Console.ReadKey(true);
    }
}