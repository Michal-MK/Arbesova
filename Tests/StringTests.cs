using System;
using Arbesova;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
	[TestClass]
	public class StringTests {

		private readonly Strings strings = new Strings();

		//[TestMethod]
		//public void LengthTest() {
		//	Assert.IsTrue(strings.Length("") == 0);

		//	Assert.IsTrue(strings.Length("\t\t") == 2);
		//	Assert.IsTrue(strings.Length("abcd") == 4);
		//	Assert.IsTrue(strings.Length(" ") == 1);
		//	Assert.IsTrue(strings.Length("abcdefghijklmnopqrstuvwxzy") == 26);
		//}

		[TestMethod]
		public void Is10CharsLong() {
			Assert.IsTrue(strings.Is10CharsLong("0123456789"));
			Assert.IsTrue(strings.Is10CharsLong("\t\t\t\t\t\t\t\t\t\t"));

			Assert.IsFalse(strings.Is10CharsLong(""));
			Assert.IsFalse(strings.Is10CharsLong("0123456"));
			Assert.IsFalse(strings.Is10CharsLong("asdxc"));
		}

		[TestMethod]
		public void IsEvenLength() {
			Assert.IsTrue(strings.IsEvenLength(""));
			Assert.IsTrue(strings.IsEvenLength("Hello!"));
			Assert.IsTrue(strings.IsEvenLength("d\t"));
			Assert.IsTrue(strings.IsEvenLength("\t\t"));

			Assert.IsFalse(strings.IsEvenLength("Hello"));
			Assert.IsFalse(strings.IsEvenLength("\t"));
			Assert.IsFalse(strings.IsEvenLength("   "));
		}

		[TestMethod]
		public void IsOddLength() {
			Assert.IsTrue(strings.IsOddLength("Hello"));
			Assert.IsTrue(strings.IsOddLength("\t"));
			Assert.IsTrue(strings.IsOddLength(" "));

			Assert.IsFalse(strings.IsOddLength(""));
			Assert.IsFalse(strings.IsOddLength("Hello!"));
			Assert.IsFalse(strings.IsOddLength("d\t"));
			Assert.IsFalse(strings.IsOddLength("\t\t"));
		}

		[TestMethod]
		public void StartsWithUppercase() {
			Assert.IsTrue(strings.StartsWithUppercase("Hello"));
			Assert.IsTrue(strings.StartsWithUppercase("H"));
			Assert.IsTrue(strings.StartsWithUppercase("Get it?"));
			Assert.IsTrue(strings.StartsWithUppercase("OMG"));

			Assert.IsFalse(strings.StartsWithUppercase("hello"));
			Assert.IsFalse(strings.StartsWithUppercase(""));
			Assert.IsFalse(strings.StartsWithUppercase("\t"));
			Assert.IsFalse(strings.StartsWithUppercase("123456"));
			Assert.IsFalse(strings.StartsWithUppercase("."));
		}

		[TestMethod]
		public void ContainsXSpaces() {
			Assert.IsTrue(strings.ContainsXSpaces(0, "OMG"));
			Assert.IsTrue(strings.ContainsXSpaces(1, "OMG_ "));
			Assert.IsTrue(strings.ContainsXSpaces(2, "O M G"));
			Assert.IsTrue(strings.ContainsXSpaces(0, "\t"));
			Assert.IsTrue(strings.ContainsXSpaces(9, "Hello, my name is {insert name here}. How are you?"));
			Assert.IsTrue(strings.ContainsXSpaces(0, ""));
			Assert.IsTrue(strings.ContainsXSpaces(2, "  "));
		}

		[TestMethod]
		public void ContainsXCharacters() {
			Assert.IsTrue(strings.ContainsXCharacters(0, "OMG", 'p'));
			Assert.IsTrue(strings.ContainsXCharacters(1, "OMG_ ", '_'));
			Assert.IsTrue(strings.ContainsXCharacters(2, "O M G", ' '));
			Assert.IsTrue(strings.ContainsXCharacters(0, "\t", ' '));
			Assert.IsTrue(strings.ContainsXCharacters(3, "Hello, my name is {insert name here}. How are you?", 'm'));
			Assert.IsTrue(strings.ContainsXCharacters(7, "0251681861.026849811.01897835480.0898413", '1'));
			Assert.IsTrue(strings.ContainsXCharacters(0, "", 'a'));
		}

		[TestMethod]
		public void IsASentence() {
			Assert.IsTrue(strings.IsASentence("Hi."));
			Assert.IsTrue(strings.IsASentence("Hello how are you?"));
			Assert.IsTrue(strings.IsASentence("I am fine, Thanks!"));
			Assert.IsTrue(strings.IsASentence("Good day sir."));

			Assert.IsFalse(strings.IsASentence("Jeez"));
			Assert.IsFalse(strings.IsASentence("this is GREAT!"));
			Assert.IsFalse(strings.IsASentence(" "));
			Assert.IsFalse(strings.IsASentence(" ."));
			Assert.IsFalse(strings.IsASentence(".."));
			Assert.IsFalse(strings.IsASentence("...Hello again!"));
			Assert.IsFalse(strings.IsASentence("...Hello again,"));
			Assert.IsFalse(strings.IsASentence("Hello again,"));
			Assert.IsFalse(strings.IsASentence("and again!"));
		}

		[TestMethod]
		public void MirrorString() {
			Assert.IsTrue(strings.MirrorString("Hi.") == "Hi..iH");
			Assert.IsTrue(strings.MirrorString("Hello how are you?") == "Hello how are you??uoy era woh olleH");
			Assert.IsTrue(strings.MirrorString("Jeez") == "JeezzeeJ");
			Assert.IsTrue(strings.MirrorString(" ") == "  ");
			Assert.IsTrue(strings.MirrorString(" .") == " .. ");
			Assert.IsTrue(strings.MirrorString("..") == "....");
			Assert.IsTrue(strings.MirrorString("0123456789") == "01234567899876543210");
			Assert.IsTrue(strings.MirrorString("") == "");
			Assert.IsTrue(strings.MirrorString("Jelenovi pivo nelej") == "Jelenovi pivo nelejjelen ovip ivoneleJ");
		}

		[TestMethod]
		public void ReverseString() {
			Assert.IsTrue(strings.ReverseString("Hi.") == ".iH");
			Assert.IsTrue(strings.ReverseString("Hello how are you?") == "?uoy era woh olleH");
			Assert.IsTrue(strings.ReverseString("Jeez") == "zeeJ");
			Assert.IsTrue(strings.ReverseString(" ") == " ");
			Assert.IsTrue(strings.ReverseString(" .") == ". ");
			Assert.IsTrue(strings.ReverseString("..") == "..");
			Assert.IsTrue(strings.ReverseString("0123456789") == "9876543210");
			Assert.IsTrue(strings.ReverseString("") == "");
			Assert.IsTrue(strings.ReverseString("Jelenovi pivo nelej") == "jelen ovip ivoneleJ");
		}
	}
}
