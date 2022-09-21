using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	public Weapon rifle;
	public Weapon spikedSheild;
	public Weapon grenades;
	
	public void Main()
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		heroThree = new Hero();
		
		rifle = new Weapon();
		spikedSheild = new Weapon();
		grenades = new Weapon();
		
		rifle.damage = 5;
		rifle.ammo = 8;
		rifle.protection = 1;
		
		spikedSheild.damage = 1;
		spikedSheild.ammo = 38;
		spikedSheild.protection = 4;
			
		grenades.damage = 20;
		grenades.ammo = 1;
		grenades.protection = 0;
			
		
		heroOne.health = 2;
		heroOne.powerLevel = 5 + grenades.damage;
		heroOne.armor = 1 + grenades.protection;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1 + rifle.damage;
		heroTwo.armor = 3 + rifle.protection;
		
		heroThree.health = 5;
		heroThree.powerLevel = 0 + spikedSheild.damage;
		heroThree.armor = 5 + spikedSheild.protection;
		
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
public class Weapon {
	public int damage;
	public int ammo;
	public int protection;
}
