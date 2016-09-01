/*
 * Created by SharpDevelop.
 * User: JustFaith
 * Date: 8/8/2016
 * Time: 11:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace StoryLine
{
	class Program
	{
		public static void Main(string[] args)
		{
			string Name;
			string Location;
			string Hobby;
			string Occupation;
			
			Console.WriteLine("STORY LINE");
			
			Console.WriteLine("What is your name?");
			Name = Console.ReadLine();
			
			Console.WriteLine("Which town did you grow up?");
			Location = Console.ReadLine();
			
			Console.WriteLine("What is your hobby?");
			Hobby = Console.ReadLine();
			
			Console.WriteLine("what is your occupation");
			Occupation = Console.ReadLine();
			
			Console.WriteLine();
			
			Console.WriteLine("Once upon a time, there lived a person named {0}.", Name);
			Console.WriteLine("{0} grew up in {1}. One of his favorite hobbies is {2}", Name, Location, Hobby);
			Console.WriteLine("{0} is a {1} and has a lot of people working under him.", Name, Occupation);
			Console.WriteLine("Everyone admired {0}, because he is hardworking, humble and helps the needy", Name);
			Console.WriteLine("One policy that has helped him in life is honesty, which he believes is the best policy.");
			
			Console.WriteLine();
			
			
			
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}