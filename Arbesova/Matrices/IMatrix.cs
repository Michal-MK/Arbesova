namespace Arbesova {
	public interface IMatrix {
		/// <summary>
		/// Width of the matrix
		/// </summary>
		int Width { get; }

		/// <summary>
		/// Width of the matrix
		/// </summary>
		int Height { get; }

		/// <summary>
		/// Return the value at given coorinates
		/// </summary>
		double Get(int x, int y);

		/// <summary>
		/// Gets the row at 'index' of this matrix
		/// </summary>
		double[] GetRow(int index);

		/// <summary>
		/// Gets the column at 'index' of this matrix
		/// </summary>
		double[] GetColumn(int index);

		/// <summary>
		/// Element-wise addition
		/// </summary>
		void Add(IMatrix other);

		/// <summary>
		/// Element-wise subtraction
		/// </summary>
		void Subtract(IMatrix other);

		/// <summary>
		/// Matrix multiplication
		/// </summary>
		Matrix Multiply(IMatrix other);

		/// <summary>
		/// Converts the matrix to an array representation
		/// </summary>
		/// <returns></returns>
		double[][] ToArray();
	}
}
