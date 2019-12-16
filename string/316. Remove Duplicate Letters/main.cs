using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program
{
	public static string RemoveDuplicateLetters(string s) {
        Dictionary<char, int> dictionarys = s.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
		var abc = dictionarys.Keys.OrderBy(x => x);
		foreach(var i in abc)
			Console.Write(i);
		return abc.ToString();
    }
	
	public static void Main()
	{
		string s = "bcabc";
		RemoveDuplicateLetters(s);
	}
}
