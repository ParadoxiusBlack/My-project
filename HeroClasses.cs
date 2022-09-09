using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		heroOne.armor = 1;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		heroTwo.armor = 3;
		
		heroThree.health = 5;
		heroThree.powerLevel = 0;
		heroThree.armor = 5;
		
		Console.WriteLine("Hero 1");
		Console.WriteLine("Health " + heroOne.health);
		Console.WriteLine("Power " + heroOne.powerLevel);
		Console.WriteLine("Armor " + heroOne.armor);
		
		Console.WriteLine("Hero 2");
		Console.WriteLine("Health " + heroTwo.health);
		Console.WriteLine("Power " + heroTwo.powerLevel);
		Console.WriteLine("Armor " + heroTwo.armor);
		
		Console.WriteLine("Hero 3");
		Console.WriteLine("Health " + heroThree.health);
		Console.WriteLine("Power " + heroThree.health);
		Console.WriteLine("Armor " + heroThree.armor);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public int armor;
}
