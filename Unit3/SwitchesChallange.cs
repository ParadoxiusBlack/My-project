using System;

public class Program
{
	
	public HealthCondition healthCondition;
	
	public void Main()
	{
		healthCondition = new HealthCondition();
		healthCondition.CheckLife();
		string response = Console.ReadLine();
		if	(response == "Cure")
		{
			healthCondition.currentCondition = HealthCondition.life.cured;
			healthCondition.CheckLife();
		}
		else if (response == "Antidote")
		{
			healthCondition.currentCondition = HealthCondition.life.cured;
			healthCondition.CheckLife();
		}
		else 
		{
			healthCondition.currentCondition = HealthCondition.life.dead;
			healthCondition.CheckLife();
		}
	}
}

public class HealthCondition {
	
	public enum life {
		poisoned,
		cured,
		dead
	}
	
	public life currentCondition = life.poisoned;
	
	public void CheckLife () {
		switch(currentCondition) {
			case life.poisoned:
				Console.WriteLine("You are Poisoned, seek the antidote");
				break;
			case life.cured:
				Console.WriteLine("You are cured");
				break;
			case life.dead:
				Console.WriteLine("You have died");
				break;
			
		}
					
	}
}
