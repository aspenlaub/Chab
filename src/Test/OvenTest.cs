using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aspenlaub.Net.GitHub.CSharp.ChabStandard.Test {
    [TestClass]
    public class OvenTest {
        [TestMethod]
        public void CanBakeACake() {
            var sut = new Oven();
            var cake = sut.BakeACake();
            Assert.IsNotNull(cake);
        }
    }
}
