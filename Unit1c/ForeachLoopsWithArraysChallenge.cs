using System;
					
public class Program
{
	
	public static void Main()
	{
		string[] inventory = {"Sword", "Steak", "Jar of Dirt", "Stack of Money", "Phone", "Pencil"};
		int i = 0;
		foreach (string item in inventory){
			i ++;
			Console.WriteLine(item + " is number "+ i + " in your inventory");
			
		}
	}
}
