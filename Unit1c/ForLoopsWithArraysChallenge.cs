using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("I shall repeat this for your input number of times");
		int length = Convert.ToInt32(Console.ReadLine());
		for (int i = 0; i < length; i ++) {
			int o = i+1;
			Console.WriteLine("This is repetition number " + o);
		}
	}
}
