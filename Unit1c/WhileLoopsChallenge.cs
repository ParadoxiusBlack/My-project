using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("How long shall I repeat?");
		int length = Convert.ToInt32(Console.ReadLine());
		int i = 0;
		while (i < length) {
			int o = i+1;
			Console.WriteLine("I have repeated this " + o + " times.");
			i ++;
		}
	}
}
