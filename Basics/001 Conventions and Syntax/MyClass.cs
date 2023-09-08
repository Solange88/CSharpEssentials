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
		
		
		heroOne.health = 2;
		heroOne.powerLevel = 5;
		
		heroTwo.health = 3;
		heroTwo.powerLevel = 1;
		
		hero.health = 4;
	
		Console.WriteLine("Write your Name.");
		string heroThree = Console.ReadLine();
		Console.WriteLine(" Hello " + heroThree);
		Console.WriteLine("Your health is" + hero.health);
		Console.WriteLine("Your power level is" + heroOne.powerLevel);
		
		Console.WriteLine(heroTwo.health);
		Console.WriteLine(heroTwo.powerLevel);
	}
}

public class Hero {
	public int health;
	public int powerLevel;
}
