using System;
					
public class Program
{
	public void Main()
	{
		weapon[] weaponsObjs = {new weapon(), new weapon(), new weapon()};
		weaponsObjs[1].weaponName = "Spiked Shield";
		weaponsObjs[2].weaponName = "Gun";
		
		for(var i=0;i<weaponsObjs.Length;i++) {
			weaponsObjs[i].powerLevel = 2;
		}
		weaponsObjs[2].powerLevel = 4;
		
		foreach(var item in weaponsObjs) {
			Console.WriteLine(item.weaponName);
			Console.WriteLine(item.powerLevel);
		}
	}
}

public class weapon {
	public string weaponName = "Axe";
	public int powerLevel = 1;
}