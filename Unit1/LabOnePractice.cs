/*
using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}
*/

using System;
					
public class Program
{
	public static void Main()
	{
		int initialHp = 19;
		int damage = 5; 
		int remainingHp = initialHp - damage;
		Convert.ToString(initialHp);
		Convert.ToString(damage);
		Convert.ToString(remainingHp);
		string characterName = "Nigrath";
		
		Console.WriteLine(characterName + " had " + initialHp + " Hp but took " + damage + " damage leaving them with " + remainingHp + " Hp remaining.");
		
	}
}
