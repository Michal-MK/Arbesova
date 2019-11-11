using System;

namespace Arbesova {
	public class Matrix : IMatrix {
		public int Width => throw new NotImplementedException();

		public int Height => throw new NotImplementedException();

		public void Add(IMatrix other) {
			throw new NotImplementedException();
		}

		public double Get(int x, int y) {
			throw new NotImplementedException();
		}

		public void Set(int x, int y, double value) {
			throw new NotImplementedException();
		}

		public double[] GetColumn(int index) {
			throw new NotImplementedException();
		}

		public double[] GetRow(int index) {
			throw new NotImplementedException();
		}

		public Matrix Multiply(IMatrix other) {
			throw new NotImplementedException();
		}

		public void Subtract(IMatrix other) {
			throw new NotImplementedException();
		}

		public double[][] ToArray() {
			throw new NotImplementedException();
		}

		public Matrix Transpose() {
			throw new NotImplementedException();
		}

		#region Operators

		public static Matrix operator *(Matrix left, double right) {
			throw new NotImplementedException();
		}

		public static Matrix operator *(Matrix left, Matrix right) {
			throw new NotImplementedException();
		}

		public static Matrix operator +(Matrix left, Matrix right) {
			throw new NotImplementedException();
		}

		public static Matrix operator -(Matrix left, Matrix right) {
			throw new NotImplementedException();
		}

		#endregion
	}
}
