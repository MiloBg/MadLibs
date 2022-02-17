System.Console.WriteLine("Let's play Space Exploration Mad Lib!");

string name, sillyWord, number, adjective, noun, adjectiveTwo, relative, adjectiveThree, verb, adjectiveFour, adjectiveFive;

Console.WriteLine("Please write a name:");
name = Console.ReadLine();

Console.WriteLine("Please write a silly word:");
sillyWord = Console.ReadLine();

Console.WriteLine("Please write a number:");
number = Console.ReadLine();

Console.WriteLine("Please write an adjective:");
adjective = Console.ReadLine();

Console.WriteLine("Please write a noun:");
noun = Console.ReadLine();

Console.WriteLine("Please write an adjective:");
adjectiveTwo = Console.ReadLine();

Console.WriteLine("Please write a person you are related to (a relative):");
relative = Console.ReadLine();

Console.WriteLine("Please write an adjective:");
adjectiveThree = Console.ReadLine();

Console.WriteLine("Please write a verb:");
verb = Console.ReadLine();

Console.WriteLine("Please write an adjective:");
adjectiveFour = Console.ReadLine();

Console.WriteLine("Please write an adjective:");
adjectiveFive = Console.ReadLine();

System.Console.Write($"Hello! My name is astronaut {name}! I am on my way to planet {sillyWord}. ");
System.Console.Write($"I'll be gone for {number} days. I am very {adjective} about the trip, but I will miss my {noun}. ");
System.Console.Write($"I have heard that the atmosphere there is {adjectiveTwo}. Luckily, my {relative} packed me a jacket to keep me {adjectiveThree}. ");
System.Console.Write($"When I land on the planet, I will {verb} for joy. I am {adjectiveFour} to walk on another planet. ");
System.Console.Write($"I could not be more {adjectiveFive} for this trip!");