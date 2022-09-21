using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Example 1:");
		/*counts by ones*/
		for (int i = 0; i < 5; i++) 
		{
 	 		Console.WriteLine(i);
		}
		Console.WriteLine();
		Console.WriteLine("Example 2:");
		/*Counts by twos*/
		for (int i = 0; i <= 10; i = i + 2) 
		{
  			Console.WriteLine(i);
		}
		Console.WriteLine();
		Console.WriteLine("Example 3:");
		string[] animals = {"Cheeta", "Cat", "Dog", "Bull", "Dolphin"};
		foreach (string animal in animals) 
		{
  			Console.WriteLine(animal);
		}
	}
}
