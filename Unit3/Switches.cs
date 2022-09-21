using System;

public class Program
{
	
	public Acolyte acolyte;
	
	public void Main()
	{
		acolyte = new Acolyte();
		acolyte.currentSect = Acolyte.Sects.Priest;
		acolyte.CheckSect();
	}
}

public class Acolyte {
	
	public enum Sects {
		Deacon,
		Priest,
		Bishop,
		Prophet
	}
	
	public Sects currentSect = Sects.Deacon;
	
	public void CheckSect () {
		switch(currentSect) {
			case Sects.Deacon:
				Console.WriteLine("You are a Deacon");
				break;
			case Sects.Priest:
				Console.WriteLine("You are a Priest");
				break;
			case Sects.Bishop:
				Console.WriteLine("You are a Bishop");
				break;
			case Sects.Prophet:
				Console.WriteLine("You are a Prophet");
				break;
		}
					
	}
}
