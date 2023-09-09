//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers

//Based on the HelloWorld File, turn this into a class.

//Write a console program with a program class, and Main Function
//Add another class with any name, add variables 
//Using the new keyword create several objects
//Console writeline the Objects variables
using System;
					
public class Program
{
	public Hero heroOne;
	public Hero heroTwo;
	public Hero heroThree;
	public Hero hero;
	public void Main()
	
	{
		heroOne = new Hero();
		heroTwo = new Hero();
		hero = new Hero ();
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		
		hero.health = 4;
		hero.powerLevels = 3.5; 
	//created a new hero for user to input.
		Console.WriteLine("Write your Name.");
		string heroThree = Console.ReadLine();
		Console.WriteLine(" Hello " + heroThree);
		Console.WriteLine("Your health is " + hero.health);
		Console.WriteLine("Your power level is" + hero.powerLevels);
	//stats are preset but the player can put in their name	
		Console.WriteLine ("Hero Two is your opponent. are you up for the challenge? Type yes to see Hero Two's power level.");
				   Console.ReadLine ();
		Console.WriteLine("Hero two's health is " + heroTwo.health);
		Console.WriteLine("Hero two's power level is " + heroTwo.powerLevel);
				   Console.WriteLine ("  Ready? Type Go.");
				   Console.ReadLine ();
	}
}

public class Hero {
	public int health;
	public int powerLevel;
	public double powerLevels;
	//attempt to use a decimal value
}
