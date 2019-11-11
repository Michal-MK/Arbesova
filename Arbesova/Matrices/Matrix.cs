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

		public double[] GetColumn(int index) {
			throw new NotImplementedException();
		}

		public double[] GetRow(int index) {
			throw new NotImplementedException();
		}

		public void Multiply(IMatrix other) {
			throw new NotImplementedException();
		}

		public void Subtract(IMatrix other) {
			throw new NotImplementedException();
		}

		public double[][] ToArray() {
			throw new NotImplementedException();
		}
	}
}
