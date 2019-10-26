using System;

namespace Arbesova {
	public class Strings {

		// You are not allowed to use any string functions/properties.
		// Only exception is "text".Length
		// Everything here can be implemented with the knowledge you already should have/is said in here.
		

		//Check if the string is exactly 10 characters long
		public bool Is10CharsLong(string str) {
			return str.Length == 10;
		}

		//Check if the string contains even number of characters
		public bool IsEvenLength(string str) {
			return str.Length % 2 == 0;
		}

		//Check if the string contains odd number of characters
		//Think before you implement this!
		public bool IsOddLength(string str) {
			return !IsEvenLength(str);
		}

		//Is the first letter of the string a capital letter?
		public bool StartsWithUppercase(string str) {
			if (str.Length > 0) {
				return char.IsUpper(str[0]);
			}
			return false;
		}

		//Does the string contain exactly 'spaceCount' spaces?
		//Think before you implement this!
		public bool ContainsXSpaces(int spaceCount, string str) {
			return ContainsXCharacters(spaceCount, str, ' ');
		}

		//Does the string contain exactly 'spaceCount' of 'character' ?
		public bool ContainsXCharacters(int charCount, string str, char character) {
			int counter = 0;
			for (int i = 0; i < str.Length; i++) {
				if(str[i] == character) {
					counter++;
				}
			}
			return counter == charCount;
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
			if(str.Length == 0) {
				return false;
			}
			return char.IsUpper(str[0]) && (str[str.Length - 1] == '.' || str[str.Length - 1] == '?' || str[str.Length - 1] == '!');
		}

		//Return a string this time that contains a mirrored image of the input -> create a palindrome of even length
		public string MirrorString(string toMirror) {
			return toMirror + ReverseString(toMirror);
		}

		//Return a string where the last character appears first, the next to last appears second and so on...
		public string ReverseString(string toReverse) {
			string mirrored = "";
			for (int i = toReverse.Length - 1; i >= 0; i--) {
				mirrored += toReverse[i];
			}
			return mirrored;
		}
	}
}
