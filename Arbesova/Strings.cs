using System;
using System.Linq;

namespace Arbesova {
	public class Strings {

		// You are not allowed to use any string functions/properties.
		// Only exception is "text".Length
		// Everything here can be implemented with the knowledge you already should have/is said in here.


		//Check if the string is exactly 10 characters long
		public bool Is10CharsLong(string str) {
			//By reading the introduction we can see that strings have fuctions that can be called
			//but we can not use any of them here, we are allowed to use the .Length property only
			//-> Properties are variables the difference will be revealed later
			//This function has to return a Boolean value true/false (yes/no) for question Is10CharsLong?
			//Using the == operator to check for equality, we can determine the truth of the question with given parameter
			//-> The keyword 'return' gives the result back to whoever asked
			return str.Length == 10;
		}

		//Check if the string contains even number of characters
		public bool IsEvenLength(string str) {
			//Condition whether the .Length property of strings modulo 2 is 0
			//The % operator is called 'modulo' and returns the remainder of integer division
			//-> 2 % 2 = 0
			//-> 3 % 2 = 1
			//-> 4 % 2 = 0
			//This allows us to check if a number is divisible by 2 without a reminder -> the definition of even numbers
			//The == operator is evaluated after the result of our modulus
			return str.Length % 2 == 0;	
		}

		//Check if the string contains odd number of characters
		//Think before you implement this!
		//!false -> true
		//!true -> false
		public bool IsOddLength(string str) {
			//By definition (which I won't cover here, but is fairly straight forward) odd numbers are a complement of even numbers
			//For simplicity we can work with Z^+ set. because strings can not be of negative sizes
			//We have already written the function to test for even length, so we just have to define a complement
			//The return type of this function is 'bool'
			//-> Boolean values are only 'true' and 'false'
			//complement to true is false and vice versa
			//In many programing languages the ! (not) operator returns the opposite value of the bool
			//This leaves us with this line of code
			return !IsEvenLength(str);

			//Explicitly we could write it like so, but forget I showed you this!
			//if (str.Length % 2 == 0) {
			//	return true;
			//}
			//return false;
		}

		//Is the first letter of the string a capital letter?
		public bool StartsWithUppercase(string str) {
			//For this, we need to know that strings can be indexed to return the index-th character
			//->INDEXING STARTS WITH 0!
			//So we want to check whether the first char of our string is capitalized
			//For that we have a function called 'IsUpper' defined in 'char'
			//The definition is as follows 'bool IsUpper(char c)'
			//However, empty string is also a string and indexing an empty string is bad
			if (str.Length == 0) {
				//If the string is empty it surely does not start with a capital letter
				return false;
			}
			//Otherwise do as described above
			return char.IsUpper(str[0]);
		}

		//Does the string contain exactly 'spaceCount' spaces?
		//Think before you implement this!
		public bool ContainsXSpaces(int spaceCount, string str) {
			// Possible inputs into this function
			// "Hello World", 1 -> true
			// "Hello World 2", 1 -> true
			// "  ", 2 -> true
			// "Hello", 2 -> false
			// "", 1 -> false

			//So we have a string of set length, any character between and including the first and the last can be a space -> ' '
			//This means a loop is needed (we only know of one at the moment so this is easy)
			//-> for loop from the start to the end (.Length)
			//that way we have access to every character in the string, now we need to cound the spaces
			//for that we need a new variable, starting at 0 -> we found no spaces so far
			int spaces = 0;

			for (int i = 0; i < str.Length; i++) {
				//Check the i-th character and if it is a space, increment the space counter
				if (str[i] == ' ') {
					spaces++;
				}
			}
			//At the end we have how many spaces were in the input, and how many the caller wanted, so just compare them
			return spaces == spaceCount;

			//The code above can be simplified into this line, I would not use it
			//return str.Count(c => c == ' ') == spaceCount;
		}

		//Does the string contain exactly 'charCount' of 'character'?
		public bool ContainsXCharacters(int charCount, string str, char character) {
			return !true;
		}

		//Is this string a valid sentence?
		//A valid sentence is defined by starting with a capital letter and ending with a valid symbol
		//valid symbols include ['.', '?', '!']
		//The && and || operators work with bool values and return an AND result and a OR result of two values
		// true && true -> true
		// true && false -> false
		// false && true -> false
		// false && false -> flase
		// true || true -> true
		// true || false -> true
		// false || true -> true
		// false || false -> false
		public bool IsASentence(string str) {
			return !true;
		}

		// Return a string this time that contains a mirrored image of the input -> create a palindrome of even length
		// Vraťte řetězec, který obsahuje zrcadlený obraz vstupu -> vytvořte palindrom sudé délky
		// "Ahoj" -> "AhojjohA"
		public string MirrorString(string toMirror) {
			return "";
		}

		// Return a string where the last character appears first, the next to last appears second and so on...
		// Vraťte řetězec, kde se poslední znak objeví jako první, předposlední se objeví druhý a tak dále ...
		// "Ahoj" -> "johA"
		public string ReverseString(string toReverse) {
			return string.Empty;
		}
	}
}
