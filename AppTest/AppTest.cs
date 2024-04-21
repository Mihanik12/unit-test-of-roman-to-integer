using AppForTest;

namespace AppTest
{
    [TestClass]
    public class AppTest
    {
        [TestMethod]
        public void Incorrect_Roman_Num()
        {
            //arrange
            string romanNum = "dfkjng";
            int expected = 0;

            //act
            App app = new App();
            int actual = app.RomanToInt(romanNum);

            //assert
            Assert.AreEqual(expected, actual, "Read incorrect string. MISTAKE!!!");
        }

        [TestMethod]
        public void Normal_Roman_Num()
        {
            //arrange
            string romanNum = "CCCXXII";
            int expected = 322;

            //act
            App app = new App();
            int actual = app.RomanToInt(romanNum);

            //assert
            Assert.AreEqual(expected, actual, "Incorrect change to integer. MISTAKE!!!");
        }
    }
}