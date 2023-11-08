using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaltsevVS.ConsoleApp.Lab5.V0.Lib;

namespace Tyuiu.MaltsevVS.ConsoleApp.Lab4.V0.Test;

[TestClass]
public class SequenceCalculatorTests
{
    [TestMethod]
    public void CalculateSum_NIs1_ReturnsExpectedResult()
    {
        int N = 1;

        double result = SequenceCalculator.CalculateSum(N);

        Assert.AreEqual(1.022, result, 1e-3); 
    }

    [TestMethod]
    public void CalculateSum_NIs10_ReturnsExpectedResult()
    {
        int N = 6;

        double result = SequenceCalculator.CalculateSum(N);

        Assert.AreEqual(0.036, result, 1e-3);
    }
}
