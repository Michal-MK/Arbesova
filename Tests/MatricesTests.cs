using Arbesova;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests {
	[TestClass]
	public class MatricesTests {


		private static readonly double[][] _3X3Matrix = new double[][] {
			 new double[] { 1, 2, 3 },
			 new double[] { 4, 5, 6 },
			 new double[] { 7, 8, 9 },
		};

		private static readonly double[][] _3X3MatrixDoubled = new double[][] {
			 new double[] {  2,  4,  6 },
			 new double[] {  8, 10, 12 },
			 new double[] { 14, 16, 18 },
		};

		private static readonly double[][] _3X3MatrixTripled = new double[][] {
			 new double[] {  3,  6,  9 },
			 new double[] { 12, 15, 18 },
			 new double[] { 21, 24, 27 },
		};

		private static readonly double[][] _3X3ZeroMatrix = new double[][] {
			 new double[] { 0, 0, 0 },
			 new double[] { 0, 0, 0 },
			 new double[] { 0, 0, 0 },
		};

		private static readonly double[][] _3X3OneMatrix = new double[][] {
			 new double[] { 1, 1, 1 },
			 new double[] { 1, 1, 1 },
			 new double[] { 1, 1, 1 },
		};

		private static readonly double[][] _3X5Matrix = new double[][] {
			 new double[] {  1,  2,  3 },
			 new double[] {  4,  5,  6 },
			 new double[] {  7,  8,  9 },
			 new double[] { 10, 11, 12 },
			 new double[] { 13, 14, 15 },
		};

		private static readonly double[][] _5X5Matrix = new double[][] {
			 new double[] {  1,  2,  3, 16, 17 },
			 new double[] {  4,  5,  6, 18, 19 },
			 new double[] {  7,  8,  9, 20, 21 },
			 new double[] { 10, 11, 12, 22, 23 },
			 new double[] { 13, 14, 15, 24, 25 },
		};

		private static readonly double[][] _1X1Matrix = new double[][] {
			 new double[] { 1 }
		};

		private static readonly double[][] _3X3UnitMatrix = new double[][] {
			 new double[] { 1, 0, 0 },
			 new double[] { 0, 1, 0 },
			 new double[] { 0, 0, 1 },
		};

		private static readonly double[][] _1X3UnitVector = new double[][] {
			 new double[] { 1 },
			 new double[] { 1 },
			 new double[] { 1 },
		};

		private static readonly double[][] _3X1UnitVector = new double[][] {
			 new double[] { 1, 1, 1 }
		};

		private static readonly double[][] _3X3DoublingMatrix = new double[][] {
			 new double[] { 2, 0, 0 },
			 new double[] { 0, 2, 0 },
			 new double[] { 0, 0, 2 },
		};

		private static readonly double[][] _3X3TriplingMatrix = new double[][] {
			 new double[] { 3, 0, 0 },
			 new double[] { 0, 3, 0 },
			 new double[] { 0, 0, 3 },
		};

		private Matrix M3x3 = MatrixHelper.FromArray(_3X3Matrix);
		private Matrix M3x3Zero = MatrixHelper.FromArray(_3X3ZeroMatrix);
		private Matrix M3x3One = MatrixHelper.FromArray(_3X3OneMatrix);
		private Matrix M1x1 = MatrixHelper.FromArray(_1X1Matrix);
		private Matrix M1x3 = MatrixHelper.FromArray(_1X3UnitVector);
		private Matrix M3x1 = MatrixHelper.FromArray(_3X1UnitVector);
		private Matrix M5x5 = MatrixHelper.FromArray(_5X5Matrix);
		private Matrix M3x5 = MatrixHelper.FromArray(_3X5Matrix);
		private Matrix M3x3Unit = MatrixHelper.FromArray(_3X3UnitMatrix);
		private Matrix M3x3Double = MatrixHelper.FromArray(_3X3DoublingMatrix);
		private Matrix M3x3Doubled = MatrixHelper.FromArray(_3X3MatrixDoubled);
		private Matrix M3x3Triple = MatrixHelper.FromArray(_3X3TriplingMatrix);
		private Matrix M3x3Tripled = MatrixHelper.FromArray(_3X3MatrixTripled);


		[TestMethod]
		public void TestMatricesWidthHeight() {
			Assert.IsTrue(M1x1.Height == 1);
			Assert.IsTrue(M1x1.Width == 1);
			Assert.IsTrue(M3x3.Width == 3);
			Assert.IsTrue(M3x3.Height == 3);
			Assert.IsTrue(M1x3.Width == 1);
			Assert.IsTrue(M1x3.Height == 3);
			Assert.IsTrue(M3x1.Width == 3);
			Assert.IsTrue(M3x1.Height == 1);
			Assert.IsTrue(M5x5.Height == 5);
			Assert.IsTrue(M5x5.Height == 5);
		}


		[TestMethod]
		public void TestMatricesGet() {
			// 1,  2,  3, 16, 17
			// 4,  5,  6, 18, 19
			// 7,  8,  9, 20, 21
			//10, 11, 12, 22, 23
			//13, 14, 15, 24, 25

			Assert.IsTrue(M5x5.Get(0, 0) == 1);
			Assert.IsTrue(M5x5.Get(2, 0) == 3);
			Assert.IsTrue(M5x5.Get(2, 1) == 6);
			Assert.ThrowsException<MatrixException>(() => M5x5.Get(-1, 0));
			Assert.ThrowsException<MatrixException>(() => M5x5.Get(6, 1));
			Assert.ThrowsException<MatrixException>(() => M5x5.Get(0, -1));
			Assert.ThrowsException<MatrixException>(() => M5x5.Get(0, 20));
			Assert.IsTrue(M5x5.Get(3, 3) == 22);
		}



		[TestMethod]
		public void TestMatricesGetRowOrCol() {
			// 1,  2,  3, 16, 17
			// 4,  5,  6, 18, 19
			// 7,  8,  9, 20, 21
			//10, 11, 12, 22, 23
			//13, 14, 15, 24, 25

			double[] row0 = new double[] { 1, 2, 3, 16, 17 };
			double[] row1 = new double[] { 4, 5, 6, 18, 19 };
			double[] row2 = new double[] { 7, 8, 9, 20, 21 };
			double[] row3 = new double[] { 10, 11, 12, 22, 23 };
			double[] row4 = new double[] { 13, 14, 15, 24, 25 };

			double[] col0 = new double[] { 1, 4, 7, 10, 13, };
			double[] col1 = new double[] { 2, 5, 8, 11, 14, };
			double[] col2 = new double[] { 3, 6, 9, 12, 15 };
			double[] col3 = new double[] { 16, 18, 20, 22, 24 };
			double[] col4 = new double[] { 17, 19, 21, 23, 25 };


			Assert.IsTrue(ArrayEquals(row0, M3x3.GetRow(0)));
			Assert.IsTrue(ArrayEquals(row1, M3x3.GetRow(1)));
			Assert.IsTrue(ArrayEquals(row2, M3x3.GetRow(2)));
			Assert.IsTrue(ArrayEquals(row3, M3x3.GetRow(3)));
			Assert.IsTrue(ArrayEquals(row4, M3x3.GetRow(4)));

			Assert.IsTrue(ArrayEquals(col0, M3x3.GetColumn(0)));
			Assert.IsTrue(ArrayEquals(col1, M3x3.GetColumn(1)));
			Assert.IsTrue(ArrayEquals(col2, M3x3.GetColumn(2)));
			Assert.IsTrue(ArrayEquals(col3, M3x3.GetColumn(3)));
			Assert.IsTrue(ArrayEquals(col4, M3x3.GetColumn(4)));

			Assert.ThrowsException<MatrixException>(() => M5x5.GetColumn(-1));
			Assert.ThrowsException<MatrixException>(() => M5x5.GetColumn(10));
			Assert.ThrowsException<MatrixException>(() => M5x5.GetRow(10));
			Assert.ThrowsException<MatrixException>(() => M5x5.GetRow(-5));
		}

		[TestMethod]
		public void AddMatrices() {
			Matrix m3x3_1 = MatrixHelper.FromArray(_3X3Matrix);
			Matrix m3x3_2 = MatrixHelper.FromArray(_3X3Matrix);
			Matrix m3x3_3 = MatrixHelper.FromArray(_3X3Matrix);
			Matrix m1x3 = MatrixHelper.FromArray(_1X3UnitVector);
			Matrix m1x1 = MatrixHelper.FromArray(_1X1Matrix);

			m3x3_1.Add(m3x3_1);

			m3x3_2.Add(m3x3_1);

			m1x1.Add(m1x1);
			m1x1.Add(m1x1);
			m1x1.Add(m1x1);
			m1x1.Add(m1x1);

			m3x3_3.Add(M3x3Zero);
			m3x3_3.Add(M3x3Zero);
			m3x3_3.Add(M3x3Zero);

			Assert.AreEqual(M3x3, m3x3_3);

			Assert.AreEqual(m1x1, MatrixHelper.FromArray(new double[1][] { new[] { 16d } }));

			Assert.AreEqual(_3X3MatrixDoubled, m3x3_1);
			Assert.AreEqual(_3X3MatrixTripled, m3x3_2);

			Assert.ThrowsException<MatrixException>(() => m1x3.Add(m3x3_1));
			Assert.ThrowsException<MatrixException>(() => m3x3_2.Add(m1x3));
			Assert.ThrowsException<MatrixException>(() => m3x3_2.Add(MatrixHelper.FromArray(_1X1Matrix)));
		}

		[TestMethod]
		public void SubtractMatrices() {
			Matrix m3x3_1 = MatrixHelper.FromArray(_3X3Matrix);
			Matrix m3x3_2 = MatrixHelper.FromArray(_3X3ZeroMatrix);

			m3x3_1.Subtract(m3x3_1);

			Assert.AreEqual(m3x3_2, m3x3_1);
			//More tests needed
		}

		[TestMethod]
		public void TransposeMatrices() {
			Matrix m1x1 = MatrixHelper.FromArray(_1X1Matrix);
			Matrix m3x3_unit = MatrixHelper.FromArray(_3X3UnitMatrix);
			Matrix m1x3_unit = MatrixHelper.FromArray(_1X3UnitVector);
			Matrix m3x1_unit = MatrixHelper.FromArray(_3X1UnitVector);
			Matrix m3x5_unit = MatrixHelper.FromArray(_3X5Matrix);


			Assert.AreEqual(m3x5_unit, m3x5_unit.Transpose().Transpose());

			Assert.AreEqual(m3x1_unit, m1x3_unit.Transpose());

			Assert.AreEqual(m1x1, m1x1.Transpose());
			Assert.AreEqual(m3x3_unit, m3x3_unit.Transpose());

			Assert.AreNotEqual(M3x3Double, m3x1_unit.Transpose());
			Assert.AreNotEqual(M1x3, M5x5.Transpose());
		}

		[TestMethod]
		public void MultiplyMatrices() {
			Matrix m = M1x1.Multiply(M1x1);
			Matrix m2 = M3x1.Multiply(M3x1);
			Matrix m3 = M3x3.Multiply(M3x3Double);
			Matrix m4 = M3x3.Multiply(M3x3Triple);

			Assert.AreEqual(m, M1x1);
			Assert.AreEqual(m2, M3x3One);
			Assert.AreEqual(m3, M3x3Doubled);
			Assert.AreEqual(m4, M3x3Tripled);

			Assert.ThrowsException<MatrixException>(() => M1x3.Multiply(M1x3));
			Assert.ThrowsException<MatrixException>(() => M1x1.Multiply(M3x3));
			Assert.ThrowsException<MatrixException>(() => M3x3Unit.Multiply(M5x5));
		}


		private bool ArrayEquals(double[] one, double[] two) {
			for (int i = 0; i < one.Length; i++) {
				if (one[i] != two[i]) return false;
			}
			return true;
		}
	}
}
