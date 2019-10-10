using System;
// ^^ We want to use code defined in there

// This is our class, a container for all the code we will write
class Program {
	//This is a function, this one specifically is important as it marks the beginning of our program and is called automatically
	static void Main(string[] args) {

		//This is a field, a simple string holding our paindrome
		string abc = "abccba";
		
		//Simple for loop, same as the one in TurtleGraphics
		for (int i = 0; i <= abc.Length/2; i++) {

			//This is a true/false check if it evalueates to 'True' the code inside runs, otherwise it is ignored.
			if (abc[i] != abc[(abc.Length - 1) - i]) {

				//This is a simple printing to the console
				Console.WriteLine("This is not a palindrome!");

				//Return keyword exits current function, as this is the entry function returning here closes the program
				return;
			}

			//This prints out the i-th character in our palindrome string
			Console.WriteLine(abc[i]);
		}

		//This just prints out the whole palindrome string but does not add a new line 
		Console.Write(abc);
		Console.WriteLine(" - is a palindrome!");

		//This line keeps the console open until we press 'Enter'
		Console.ReadLine();
	}
	//Every opening bracket needs to be closed!
}