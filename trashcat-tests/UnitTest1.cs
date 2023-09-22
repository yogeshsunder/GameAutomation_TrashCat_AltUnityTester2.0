
using AltTester.AltTesterUnitySDK.Driver;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

public class MyTests
{
  private AltDriver altDriver;
  [OneTimeSetUp]
  public void OneTimeSetUp()
  {
    altDriver = new AltDriver();
  }

  [OneTimeTearDown]
  public void TearDown()
  {
    altDriver.Stop();
  }

  [Test]
  public void Test()
  {
    var TextTMP = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/PlayButton/Text (TMP)");
    TextTMP.Click();
    var TextTMP1 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot1/Text (TMP)");
    TextTMP1.Click();
    var TextTMP2 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot5/Text (TMP)");
    altDriver.HoldButton(TextTMP2.GetScreenPosition(),0.2158203f);
    var TextTMP3 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot3/Text (TMP)");
    altDriver.HoldButton(TextTMP3.GetScreenPosition(),0.2099609f);
    var TextTMP4 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot4/Text (TMP)");
    TextTMP4.Click();
    var TextTMP5 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/Board/Slots/Slot2/Text (TMP)");
    TextTMP5.Click();
    var TextTMP6 = altDriver.WaitForObject(By.PATH,"/Canvas/MainContainer/BottomButtons/BackButton/Text (TMP)");
    TextTMP6.Click();
  }
}
