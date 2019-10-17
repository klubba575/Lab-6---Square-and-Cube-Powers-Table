using System;

namespace Lab_6_Powers_Table
{
	class Program
	{ 
		static void Main(string[] args)
		{
			Console.WriteLine("Learn your squares and cubes");
			do
			{
				userNumber();
			}
			while (GetContinue());
			Console.WriteLine("Alright, hope you enjoyed your table!");
		}	
  
		public static void userNumber()
		{
			Console.WriteLine("Please enter an integer");
			int number = int.Parse(Console.ReadLine());
			for (int i=1; i<=number; i++)
			{
				Console.WriteLine($"{i}\t {i*i}\t {i*i*i} ");
			
			}
		}
		public static bool GetContinue()
		{
			
			{
				Console.WriteLine("Would you like to try again?");
				
				string userAnswer = Console.ReadLine();
				switch(userAnswer.ToLower())
				{
					case "y":
						return true;
					case "n":
						return false;
					default:
						return GetContinue();
				}
			}
			
		}
	}
}
