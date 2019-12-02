namespace Arbesova {
	public interface IMatrix {

		/*
		Matice: 3x3
		|1, 2, 3|
		|4, 5, 6|
		|7, 8, 9|
		*/

		/*
		Transponovaná Matice 3x3
		|1, 4, 7|
		|2, 5, 8|
		|3, 6, 9|
		*/

		/*
		Násobení Matice 3x3
		|1, 2, 3|     |2, 0, 0|     | 2,  4,  6|
		|4, 5, 6|  x  |0, 2, 0|  =  | 8, 10, 12|  
		|7, 8, 9|     |0, 0, 2|     |14, 16, 18|

		2  = 1*2 + 0*2 + 0*3
		4  = 0*2 + 2*2 + 0*3
		6  = 0*2 + 0*2 + 2*3

		8  = 2*4 + 0*5 + 0*6
		10 = 0*4 + 2*5 + 0*6
		12 = 0*4 + 0*5 + 2*6
		.
		.
		.
		*/

		/// <summary>
		/// Šířka matice
		/// </summary>
		int Width { get; }

		/// <summary>
		/// Výška matice
		/// </summary>
		int Height { get; }

		/// <summary>
		/// Vrať honotu z této matice na zadaných souřadnicích
		/// [0,0] je levý horní roh
		/// </summary>
		double Get(int x, int y);

		/// <summary>
		/// Nastav honotu této matice na zadaných souřadnicích
		/// [0,0] je levý horní roh
		/// </summary>
		void Set(int x, int y, double value);

		/// <summary>
		/// Vrať 'index'-tý řádek této matice
		/// </summary>
		double[] GetRow(int index);

		/// <summary>
		/// Vrať 'index'-ý sloupec této matice
		/// </summary>
		double[] GetColumn(int index);

		/// <summary>
		/// Přičti matici k této matici
		/// Sčítání probíhá tak, že sečteme prvky na stejných souřadnicích
		/// </summary>
		void Add(IMatrix other);

		/// <summary>
		/// Odečti matici od této matici
		/// Odčítání probíhá tak, že odečteme prvky na stejných souřadnicích
		/// </summary>
		void Subtract(IMatrix other);

		/// <summary>
		/// Vrať novou matici kterou získáme vynásobením této matice maticí 'other'
		/// </summary>
		Matrix Multiply(IMatrix other);

		/// <summary>
		/// Vrať transponovanou matici, transpozice znamená záměna řádků a sloupců
		/// </summary>
		Matrix Transpose();

		/// <summary>
		/// Převeď tuto matici do reprezentace pomocí polí
		/// </summary>
		double[][] ToArray();
	}
}
