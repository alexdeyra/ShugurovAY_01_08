using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ChelovekTests
{
    [TestMethod]
    public void Calculate_ForStandardChelovek_ReturnsCorrectValue()
    {
      
        var chelovek = new Program(175, 30, 70);
        double expected = (175 * 1.8) - (30 * 4.7) + (70 * 9.6) + 1255;
        
        
        double actual = chelovek.CalculateQ();
        
     
        Assert.AreEqual(expected, actual, 0.01);
    }
    
    [TestMethod]
    public void Calculate_ForFitGoal_Subtracts600()
    {
        
        var chelovek = new Chelovekgoal(175, 30, 70, "fit");
        double baseQ = (175 * 1.8) - (30 * 4.7) + (70 * 9.6) + 1255;
        double expected = baseQ - 600;
       
        double actual = chelovek.CalculateQ();
        
       
        Assert.AreEqual(expected, actual, 0.01);
    }
    
    [TestMethod]
    public void AllChelovek_AddsNewChelovek_CountIncreases()
    {
       
        int initialCount = Program.AllChelovek.Count;
        
      
        var chelovek = new Program(180, 40, 80);
        int newCount = Program.AllChelovek.Count;
       
        Assert.AreEqual(initialCount + 1, newCount);
    }
}

