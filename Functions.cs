using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Hello World");
		CheeseSpeak();
		NumberGame(9,29,5);
	}
	public void CheeseSpeak()
	{
		Console.WriteLine("This is a guda cheese pun");
	}
	public void NumberGame(int number1, int number2, int number3)
	{
		var MathMan = number1 * number2 + number3;
		Console.WriteLine("(Batman themesong sound here) Number Number Number Number Number Number Number Number, MATH MAN! The answer is " + MathMan);
	}
}

