using System;
	
public class Program
{
	public Stats ninja;
		
	public void Main()
    {
		ninja = new Stats();
		
		ninja.stealth = 3.5;
		Console.WriteLine("Stealth Factor: " + ninja.stealth);
	}
}

public class Stats
{
		public double stealth;
}
