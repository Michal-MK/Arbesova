using System;

namespace Arbesova {
	public class Strings {

		// You are not allowed to use any string functions/properties.
		// Only exception is "text".Length
		// Everything here can be implemented with the knowledge you already should have/is said in here.


		//Zjisti jestli řetězec str je dlouhý 10 znaků
		public bool Is10CharsLong(string str) {
			// Čtením úvodu vidíme, že řetězce mají funkce, které lze volat
			// zde ale nemůžeme použít ani jednu, můžeme používat pouze 'vlastnost' .Length
			// -> Vlastnosti jsou proměnné, rozdíl se dozvíte později
			// Tato funkce musí vrátit booleovskou hodnotu true / false (ano / ne) pro otázku Is10CharsLong?
			// Pomocí operátoru == ke kontrole rovnosti můžeme určit pravdivost otázky s daným parametrem
			// -> Klíčové slovo „return“ vrátí výsledek tomu, kdo volá tuto funkci
			return str.Length == 10;
		}

		//Zjisti jestli řetězec str je sudé délky
		public bool IsEvenLength(string str) {
			// Podmínka, zda je 'vlastnost' .Length řetězců modulo 2 je 0
			// Operátor % se nazývá 'modulo' a vrací zbytek celočíselného dělení
			// -> 2 % 2 = 0
			// -> 3 % 2 = 1
			// -> 4 % 2 = 0
			// To nám umožňuje zkontrolovat, zda je číslo dělitelné 2 beze zbytku -> definice sudých čísel
			// Operátor == je vyhodnocen po výsledku modula
			return str.Length % 2 == 0;
		}

		//Zjisti jestli řetězec str je liché délky
		//Zamyslete se před tím než toto napíšete, má to jednoduché řešení!
		//!false -> true
		//!true -> false
		public bool IsOddLength(string str) {
			// Podle definice (kterou zde neuvedu, ale je docela přímá) lichá čísla jsou doplňkem sudých čísel
			// Pro jednoduchost můžeme pracovat se sadou Z^+. protože řetězce nemohou mít zápornou délku
			// Už jsme psali funkci pro testování sudosti, takže musíme definovat doplněk
			// Návratový typ této funkce je 'bool'
			// -> Booleovské hodnoty jsou pouze „true“ a „false“
			// doplněk true je false a naopak
			// V mnoha programovacích jazycích oprátor '!' (ne) vrací opačnou hodnotu typu bool
			// Tím nám zbývá tento řádek kódu
			return !IsEvenLength(str);
		}

		//Je první písmeno str velké?
		public bool StartsWithUppercase(string str) {
			// K tomu potřebujeme vědět, že řetězce lze indexovat, tím dostaneme snak na index-té pozici
			// -> INDEXOVÁNÍ ZAČÍNÁ NA NULE!
			// Chceme tedy zkontrolovat, zda první znak našeho řetězce je kapitalizován (velkým písmenem)
			// K tomu máme funkci nazvanou 'IsUpper' definovanou v 'char'
			// Definice je následující: 'bool IsUpper (char c)'
			// Prázdný řetězec je však také řetězec a indexování prázdného řetězce je špatné

			if (str.Length == 0) {
				//Pokud je řetězec prázdný, určitě nezačne velkým písmenem
				return false;
			}
			//Jinak udělej to co je popsané nahoře
			return char.IsUpper(str[0]);
		}


		//Zjisti jestli řetězec str obsahuje přesně spaceCount mezer ' '
		//Zamyslete se před tím než toto napíšete, má to jednoduché řešení!
		public bool ContainsXSpaces(int spaceCount, string str) {
			//Mezera je charakter a na ně už funkci máme
			return ContainsXCharacters(spaceCount, str, ' ');
		}

		//Zjisti jestli řetězec str obsahuje přesně 'charCount' 'character'ů
		public bool ContainsXCharacters(int charCount, string str, char character) {
			// Možné vstupy do této funkce
			// "Hello World", 1, 'W' -> true
			// "Hello World 2", 1, 'o' -> true
			// "", 2, ' ' -> false
			// "Ahoj", 2, 'o' -> false

			// Takže máme řetězec o nějaké délce, libovolný znak mezi a včetně prvního a posledního může být 'character'
			// To znamená, že je potřeba cylkus (v tuto chvíli víme jen o jednom, takže je to snadné)
			// -> for loop od začátku do konce (.Length)
			// tímto způsobem máme přístup ke všem znakům v řetězci, nyní musíme spočítat po4et výskytů 'character'u
			// pro to potřebujeme novou proměnnou, počínaje 0 -> jsme zatím nenašli žádné 'character'y
			int charCounter = 0;

			for (int i = 0; i < str.Length; i++) {
				//Zkontrolujeme i-tý znak a pokud je to 'character', zvýšíme čítač
				if (str[i] == character) {
					charCounter++;
				}
			}
			// Na konci máme počet charakterů ze vstupu a kolik bylo očekáváno tak je porovnáme
			return charCounter == charCount;
		}



		// Je tento řetězec platnou větou?
		// Platná věta je definována tak, že začíná velkým písmenem a končí platným symbolem
		// platné symboly zahrnují ['.', '?', '!']
		// && a || operátory pracují s hodnotami bool a vracejí výsledek AND a OR dvou hodnot
		// true && true -> true
		// true && false -> false
		// false && true -> false
		// false && false -> false
		// true || true -> true
		// true || false -> true
		// false || true -> true
		// false || false -> false
		public bool IsASentence(string str) {
			//To jestli řetězec začíná velkým písmenem už umíme, tak jen zkontrolujeme poslední znak a jednotlivé booleovské výsledky vhodně spojíme
			//Musí platit že začíná velkým a pak musí platit jeden z možných konců
			return StartsWithUppercase(str) && (str[str.Length - 1] == '.' || str[str.Length - 1] == '?' || str[str.Length - 1] == '!');
		}

		// Vraťte řetězec, který obsahuje zrcadlený obraz vstupu -> vytvořte palindrom sudé délky
		// "Ahoj" -> "AhojjoaH"
		public string MirrorString(string toMirror) {
			return toMirror + ReverseString(toMirror);
		}

		// Vraťte řetězec, kde se poslední znak objeví jako první, předposlední se objeví druhý a tak dále ...
		// "Ahoj" -> "joaH"
		public string ReverseString(string toReverse) {
			string mirrored = "";
			for (int i = toReverse.Length - 1; i >= 0; i--) {
				mirrored += toReverse[i];
			}
			return mirrored;
		}
	}
}
