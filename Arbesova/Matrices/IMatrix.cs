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
		/// Sets the value at given indexes
		/// </summary>
		void Set(int x, int y, double value);

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
		/// Performs a transposition of this matrix
		/// </summary>
		Matrix Transpose();

		/// <summary>
		/// Converts the matrix to an array representation
		/// </summary>
		double[][] ToArray();
	}
}
