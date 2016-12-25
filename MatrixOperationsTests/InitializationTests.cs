using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixOperations;

namespace MatrixOperationsTests
{
	[TestClass]
	public class InitializationTests
	{
		[TestMethod]
		public void TestSuccessfulInitialization()
		{
			Matrix matrix = new Matrix("1 2;3 4;");
		}

		[TestMethod]
		public void TestInitializationWithEmptyString()
		{
			try
			{
				new Matrix(string.Empty);
				Assert.Fail("Should have thrown exception");
			}
			catch (Exception e)
			{
				Assert.AreEqual("Empty matrix", e.Message);
			}
		}

		[TestMethod]
		public void TestInitializationWithNullString()
		{
			try
			{
				new Matrix(null);
				Assert.Fail("Should have thrown exception");
			}
			catch (Exception e)
			{
				Assert.AreEqual("Empty matrix", e.Message);
			}
		}

		[TestMethod]
		public void TestInitializationWithUnequalColumns()
		{
			try
			{
				new Matrix("1 2;3 4;5;");
				Assert.Fail("Should have thrown exception");
			}
			catch (Exception e)
			{
				Assert.AreEqual("Unequal number of columns in matrix", e.Message);
			}
		}
	}
}
