using System;

namespace MatrixOperations
{
    public class Matrix
    {
		private double[,] MatrixImpl;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="matrixString">The string representation for the matrix</param>
		public Matrix(string matrixString)
		{
			this.InitializeMatrix(matrixString);
		}

		/// <summary>
		/// Display the given matrix
		/// </summary>
		public void Display()
		{
			for (int i = 0; i < MatrixImpl.GetLength(0); i++)
			{
				for (int j = 0; j < MatrixImpl.GetLength(1); j++)
				{
					Console.Write(MatrixImpl[i,j] + " ");
				}
				Console.WriteLine();
			}
		}

		/// <summary>
		/// Initialize the matrix from the string representation
		/// </summary>
		/// <param name="matrixString">The string representation for the matrix</param>
		private void InitializeMatrix(string matrixString)
		{
			if (string.IsNullOrWhiteSpace(matrixString))
			{
				throw new Exception("Empty matrix");
			}

			// Remove last ';' from matrix string
			matrixString = matrixString.EndsWith(";") ? matrixString.Substring(0, matrixString.Length - 1) : matrixString;

			string[] matrixData = matrixString.Split(';');
			int rows = matrixData.Length;
			int columns = matrixData[0].Split(' ').Length;

			this.MatrixImpl = new double[rows, columns];

			int i = 0;
			foreach (string row in matrixData)
			{
				string[] rowValues = row.Split(' ');
				if (rowValues.Length != columns)
				{
					throw new Exception("Unequal number of columns in matrix");
				}

				int j = 0;
				foreach (string value in rowValues)
				{
					MatrixImpl[i, j] = Double.Parse(value);
					j++;
				}

				i++;
			}
		}
    }
}
