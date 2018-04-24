using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClockAngle;

namespace ClockAngle.Tests
{
  [TestClass]
  public class ClockAngleTest
  {
    [TestMethod]
    public void DoesSix_Return_OneEighty()
    {
      ClockAngle testClockAngle = new ClockAngle();
      Assert.AreEqual(180, testClockAngle.CalculateClockAngle(6,00));
    }
    [TestMethod]
    public void DoesSixThirty_Return_Fifteen()
    {
      ClockAngle testClockAngle = new ClockAngle();
      Assert.AreEqual(15, testClockAngle.CalculateClockAngle(6,30));
    }
    [TestMethod]
    public void DoesElevenOne_Return_ThirtyFivePointFive()
    {
      ClockAngle testClockAngle = new ClockAngle();
      Assert.AreEqual(35.5, testClockAngle.CalculateClockAngle(11,1));
    }
    [TestMethod]
    public void DoesTwelveOClock_Return_Zero()
    {
      ClockAngle testClockAngle = new ClockAngle();
      Assert.AreEqual(0, testClockAngle.CalculateClockAngle(12,0));
    }
  }
}
