using System;
					
public class Program
{
	public static void Main()
	{
		int[] numbers = {50, 34, 2, 190, 354, 45, 5, 78, 2, 5, 78, 976, 23};
		var number = numbers.Length;
		for (int i = 0; i < number; i++)
		{
			Console.WriteLine(numbers[i]);
		}
	}
}
